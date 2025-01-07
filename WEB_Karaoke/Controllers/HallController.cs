using Microsoft.AspNetCore.Mvc;
using WEB_Karaoke.Models;

namespace WEB_Karaoke.Controllers
{
    public class HallController : Controller
    {
        List<Visitor> _clientList = new List<Visitor>()
        {
            new Visitor {Id = 1,UserName = "Gek", MyStatus = Visitor.Status.Gold,SongList = new List<string>(){"Soung 1", "Soung 2" } },
            new Visitor {Id = 1,UserName = "Don", MyStatus = Visitor.Status.Gold,SongList = new List<string>(){"Soung 3", "Soung 4" } },
            new Visitor {Id = 1,UserName = "Max", MyStatus = Visitor.Status.Gold,SongList = new List<string>(){"Soung 5", "Soung 6" } }

        };


        public IActionResult Index()
        {
            return View(_clientList);
        }
        public IActionResult Soung(string Id)
        {
            return Content($"Hall controller >> {Id} <<");
        }
    }
}
