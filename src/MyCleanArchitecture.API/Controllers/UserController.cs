using Microsoft.AspNetCore.Mvc;

namespace MyCleanArchitecture.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
