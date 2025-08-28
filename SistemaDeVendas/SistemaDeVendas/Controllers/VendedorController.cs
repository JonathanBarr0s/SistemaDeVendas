using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.Controllers
{
	public class VendedorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
