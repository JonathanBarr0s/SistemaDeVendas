using FluentValidation;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Services.Validators
{
	public class LoginModelValidator : AbstractValidator<LoginModel>
	{
		public LoginModelValidator()
		{
			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("O email é obrigatório.")
				.EmailAddress().WithMessage("Informe um email válido.");

			RuleFor(x => x.Senha)
				.NotEmpty().WithMessage("A senha é obrigatória.");
		}
	}
}
