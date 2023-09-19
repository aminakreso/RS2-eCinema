using AutoMapper;
using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services.Services
{
    public class FITPasosService : BaseCRUDService<FITPasosDto, FITPasos, FITPasosSearchObject, FITPasosUpsertRequest, FITPasosUpsertRequest>, IFITPasosService
    {
        public FITPasosService(CinemaContext cinemaContext, IMapper mapper) : base(cinemaContext, mapper)
        {
        }

        public override IQueryable<FITPasos> AddInclude(IQueryable<FITPasos> query, FITPasosSearchObject search = null)
        {
            query = query.Include(x => x.User);
            return query;
        }

        public override IQueryable<FITPasos> AddFilter(IQueryable<FITPasos> query, FITPasosSearchObject search)
        {
            var filteredQuery = query;

            if (!string.IsNullOrWhiteSpace(search.User))
                filteredQuery = filteredQuery.Include(x => x.User).Where(x => x.User.FirstName.ToLower().Contains(search.User.ToLower())
                || x.User.LastName.ToLower().Contains(search.User.ToLower()));

            if (search.ExpirationDate is not null)
                filteredQuery = filteredQuery.Where(x => x.ExpirationDate.Value.Date == search.ExpirationDate.Value.Date);

            return filteredQuery;

        }
    }
}
