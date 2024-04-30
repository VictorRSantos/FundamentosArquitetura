using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class LifecycleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
