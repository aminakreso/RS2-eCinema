using eCinema.Model.Dtos;
using eCinema.Model.SearchObjects;
using eCinema.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    [AllowAnonymous]
    public class SeatReservationController : BaseController<SeatxrefReservationDto, BaseSearchObject>
    {
        public SeatReservationController(ISeatReservationService service) : base(service)
        {
        }
    }
}
