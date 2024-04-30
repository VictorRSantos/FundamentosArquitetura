using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
