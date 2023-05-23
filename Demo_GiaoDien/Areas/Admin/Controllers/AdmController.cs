using Microsoft.AspNetCore.Mvc;

namespace Demo_GiaoDien.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
