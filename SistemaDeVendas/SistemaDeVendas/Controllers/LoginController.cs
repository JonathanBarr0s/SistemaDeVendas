using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Controllers
{
	public class LoginController : Controller
	{
		private readonly AppDbContext _context;

		public LoginController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Clear();

			return RedirectToAction("Index", "Login");
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(Login login)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", login);
			}

			var vendedor = _context.Vendedor
				.FirstOrDefault(v => v.Email == login.Email && v.Senha == login.Senha);

			if (vendedor != null)
			{
				HttpContext.Session.SetString("VendedorNome", vendedor.Nome);

				HttpContext.Session.SetInt32("VendedorId", vendedor.Id);

				HttpContext.Session.SetString("Mensagem", $"Seja bem-vindo, {vendedor.Nome}!");

                return RedirectToAction("Index", "Home");
			} else
			{
				ModelState.AddModelError("Senha", "Email ou senha inválidos");
				return View("Index", login);
			}
		}
	}
}
