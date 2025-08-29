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

		public IActionResult DeletarVendedor(int id)
		{
			if (id != null)
			{
				var vendedor = _context.Vendedor.FirstOrDefault(v => v.Id == id);

				return View(vendedor);
			}

			return View();
		}

		[HttpPost]

		public IActionResult DeletarVendedor(VendedorModel vendedor)
		{
			if (ModelState.IsValid)
			{
				_context.Vendedor.Remove(vendedor);
				_context.SaveChanges();

				return RedirectToAction("Index");
			}

			return View("DeletarVendedor", vendedor);
		}



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
