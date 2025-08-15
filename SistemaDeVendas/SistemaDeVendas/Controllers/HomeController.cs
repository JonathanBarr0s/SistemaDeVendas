using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models;
using System.Diagnostics;

namespace SistemaDeVendas.Controllers
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
            ViewBag.MensagemBoasVindas = HttpContext.Session.GetString("Mensagem");

            ViewBag.NomeVendedor = HttpContext.Session.GetString("VendedorNome");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
