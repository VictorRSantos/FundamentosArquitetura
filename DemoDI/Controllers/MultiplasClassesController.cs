using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class MultiplasClassesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
