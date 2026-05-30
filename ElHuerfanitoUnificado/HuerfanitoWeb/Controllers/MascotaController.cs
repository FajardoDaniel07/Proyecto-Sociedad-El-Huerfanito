using Microsoft.AspNetCore.Mvc;

namespace HuerfanitoWeb.Controllers
{
    public class MascotaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
