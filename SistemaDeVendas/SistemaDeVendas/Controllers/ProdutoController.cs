using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;

namespace SistemaDeVendas.Controllers
{
	public class ProdutoController : Controller
	{
		private readonly AppDbContext _context;

		public ProdutoController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var produtos = _context.Produto.ToList();

			return View(produtos);
		}
	}
}
