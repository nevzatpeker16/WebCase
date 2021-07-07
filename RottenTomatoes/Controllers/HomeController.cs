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
        
        public IActionResult getDetail(int idMovie)
        {
            if (idMovie == 0)
            {
                TempData["IdValue"] = string.Format("{0}", idMovie);
            }

            Console.WriteLine("deneme deneme");
            return RedirectToAction("Detail", new {idMovie});
        }
        


        [Route("[controller]/Detail/{idMovie}")]
        public IActionResult Detail([FromRoute] int idMovie)
        {
            
            var service = new DataService();
            var a = service.GetMovie(idMovie);
            return View(a);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}