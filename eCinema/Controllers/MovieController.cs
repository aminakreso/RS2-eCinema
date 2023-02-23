using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{   [AllowAnonymous]
    public class MovieController : BaseCRUDController<MovieDto, MovieSearchObject, MovieUpsertRequest, MovieUpsertRequest>
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
            : base(movieService)
        {
            _movieService = movieService;
        }
        
        [HttpPost]
        [Route("upload")]
        public virtual async Task<byte[]?> UploadPicture(IFormFile? pictureImage)
        {
            return await _movieService.UploadPicture(pictureImage);
        }

    }
}
