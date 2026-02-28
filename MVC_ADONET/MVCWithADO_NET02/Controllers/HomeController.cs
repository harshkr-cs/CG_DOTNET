using Microsoft.AspNetCore.Mvc;
using MVCWithADO_NET02.Models;
using System.Diagnostics;

namespace MVCWithADO_NET02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TestError()
        {
            int x = 10;
            int y = 0;
            int z = x / y; // This will throw a DivideByZeroException
            return View();
        }

        public IActionResult Error() { 
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
