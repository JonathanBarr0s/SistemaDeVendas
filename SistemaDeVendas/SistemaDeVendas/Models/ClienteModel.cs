using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
	[Table("SistemaDeVendas_Cliente")]
	public class ClienteModel : IValidatableObject
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "O campo Nome é obrigatório.")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo CPF ou CNPJ é obrigatório.")]
		[RegularExpression(@"^\d+$", ErrorMessage = "O CPF/CNPJ deve conter apenas números.")]
		public string CPF_CNPJ { get; set; }

		[Required(ErrorMessage = "O campo E-mail é obrigatório.")]
		[EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "O campo Senha é obrigatório.")]
		public string Senha { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (!string.IsNullOrEmpty(CPF_CNPJ))
			{
				var doc = CPF_CNPJ.Trim();

				if (doc.Length != 11 && doc.Length != 14)
				{
					yield return new ValidationResult(
						"O CPF deve ter 11 dígitos ou o CNPJ 14 dígitos.",
						new[] { nameof(CPF_CNPJ) }
					);
				}
			}
		}
	}
}
