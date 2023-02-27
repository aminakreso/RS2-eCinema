﻿using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Services.Services
{
    public class SeatReservationService : BaseService<SeatxrefReservationDto, SeatxrefReservation, SeatReservationSearchObject>, ISeatReservationService
    {
        public SeatReservationService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }
        
        public override IQueryable<SeatxrefReservation> AddFilter(IQueryable<SeatxrefReservation> query, SeatReservationSearchObject search)
        {
            var filteredQuery = query;

            if (search.ProjectionId != Guid.Empty && search.ProjectionId is not null)
                filteredQuery = filteredQuery.Include(x=>x.Reservation)
                    .Where(x => x.Reservation.ProjectionId == search.ProjectionId);


            return filteredQuery;

        }
    }
}
