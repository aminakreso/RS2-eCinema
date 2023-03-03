using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;

namespace eCinema.Services.Services
{
    public class PriceService : BaseCRUDService<PriceDto, Price, PriceSearchObject, PriceUpsertRequest, PriceUpsertRequest>,
        IPriceService
    {
        public PriceService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }

        public override IQueryable<Price> AddFilter(IQueryable<Price> query, PriceSearchObject search)
        {
            var filteredQuery = query;

            if (!string.IsNullOrWhiteSpace(search.Name))
                filteredQuery = filteredQuery.Where(x => x.Name!.ToLower().Contains(search.Name.ToLower()));

            return filteredQuery;

        }

    }
}
