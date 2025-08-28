using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models
{
	public class VendedorModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "O campo Nome é obrigatório.")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "O campo E-mail é obrigatório.")]
		[EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "O campo Senha é obrigatório.")]
		public string Senha { get; set; }
	}
}
