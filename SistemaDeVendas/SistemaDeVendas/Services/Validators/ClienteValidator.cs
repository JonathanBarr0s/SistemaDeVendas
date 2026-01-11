using FluentValidation;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Services.Validators
{
	public class ClienteValidator : AbstractValidator<Cliente>
	{
		public ClienteValidator()
		{
			RuleFor(x => x.Nome)
				.NotEmpty().WithMessage("O nome é obrigatório.")
				.MaximumLength(15).WithMessage("O nome pode ter no máximo 15 caracteres.")
				.MinimumLength(2).WithMessage("O nome deve ter pelo menos 2 caracteres.")
				.Matches(@"^[A-Za-zÀ-ÿ]+$").WithMessage("O nome não pode conter números, espaços ou caracteres especiais.");

			RuleFor(x => x.Sobrenome)
				.NotEmpty().WithMessage("O sobrenome é obrigatório.")
				.MaximumLength(15).WithMessage("O sobrenome pode ter no máximo 15 caracteres.")
				.MinimumLength(2).WithMessage("O sobrenome deve ter pelo menos 2 caracteres.")
				.Matches(@"^[A-Za-zÀ-ÿ]+$").WithMessage("O sobrenome não pode conter números, espaços ou caracteres especiais.");

			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("O email é obrigatório.")
				.MaximumLength(50).WithMessage("Informe um email válido.")
				.EmailAddress().WithMessage("Informe um email válido.");

			RuleFor(x => x.CPF)
				.NotEmpty().WithMessage("O CPF é obrigatório.")
				.Length(11).WithMessage("O CPF deve conter exatamente 11 números.")
				.Matches(@"^\d+$").WithMessage("O CPF deve conter apenas números.");

			RuleFor(x => x.Telefone)
				.NotEmpty().WithMessage("O telefone é obrigatório.")
				.Length(11).WithMessage("Informe o telefone com 11 números, incluindo o DDD (ex: 11912345678).")
				.Matches(@"^\d+$").WithMessage("O telefone deve conter apenas números.");
		}
	}
}