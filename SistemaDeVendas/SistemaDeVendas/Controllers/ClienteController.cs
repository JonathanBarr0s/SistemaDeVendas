using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;
using SistemaDeVendas.Services;
using System.IO.Pipes;

namespace SistemaDeVendas.Controllers
{
	public class ClienteController : Controller
	{
		private readonly AppDbContext _context;
		private readonly ClienteService _clienteService;

		public ClienteController(AppDbContext context, ClienteService clienteService)
		{
			_context = context;
			_clienteService = clienteService;
		}

		public IActionResult Index()
		{
			var clientes = _context.Cliente.OrderBy(cliente => cliente.Nome).ToList();
			return View(clientes);
		}

		[HttpGet]
		public IActionResult NovoCliente()
		{
			return View();
		}

		[HttpGet]
		public IActionResult EditarCliente(int id)
		{
			var cliente = _context.Cliente.FirstOrDefault(c => c.Id == id);

			if (cliente == null)
			{
				return NotFound();
			}
			return View(cliente);
		}

		[HttpGet]
		public IActionResult DeletarCliente(int id)
		{
			var cliente = _context.Cliente.AsNoTracking().FirstOrDefault(cliente => cliente.Id == id);

			if (cliente == null)
			{
				return NotFound();
			}
			return View(cliente);
		}

		[HttpPost]
		public IActionResult DeletarCliente(Cliente cliente)
		{
			if (ModelState.IsValid)
			{
				_context.Cliente.Remove(cliente);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(cliente);
		}

		[HttpPost]
		public IActionResult EditarCliente(Cliente dadosAtualizados)
		{
			if (ModelState.IsValid)
			{
				var erros = _clienteService.ValidarCliente(dadosAtualizados, true);

				if (erros.Any())
				{
					foreach (var erro in erros)
					{
						ModelState.AddModelError(erro.campo, erro.mensagem);
					}

					return View("EditarCliente", dadosAtualizados);
				}

				_context.Cliente.Update(dadosAtualizados);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(dadosAtualizados);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult RegistrarNovoCliente(Cliente cliente)
		{
			if (ModelState.IsValid)
			{
				var erros = _clienteService.ValidarCliente(cliente, false);

				if (erros.Any())
				{
					foreach (var erro in erros)
					{
						ModelState.AddModelError(erro.campo, erro.mensagem);
					}

					return View("NovoCliente", cliente);
				}

				_context.Cliente.Add(cliente);
				_context.SaveChanges();

				return RedirectToAction("Index");
			}

			return View("NovoCliente", cliente);
		}
	}
}
