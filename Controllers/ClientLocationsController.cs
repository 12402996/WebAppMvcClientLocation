 using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcClientLocation.Controllers
{
    public class ClientLocationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
