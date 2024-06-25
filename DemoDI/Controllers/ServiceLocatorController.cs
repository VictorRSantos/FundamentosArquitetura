using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
