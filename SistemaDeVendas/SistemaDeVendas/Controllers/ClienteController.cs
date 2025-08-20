using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
