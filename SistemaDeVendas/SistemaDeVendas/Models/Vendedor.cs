using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
	[Table("SistemaDeVendas_Vendedor")]
	public class Vendedor
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? Sobrenome { get; set; }
		public string? Email { get; set; }
		public string? Senha { get; set; }
	}
}