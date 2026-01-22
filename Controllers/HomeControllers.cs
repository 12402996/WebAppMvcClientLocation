using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebAppMvcClientLocation.Data;
using WebAppMvcClientLocation.Models;

namespace WebAppMvcClientLocation.Controllers
{
    public class HomeControllers : Controller
    {
        public HomeControllers()
        {
            //Database db = new Database(); -> Zonder static class geef je die mee
            //db.StartDataBase();
        }

        public IActionResult Index()
        {
            ViewBag.ClientCount = Database.Clients.Count();
            ViewBag.LocationCount = Database.Locations.Count();
            return View();
        }
    }
}
