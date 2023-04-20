using client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace client.Controllers
{
    public class ProofController : Controller
    {
        private readonly ILogger<ProofController> _logger;

        public ProofController(ILogger<ProofController> logger)
        {
            _logger = logger;
        }

        // GET: /Proof/
        public IActionResult Index()
        {
            ViewData["Title"] = "POC";

            return View();
        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}