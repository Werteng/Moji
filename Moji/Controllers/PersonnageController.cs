using Microsoft.AspNetCore.Mvc;

namespace Moji.Controllers
{
    public class PersonnageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Creation()
        {
            return View();
        }
        
    }
}