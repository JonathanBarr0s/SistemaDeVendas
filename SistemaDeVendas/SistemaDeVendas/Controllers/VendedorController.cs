using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;
using SistemaDeVendas.Services;

namespace SistemaDeVendas.Controllers
{
	public class VendedorController : Controller
	{
		private readonly AppDbContext _context;
		private readonly VendedorService _vendedorService;

		public VendedorController(AppDbContext context, VendedorService vendedorService)
		{
			_context = context;
			_vendedorService = vendedorService;
		}

		private bool VendedorPossuiVendas(int vendedorId)
		{
			return _context.Venda.Any(v => v.Id_Vendedor == vendedorId);
		}


		[HttpGet]
		public IActionResult Index(string termo, int pagina = 1)
		{
			const int pageSize = 10;

			var query = _context.Vendedor.AsQueryable();

			if (!string.IsNullOrEmpty(termo))
			{
				query = query.Where(v =>
					v.Nome.ToLower().Contains(termo) ||
					v.Sobrenome.ToLower().Contains(termo));
			}

			int totalRegistros = query.Count();

			var vendedores = query
				.OrderBy(v => v.Nome)
				.Skip((pagina - 1) * pageSize)
				.Take(pageSize)
				.ToList();

			ViewBag.PaginaAtual = pagina;
			ViewBag.TotalPaginas = (int)Math.Ceiling(totalRegistros / (double)pageSize);
			ViewBag.Termo = termo;

			return View(vendedores);
		}

		public IActionResult NovoVendedor()
		{
			return View();
		}

		[HttpGet]
		public IActionResult EditarVendedor(int id)
		{
			var vendedor = _context.Vendedor.FirstOrDefault(v => v.Id == id);

			return View(vendedor);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult EditarVendedor(Vendedor vendedor)
		{
			if (!ModelState.IsValid)
				return View("EditarVendedor", vendedor);

			if (VendedorPossuiVendas(vendedor.Id))
			{
				TempData["ErroVendedor"] =
					"Este vendedor possui vendas vinculadas e não pode ser editado.";

				return RedirectToAction("Index", "Vendedor");
			}

			var erro = _vendedorService.ValidarVendedor(vendedor);

			if (erro.campo != null && erro.mensagem != null)
			{
				ModelState.AddModelError(erro.campo, erro.mensagem);
				return View("EditarVendedor", vendedor);
			}

			_context.Vendedor.Update(vendedor);
			_context.SaveChanges();

			return RedirectToAction("Index", "Vendedor");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletarVendedor(int id)
		{
			var vendedor = _context.Vendedor.Find(id);

			if (vendedor == null)
				return RedirectToAction("Index");

			if (VendedorPossuiVendas(id))
			{
				TempData["ErroVendedor"] =
					"Este vendedor possui vendas vinculadas e não pode ser excluído.";

				return RedirectToAction("Index");
			}

			_context.Vendedor.Remove(vendedor);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult RegistrarNovoVendedor(Vendedor vendedor)
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
