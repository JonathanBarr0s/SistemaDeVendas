using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Controllers
{
	public class VendaController : Controller
	{
		private readonly AppDbContext _context;

		public VendaController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult NovaVenda()
		{
			ViewBag.vendedores = _context.Vendedor.OrderBy(v => v.Nome).ToList();
			ViewBag.clientes = _context.Cliente.OrderBy(v => v.Nome).ToList();
			ViewBag.produtos = _context.Produto.OrderBy(v => v.Nome).ToList();

			return View("NovaVenda");
		}

		[HttpPost]
		public IActionResult NovaVenda(VendaModel venda)
		{
			if (ModelState.IsValid)
			{
				venda.Data = DateTime.Now;

				_context.Venda.Add(venda);
				_context.SaveChanges();				

				return RedirectToAction("Index", "Home");
			}

			return View(venda);
		}
	}
}
