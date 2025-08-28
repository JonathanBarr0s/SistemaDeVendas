using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Controllers
{
	public class VendedorController : Controller
	{
		private readonly AppDbContext _context;

		public VendedorController(AppDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var vendedores = _context.Vendedor.OrderBy(v => v.Nome).ToList();
			return View(vendedores);
		}

		public IActionResult NovoVendedor()
		{
			return View();
		}

		[HttpPost]
		public IActionResult RegistrarNovoVendedor(VendedorModel vendedor)
		{
			if (ModelState.IsValid)
			{
				_context.Vendedor.Add(vendedor);
				_context.SaveChanges();

				return RedirectToAction("Index");
			}

			return View("NovoVendedor", vendedor);
		}
	}
}
