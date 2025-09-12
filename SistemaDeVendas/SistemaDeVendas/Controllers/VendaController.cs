using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.Controllers
{
	public class VendaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
