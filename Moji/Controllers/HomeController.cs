using Microsoft.AspNetCore.Mvc;

namespace Moji.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }
    }
}