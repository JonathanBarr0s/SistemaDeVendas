using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;

namespace SistemaDeVendas.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var clientes = _context.Cliente.OrderBy(cliente => cliente.Nome).ToList();
            return View(clientes);
        }

        public IActionResult NovoCliente()
        {
            return View();
        }

    }
}
