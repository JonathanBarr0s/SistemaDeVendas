using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Controllers
{
	public class ProdutoController : Controller
	{
		private readonly AppDbContext _context;

		public ProdutoController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index(string? termo, bool estoqueZero = false)
		{
			var produtos = _context.Produto.AsQueryable();

			if (!string.IsNullOrWhiteSpace(termo))
			{
				termo = termo.Trim().ToLower();

				produtos = produtos.Where(p =>
					p.Nome != null &&
					p.Nome.ToLower().Contains(termo));
			}

			if (estoqueZero)
			{
				produtos = produtos.Where(p => p.Quantidade_Estoque == 0);
			}

			return View(produtos
				.OrderBy(p => p.Nome)
				.ToList());
		}


		public IActionResult NovoProduto()
		{
			return View();
		}

		public IActionResult EditarProduto(int id)
		{
			var produto = _context.Produto.FirstOrDefault(x => x.Id == id);

			return View(produto);
		}

		public IActionResult DeletarProduto(int id)
		{
			var produto = _context.Produto.FirstOrDefault(p => p.Id == id);

			return View(produto);
		}

		[HttpPost]
		public IActionResult DeletarProduto(Produto produto)
		{
			if (ModelState.IsValid)
			{
				_context.Produto.Remove(produto);
				_context.SaveChanges();

				return RedirectToAction("Index", "Produto");
			}

			return View(produto);
		}

		[HttpPost]
		public IActionResult EditarProduto(Produto produto)
		{
			if (ModelState.IsValid)
			{
				_context.Produto.Update(produto);
				_context.SaveChanges();

				return RedirectToAction("Index", "Produto");
			}

			return View(produto);
		}


		[HttpPost]
		public IActionResult NovoProduto(Produto produto)
		{
			if (ModelState.IsValid)
			{
				_context.Produto.Add(produto);
				_context.SaveChanges();

				return RedirectToAction("Index", "Produto");
			}

			return View(produto);
		}

	}
}
