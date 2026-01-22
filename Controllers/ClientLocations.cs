 using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcClientLocation.Controllers
{
    public class ClientLocations : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
