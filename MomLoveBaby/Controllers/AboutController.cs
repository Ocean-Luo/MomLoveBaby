using Microsoft.AspNetCore.Mvc;

namespace MomLoveBaby.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}