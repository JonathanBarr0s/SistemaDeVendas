using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
	[Table("SistemaDeVendas_Cliente")]
	public class Cliente
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? Sobrenome { get; set; }
		public string? Email { get; set; }
		public string? CPF { get; set; }
		public string? Telefone { get; set; }
	}
}