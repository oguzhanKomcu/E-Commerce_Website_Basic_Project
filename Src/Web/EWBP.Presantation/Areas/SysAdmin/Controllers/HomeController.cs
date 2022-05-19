using Microsoft.AspNetCore.Mvc;

namespace EWBP.Presantation.Areas.SysAdmin.Controllers
{


    [Area("SysAdmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
