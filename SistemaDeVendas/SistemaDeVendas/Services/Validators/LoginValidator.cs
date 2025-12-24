using FluentValidation;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Services.Validators
{
	public class LoginValidator : AbstractValidator<Login>
	{
		public LoginValidator()
		{
			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("O email é obrigatório.")
				.EmailAddress().WithMessage("Informe um email válido.");

			RuleFor(x => x.Senha)
				.NotEmpty().WithMessage("A senha é obrigatória.");
		}
	}
}
