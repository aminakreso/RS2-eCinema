using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Services.Services
{
    public class ReservationService : BaseCRUDService<ReservationDto, Reservation, ReservationSearchObject, ReservationUpsertRequest, ReservationUpsertRequest>,
        IReservationService
    {
        public ReservationService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }
        
        public override async Task<ReservationDto> Insert(ReservationUpsertRequest insert)
        {
            if (await CheckSeat(insert.SeatsId))
            {
                return new ReservationDto();
            }

            var user = await _cinemaContext.Users.FirstOrDefaultAsync();

            var reservation = new Reservation
            {
                UserId = user.Id,
                DateTime = DateTime.Now,
                IsActive = true,
                ProjectionId = insert.PojectionId
            };
            await _cinemaContext.AddAsync(reservation);
            await _cinemaContext.SaveChangesAsync();
            
            var seatList = new List<SeatxrefReservation>();

            foreach (var seatId in insert.SeatsId)
            {
                seatList.Add(new SeatxrefReservation
                {
                    ReservationId = reservation.Id,
                    SeatId = seatId,
                    IsTaken = true
                });
            }

            await _cinemaContext.AddRangeAsync(seatList);
            await _cinemaContext.SaveChangesAsync();

            return _mapper.Map<ReservationDto>(reservation);
            
        }

        private async Task<bool> CheckSeat(List<Guid> insertSeatsId)
        {
            foreach (var seatId in insertSeatsId )
            {
                var flag = await _cinemaContext.SeatReservations.AnyAsync(x => x.SeatId == seatId);
                if (flag)
                {
                    return flag;
                }
            }
            return false;
        }

        public override IQueryable<Reservation> AddInclude(IQueryable<Reservation> query, ReservationSearchObject search = null)
        {
            query = query.Include(x => x.SeatsReservations);
            query = query.Include(x => x.Projection);
            query = query.Include(x => x.Projection.Movie);
            return query;
        }
        
        public override IQueryable<Reservation> AddFilter(IQueryable<Reservation> query, ReservationSearchObject search)
        {
            var filteredQuery = query;

            if (!string.IsNullOrWhiteSpace(search.Name))
                filteredQuery = filteredQuery.Include(x => x.Projection.Movie)
                    .Where(x => x.Projection.Movie.Name.ToLower().Contains(search.Name.ToLower()));

            if (!string.IsNullOrWhiteSpace(search.User))
                filteredQuery = filteredQuery.Include(x => x.User).Where(x => x.User.FirstName.ToLower().Contains(search.User.ToLower())
                || x.User.LastName.ToLower().Contains(search.User.ToLower()));
            
            if (search.DateTime is not null)
                filteredQuery = filteredQuery.Where(x => x.DateTime.Value.Date == search.DateTime);
            
            return filteredQuery;

        }
    }
}
