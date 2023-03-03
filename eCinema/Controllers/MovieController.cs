﻿using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{   
    public class MovieController : BaseCRUDController<MovieDto, MovieSearchObject, MovieUpsertRequest, MovieUpsertRequest>
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
            : base(movieService)
        {
            _movieService = movieService;
        }

    }
}
