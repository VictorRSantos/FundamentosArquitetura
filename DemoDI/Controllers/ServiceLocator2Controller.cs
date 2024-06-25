using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
