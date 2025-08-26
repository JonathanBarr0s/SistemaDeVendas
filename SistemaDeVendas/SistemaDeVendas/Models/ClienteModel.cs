using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models
{
	public class ClienteModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "O campo Nome é obrigatório.")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "O campo CPF ou CNPJ é obrigatório.")]
		public string CPF_CNPJ { get; set; }
		[Required(ErrorMessage = "O campo E-mail é obrigatório.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "O campo Senha é obrigatório.")]
		public string Senha { get; set; }
	}
}
