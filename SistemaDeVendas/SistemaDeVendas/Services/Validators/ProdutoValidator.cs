using FluentValidation;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Services.Validators
{
	public class ProdutoValidator : AbstractValidator<Produto>
	{
		public ProdutoValidator()
		{
			RuleFor(x => x.Nome)
				.NotEmpty().WithMessage("O nome é obrigatório.")
				.MinimumLength(2).WithMessage("O nome deve ter pelo menos 2 caracteres.")
				.MaximumLength(50).WithMessage("O nome pode ter no máximo 50 caracteres.");

			RuleFor(x => x.Descricao)
				.MaximumLength(500).WithMessage("A descrição pode ter no máximo 500 caracteres.");

			RuleFor(x => x.Preco_Unitario)
				.NotNull().WithMessage("O preço unitário é obrigatório.")
				.GreaterThan(0).WithMessage("O preço unitário deve ser maior que zero.")
				.Must(p => decimal.Round((decimal)p, 2) == p).WithMessage("O preço unitário deve ter no máximo duas casas decimais.");

			RuleFor(x => x.Quantidade_Estoque)
				.GreaterThanOrEqualTo(0)
				.WithMessage("A quantidade em estoque não pode ser negativa.")
				.NotNull().WithMessage("A quantidade em estoque é obrigatória.")
				.LessThanOrEqualTo(1000).WithMessage("A quantidade em estoque excede o limite permitido de 1000.")
				.Must(q => q % 1 == 0).WithMessage("A quantidade em estoque deve ser um número inteiro.");

			RuleFor(x => x.Link_Foto)
				.Must(link => string.IsNullOrWhiteSpace(link) || Uri.IsWellFormedUriString(link, UriKind.Absolute))
				.WithMessage("O link da foto deve ser uma URL válida.")
				.MaximumLength(500).WithMessage("O link da foto pode ter no máximo 500 caracteres.");
		}
	}
}
