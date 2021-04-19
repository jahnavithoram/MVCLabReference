using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MVCBasics.Controllers
{
   // [Route("[controller]/[action]")]
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
       [ActionName("content")]
        public ContentResult GetContent()
        {
            return Content("This is sample grom cresult");
        }
        public RedirectToRouteResult RedirectRoute()
        {
            return  new RedirectToRouteResult(new { Controller = "About" , action ="Index"});
        }
        public IActionResult Privacy()
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
