using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using RottenTomatoes.Models;
using RottenTomatoes.Services;

namespace RottenTomatoes.Controllers
{

    public class HomeController : Controller
    {
        private  ILogger<HomeController> _logger;
        private IMemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
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
            
            using (var cacheEntry = _cache.CreateEntry(idMovie))
            {
                cacheEntry.Dispose();
            }

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

        
        public IActionResult getDetailByName(string movieName)
        {
            if (movieName.Length == 0)
            {
                TempData["IdValue"] = string.Format("Star Wars", movieName);
            }
            
            using (var cacheEntry = _cache.CreateEntry(movieName))
            {
                cacheEntry.Dispose();
            }

            return RedirectToAction("DetailByName", new {movieName});

        }
        [Route("[controller]/DetailByName/{moviename}")]
        public IActionResult DetailByName(string moviename)
        {
            var service = new DataService();
            var a = service.GetMoviebyName(moviename);
            return View(a);
        }
    }

    public class IndexModel : PageModel
    {
        private readonly IMemoryCache _cache;

        public IndexModel(IMemoryCache cache)
        {
            _cache = cache;
        }
    }
}