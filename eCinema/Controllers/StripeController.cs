using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers;

public class StripeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}