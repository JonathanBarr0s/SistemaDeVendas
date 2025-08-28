using SistemaDeVendas.Data;
using SistemaDeVendas.Models;
using System.Text.RegularExpressions;

namespace SistemaDeVendas.Services
{
	public class ClienteService
	{
		private readonly AppDbContext _context;

		public ClienteService(AppDbContext context)
		{
			_context = context;
		}

		public List<(string campo, string mensagem)> ValidarCliente(ClienteModel cliente, bool editarCliente)
		{
			var erros = new List<(string campo, string mensagem)>();
			
			cliente.CPF_CNPJ = Regex.Replace(cliente.CPF_CNPJ ?? "", @"\D", "");

			if (editarCliente)
			{
				// busca os dados antigos do cliente
				var dadosAntigos = _context.Cliente.FirstOrDefault(c => c.Id == cliente.Id);

				if (dadosAntigos != null)
				{
					// CPF diferente do antigo e já existe no banco
					if (cliente.CPF_CNPJ != dadosAntigos.CPF_CNPJ &&
						_context.Cliente.Any(c => c.CPF_CNPJ == cliente.CPF_CNPJ))
					{
						erros.Add(("CPF_CNPJ", "Já existe um cliente com esse CPF/CNPJ."));
					}

					// Email diferente do antigo e já existe no banco
					if (cliente.Email != dadosAntigos.Email &&
						_context.Cliente.Any(c => c.Email == cliente.Email))
					{
						erros.Add(("Email", "Já existe um cliente com esse E-mail."));
					}

					return erros;
				}
			}

			// se for um novo cliente ou não encontrou dados antigos
			if (_context.Cliente.Any(c => c.CPF_CNPJ == cliente.CPF_CNPJ))
			{
				erros.Add(("CPF_CNPJ", "Já existe um cliente com esse CPF/CNPJ."));
			}

			if (_context.Cliente.Any(c => c.Email == cliente.Email))
			{
				erros.Add(("Email", "Já existe um cliente com esse E-mail."));
			}

			return erros;
		}
	}
}
