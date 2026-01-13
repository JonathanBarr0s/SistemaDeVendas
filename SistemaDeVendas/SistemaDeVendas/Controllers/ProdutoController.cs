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

		private bool ProdutoPossuiVendas(int produtoId)
		{
			return _context.Itens_Venda.Any(iv => iv.Id_Produto == produtoId);
		}

		public IActionResult Index(string? termo, bool estoqueZero = false, int pagina = 1)
		{
			const int pageSize = 10;

			var query = _context.Produto.AsQueryable();

			if (!string.IsNullOrWhiteSpace(termo))
			{
				termo = termo.Trim().ToLower();
				query = query.Where(p =>
					p.Nome != null &&
					p.Nome.ToLower().Contains(termo));
			}

			if (estoqueZero)
			{
				query = query.Where(p => p.Quantidade_Estoque == 0);
			}

			var totalRegistros = query.Count();

			ViewBag.PaginaAtual = pagina;
			ViewBag.TotalPaginas = (int)Math.Ceiling(totalRegistros / (double)pageSize);
			ViewBag.Termo = termo;
			ViewBag.EstoqueZero = estoqueZero;

			var produtos = query
				.OrderBy(p => p.Nome)
				.Skip((pagina - 1) * pageSize)
				.Take(pageSize)
				.ToList();

			return View(produtos);
		}

		public IActionResult NovoProduto()
		{
			return View();
		}

		public IActionResult EditarProduto(int id)
		{
			var produto = _context.Produto.FirstOrDefault(p => p.Id == id);

			if (produto == null)
				return NotFound();

			ViewBag.PossuiVendas = ProdutoPossuiVendas(id);

			return View(produto);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletarProduto(int id)
		{
			var produto = _context.Produto.Find(id);

			if (produto == null)
				return RedirectToAction("Index");

			if (ProdutoPossuiVendas(id))
			{
				TempData["ErroProduto"] =
					"Este produto possui vendas vinculadas e não pode ser excluído.";

				return RedirectToAction("Index");
			}

			_context.Produto.Remove(produto);
			_context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditarProduto(Produto produto)
		{
			if (!ModelState.IsValid)
				return View(produto);

			var produtoDb = _context.Produto.FirstOrDefault(p => p.Id == produto.Id);

			if (produtoDb == null)
				return NotFound();

			bool possuiVendas = ProdutoPossuiVendas(produto.Id);

			if (possuiVendas)
			{
				// 🔒 Com vendas → só estoque
				produtoDb.Quantidade_Estoque = produto.Quantidade_Estoque;
			} else
			{
				// ✅ Sem vendas → tudo
				produtoDb.Nome = produto.Nome;
				produtoDb.Descricao = produto.Descricao;
				produtoDb.Preco_Unitario = produto.Preco_Unitario;
				produtoDb.Quantidade_Estoque = produto.Quantidade_Estoque;
				produtoDb.Link_Foto = produto.Link_Foto;
			}

			_context.SaveChanges();

			return RedirectToAction("Index", "Produto");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
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
