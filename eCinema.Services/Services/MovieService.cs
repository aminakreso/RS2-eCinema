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
        
        //public async Task<byte[]?> UploadPicture(IFormFile? pictureImage)
        //{

        //    //var fileName = $"{Guid.NewGuid()}.jpg";
        //    //await using var fileStream = new FileStream(filePath, FileMode.Create);

        //    long length = pictureImage.Length;
        //    if (length < 0)
        //        throw new Exception("ex");
        //    byte[] bytes = new byte[length];
            
        //    var stream = new MemoryStream(bytes);
        //    pictureImage.CopyTo(stream);
        //    var t=stream.ToArray();
        //    return t;

        //}
    }
}
