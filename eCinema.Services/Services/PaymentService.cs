using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Services.Services
{
    public class PaymentService : BaseCRUDService<PaymentDto, Payment, BaseSearchObject, PaymentUpsertRequest, PaymentUpsertRequest>,
        IPaymentService
    {
        public PaymentService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }
        
        // public override async Task<PaymentDto> Insert(PaymentUpsertRequest insert)
        // {
        //
        // }

        public override IQueryable<Payment> AddInclude(IQueryable<Payment> query, BaseSearchObject search = null)
        {
            query = query.Include(x => x.Reservation);
            return query;
        }
        
        
    }
}
