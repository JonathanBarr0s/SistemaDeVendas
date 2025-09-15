using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Controllers
{
	public class VendaController : Controller
	{
		private readonly AppDbContext _context;

		public VendaController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Grafico()
		{
			return View();
		}

		public IActionResult Index(DateTime? dataInicio, DateTime? dataFim)
		{
			var query = _context.Venda.AsQueryable();

			if (dataInicio.HasValue)
				query = query.Where(v => v.Data >= dataInicio.Value);

			if (dataFim.HasValue)
			{
				var fim = dataFim.Value.AddDays(1);
				query = query.Where(v => v.Data < fim);
			}

			ViewBag.venda = query.OrderBy(v => v.Data).ToList();
			ViewBag.clientes = _context.Cliente.OrderBy(c => c.Nome).ToList();
			ViewBag.vendedores = _context.Vendedor.OrderBy(v => v.Nome).ToList();
			ViewBag.DataInicio = dataInicio;
			ViewBag.DataFim = dataFim;

			var vendasPorProduto = query
				.Join(_context.Itens_Venda,
					  v => v.Id,
					  i => i.Id_Venda,
					  (v, i) => new { i.Id_Produto, i.Quantidade_Produto })
				.Join(_context.Produto,
					  iv => iv.Id_Produto,
					  p => p.Id,
					  (iv, p) => new { p.Nome, iv.Quantidade_Produto })
				.GroupBy(x => x.Nome)
				.Select(g => new
				{
					Produto = g.Key,
					Quantidade = g.Sum(x => x.Quantidade_Produto)
				})
				.ToList();

			ViewBag.Produtos = vendasPorProduto.Select(x => x.Produto).ToList();
			ViewBag.Quantidades = vendasPorProduto.Select(x => x.Quantidade).ToList();

			return View();
		}

		public IActionResult NovaVenda()
		{
			ViewBag.vendedores = _context.Vendedor.OrderBy(v => v.Nome).ToList();
			ViewBag.clientes = _context.Cliente.OrderBy(v => v.Nome).ToList();
			ViewBag.produtos = _context.Produto.OrderBy(v => v.Nome).ToList();

			return View();
		}

		[HttpPost]
		public IActionResult NovaVenda(VendaModel venda, int[] ProdutosIds, decimal[] Quantidades)
		{
			if (ModelState.IsValid)
			{
				venda.Data = DateTime.Now;

				_context.Venda.Add(venda);
				_context.SaveChanges();

				for (int i = 0; i < ProdutosIds.Length; i++)
				{
					var produtoId = ProdutosIds[i];
					var quantidade = Quantidades[i];

					var produto = _context.Produto.FirstOrDefault(p => p.Id == produtoId);
					if (produto == null)
						continue;

					var itemVenda = new ItensVendaModel
					{
						Id_Venda = venda.Id,
						Id_Produto = produtoId,
						Quantidade_Produto = quantidade,
						Preco_Produto = produto.Preco_Unitario
					};

					_context.Itens_Venda.Add(itemVenda);
				}

				_context.SaveChanges();

				return RedirectToAction("Index", "Venda");
			}

			ViewBag.Vendedores = _context.Vendedor.OrderBy(v => v.Nome).ToList();
			ViewBag.Clientes = _context.Cliente.OrderBy(c => c.Nome).ToList();
			ViewBag.Produtos = _context.Produto.OrderBy(p => p.Nome).ToList();

			return View(venda);
		}

	}
}
