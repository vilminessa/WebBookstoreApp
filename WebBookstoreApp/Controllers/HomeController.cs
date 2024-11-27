using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebBookstoreApp.Models;

namespace WebBookstoreApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About_us()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Detect()
        {
            return View();
        }
        public IActionResult Fantasy()
        {
            return View();
        }
        public IActionResult Adventure()
        {
            return View();
        }
        public IActionResult Romance()
        {
            return View();
        }
        public IActionResult Horror()
        {
            return View();
        }
        public IActionResult ScienceFiction()
        {
            return View();
        }
        public IActionResult Classics()
        {
            return View();
        }
        public IActionResult NonFiction()
        {
            return View();
        }
        public IActionResult Children()
        {
            return View();
        }
        public IActionResult Biography()
        {
            return View();
        }
        public IActionResult Educational()
        {
            return View();
        }
        public IActionResult Poetry()
        {
            return View();
        }
        public IActionResult Historical()
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
