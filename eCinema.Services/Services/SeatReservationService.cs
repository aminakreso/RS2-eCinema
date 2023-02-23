using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services.Services
{
    public class SeatReservationService : BaseService<SeatxrefReservationDto, SeatxrefReservation, BaseSearchObject>, ISeatReservationService
    {
        public SeatReservationService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }
    }
}
