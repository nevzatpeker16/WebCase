using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RottenTomatoes.Models;
using RottenTomatoes.Services;

namespace RottenTomatoes.Controllers
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

        [Route("[controller]/Detail/{id}")]
        public void getDetail([FromForm] int id)
        {
            Detail(id);
        }



        [Route("[controller]/Detail/{id}")]
        public IActionResult Detail([FromRoute] int id)
        {
            
            var service = new DataService();
            var a = service.GetMovie(id);
            return View(a);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}