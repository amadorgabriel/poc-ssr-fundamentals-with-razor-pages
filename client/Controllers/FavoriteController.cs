using client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace client.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly ILogger<FavoriteController> _logger;

        public FavoriteController(ILogger<FavoriteController> logger)
        {
            _logger = logger;
        }

        // GET: /Favorite/
        public IActionResult Index()
        {
            ViewData["Title"] = "Favoritos";

            return View();
        }

        // GET: /Favorite/Details/
        public IActionResult Details() 
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