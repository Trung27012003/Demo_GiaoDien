using Demo_GiaoDien.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_GiaoDien.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult MyAccount()
        {
            return View();
        }
        public IActionResult EditMyAccount()
        {
            return View();
        }

        public IActionResult MyProfile()
        {
            return View();
        }
        public IActionResult MyAddress()
        {
            return View();
        }
        public IActionResult MyOrder()
        {
            return View();
        }
        public IActionResult OrderHistory()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        public IActionResult ShowListProduct()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}