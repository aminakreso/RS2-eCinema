using System.Security.Cryptography;
using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;

namespace eCinema.Services.Services
{
    public class MovieService : BaseCRUDService<MovieDto, Movie, MovieSearchObject, MovieUpsertRequest, MovieUpsertRequest>,
        IMovieService
    {
        public MovieService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }

        public override IQueryable<Movie> AddFilter(IQueryable<Movie> query, MovieSearchObject search)
        {
            var filteredQuery = query;

            if(!string.IsNullOrWhiteSpace(search.Name))
                filteredQuery = filteredQuery.Where(x => x.Name!.ToLower().Contains(search.Name.ToLower()));

            if (!string.IsNullOrWhiteSpace(search.Director))
                filteredQuery = filteredQuery.Where(x => x.Director!.ToLower().Contains(search.Director.ToLower()));

            if (!string.IsNullOrWhiteSpace(search.Genres) && search.Genres!="Svi")
                filteredQuery = filteredQuery.Where(x => x.Genres!.ToLower().Contains(search.Genres.ToLower()));

            return filteredQuery;

        }
        static object isLocked = new object();
        static MLContext mlContext = null;
        static ITransformer model = null;

        public async Task<List<MovieDto>> Recommend(Guid id)
        {
            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();
                    // lista usera
                    var tmpData = _cinemaContext.Users.Include(x => x.Reservations).ThenInclude(y => y.Projection).ToList();
                    List<ProductEntry> data = new List<ProductEntry>();

                    foreach (var x in tmpData)
                    {
                        var counterUser = 0;
                        if (x.Reservations.Count > 1)
                        {
                            if (x.Reservations.Any(x => x.Projection?.MovieId == id))
                            {
                                // movieId
                                var distinctItemId = x.Reservations.Select(y => y.Projection?.MovieId).ToList();

                                distinctItemId.ForEach(y =>
                                {
                                    var relatedItems = x.Reservations.Where(z => z.Projection?.MovieId != y);

                                    foreach (var z in relatedItems)
                                    {
                                        var movie = _cinemaContext.Movies.Find(y);
                                        data.Add(new ProductEntry()
                                        {
                                            MovieId = (uint)_cinemaContext.Movies.Local.ToList().IndexOf(movie),
                                            UserId = (uint) counterUser,
                                        });
                                    }

                                });
                            }
                        }

                        counterUser++;
                    }

                    var traindata = mlContext.Data.LoadFromEnumerable(data);


                    //STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
                    //        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer.
                    MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                    options.MatrixColumnIndexColumnName = nameof(ProductEntry.MovieId);
                    options.MatrixRowIndexColumnName = nameof(ProductEntry.UserId);
                    options.LabelColumnName = "Label";
                    options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                    options.Alpha = 0.01;
                    options.Lambda = 0.025;
                    // For better results use the following parameters
                    options.NumberOfIterations = 100;
                    options.C = 0.00001;


                    var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                    model = est.Fit(traindata);
                }

            }
            
            var allItems = await _cinemaContext.Reservations.Where(x => x.Projection!.MovieId != id).ToListAsync();

            var movieFor = await _cinemaContext.Movies.FindAsync(id);
            var movieId = (uint)_cinemaContext.Movies.Local.ToList().IndexOf(movieFor);

            var predictionResult = new List<Tuple<Movie, float>>();

            foreach (var item in allItems)
            {
                var counter = 0;
                var predictionEngine =
                    mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                var prediction = predictionEngine.Predict(new ProductEntry()
                {
                    MovieId = (uint)movieId,
                    UserId = (uint)(counter)
                });

                var movie = item!.Projection!.Movie;
                if (movie != null)
                    predictionResult.Add(new Tuple<Movie, float>(movie, prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                .Select(x => x.Item1).Distinct().Take(3).ToList();

            var returnList = await _cinemaContext.Movies.Where(x =>
                    x.Name == finalResult[0].Name || x.Name == finalResult[1].Name || x.Name == finalResult[2].Name)
                .ToListAsync();
            mlContext = null;
            
            return _mapper.Map<List<MovieDto>>(returnList);
        }

       
    }
    
    public class Copurchase_prediction
    {
        public float Score { get; set; }
    }
    
    public class ProductEntry
    {
        [KeyType(count: 10)]
        public uint MovieId { get; set; }
        [KeyType(count: 10)]
        public uint UserId { get; set; }
        
        public float Label { get; set; }
    }
}

