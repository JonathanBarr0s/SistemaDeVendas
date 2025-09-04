using Microsoft.AspNetCore.Mvc;

namespace SistemaDeVendas.Controllers
{
	public class ProdutoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
