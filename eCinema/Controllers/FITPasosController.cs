using eCinema.Model.Dtos;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using eCinema.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{

    public class FITPasosController : BaseCRUDController<FITPasosDto, FITPasosSearchObject, FITPasosUpsertRequest, FITPasosUpsertRequest>
    {
        public FITPasosController(IFITPasosService pasosService)
          : base(pasosService) { }
      
    }
}
