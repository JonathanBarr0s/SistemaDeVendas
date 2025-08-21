using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;

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

        [HttpGet]
        public IActionResult NovoCliente()
        {
            return View();
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarNovoCliente(ClienteModel cliente)
        {
			if (ModelState.IsValid)
			{
				_context.Cliente.Add(cliente);
				_context.SaveChanges();        

				return RedirectToAction("Index");
			}			
			return View("NovoCliente", cliente);
		}
    }
}
