using Microsoft.AspNetCore.Mvc;

namespace SignalR1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
