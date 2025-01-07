using Microsoft.AspNetCore.Mvc;

namespace WEB_Karaoke.Controllers
{
    public class HallController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
