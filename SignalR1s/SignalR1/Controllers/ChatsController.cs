using Microsoft.AspNetCore.Mvc;

namespace SignalR1.Controllers
{
    public class ChatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
