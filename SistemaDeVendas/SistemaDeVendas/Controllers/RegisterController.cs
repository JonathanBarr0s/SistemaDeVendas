using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Controllers
{
	public class RegisterController : Controller
	{
		private readonly AppDbContext _context;

		public RegisterController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult RegistrarNovoVendedor(VendedorModel vendedor)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", vendedor);
			}

			_context.Vendedor.Add(vendedor);
			_context.SaveChanges();

			return RedirectToAction("Index", "Login");
		}
	}
}
