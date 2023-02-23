using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        
        // public override async Task<MovieDto> Insert(MovieUpsertRequest insert)
        // {
        //     var newMovie = new Movie()
        //     {
        //         Actors = insert.Actors,
        //         Director = insert.Director,
        //         Description = insert.Description,
        //         Country = insert.Country,
        //         Duration = insert.Duration,
        //         Genres = insert.Genres,
        //         IsActive = true,
        //         Name = insert.Name,
        //         Picture = insert.Path
        //     };
        //     await _cinemaContext.AddAsync(newMovie);
        //     await _cinemaContext.SaveChangesAsync();
        //
        //     return new MovieDto
        //     {
        //         Id = newMovie.Id,
        //         Name = newMovie.Name,
        //         Description = newMovie.Description,
        //         Duration = newMovie.Duration,
        //         ReleaseYear = newMovie.ReleaseYear,
        //         Country = newMovie.Country,
        //         Actors = newMovie.Actors,
        //         Director = newMovie.Director,
        //         Picture = newMovie.Picture,
        //         Genres = newMovie.Genres,
        //         IsActive = newMovie.IsActive
        //     };
        // }

        public override async void BeforeInsert(MovieUpsertRequest insert, Movie entity)
        {
            entity.Picture = await UploadPicture(insert.AcctualPicture);
        }

        public async Task<byte[]?> UploadPicture(IFormFile? pictureImage)
        {

            //var fileName = $"{Guid.NewGuid()}.jpg";
            //await using var fileStream = new FileStream(filePath, FileMode.Create);

            long length = pictureImage.Length;
            if (length < 0)
                throw new Exception("ex");
            byte[] bytes = new byte[length];
            
            var stream = new MemoryStream(bytes);
            pictureImage.CopyTo(stream);
            var t=stream.ToArray();
            return t;

        }
    }
}
