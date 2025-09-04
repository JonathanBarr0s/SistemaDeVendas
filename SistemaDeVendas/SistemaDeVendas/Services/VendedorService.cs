using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models;
using System.Text.RegularExpressions;

namespace SistemaDeVendas.Services
{
	public class VendedorService : Controller
	{
		private readonly AppDbContext _context;

		public VendedorService(AppDbContext context)
		{
			_context = context;
		}

		public (string campo, string mensagem) ValidarVendedor(VendedorModel vendedor)
		{
			var dadosAntigos = _context.Vendedor
				.AsNoTracking()
				.FirstOrDefault(v => v.Id == vendedor.Id);

			if (vendedor.Email == dadosAntigos.Email)
			{
				return (null, null);
			}

			bool emailExiste = _context.Vendedor
				.AsNoTracking()
				.Any(v => v.Email == vendedor.Email && v.Id != vendedor.Id);

			if (emailExiste)
			{
				return ("Email", "Já existe um vendedor com esse E-mail.");
			}

			return (null, null);
		}
	}
}
