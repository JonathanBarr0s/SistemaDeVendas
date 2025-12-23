using FluentValidation;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Services.Validators
{
	public class VendedorValidator : AbstractValidator<Vendedor>
	{
		public VendedorValidator()
		{
			RuleFor(x => x.Nome)
				.NotEmpty().WithMessage("O nome é obrigatório.")
				.MinimumLength(2).WithMessage("O nome deve ter pelo menos 2 caracteres.")
				.Matches(@"^[A-Za-zÀ-ÿ]+$").WithMessage("O nome não pode conter números, espaços ou caracteres especiais.");


			RuleFor(x => x.Sobrenome)
				.NotEmpty().WithMessage("O sobrenome é obrigatório.")
				.MinimumLength(2).WithMessage("O sobrenome deve ter pelo menos 2 caracteres.")
				.Matches(@"^[A-Za-zÀ-ÿ]+$").WithMessage("O sobrenome não pode conter números, espaços ou caracteres especiais.");

			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("O email é obrigatório.")
				.EmailAddress().WithMessage("Informe um email válido.");

			RuleFor(x => x.Senha)
				.NotEmpty().WithMessage("A senha é obrigatória.")
				.Length(5, 15).WithMessage("A senha deve ter entre 5 e 15 caracteres.")
				.Matches(@"[!@#$%^&*(),.?""{}|<>]").WithMessage("A senha deve conter pelo menos um caractere especial.");
		}
	}
}