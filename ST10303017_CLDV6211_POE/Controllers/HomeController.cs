using Microsoft.AspNetCore.Mvc;
using ST10303017_CLDV6211_POE.Models;
using System.Diagnostics;

namespace ST10303017_CLDV6211_POE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() 
        { 
            return View(); 
        }
        public IActionResult MyWork()
        {
            return View();
        }

        public IActionResult AboutUs() 
        { 
            return View(); 
        }
        public IActionResult ContactUs() 
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
