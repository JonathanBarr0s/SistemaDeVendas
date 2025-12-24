using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
	[Table("SistemaDeVendas_Produto")]
	public class Produto
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? Descricao { get; set; }
		public decimal? Preco_Unitario { get; set; }
		public int? Quantidade_Estoque { get; set; }
		public string? Link_Foto { get; set; }
	}
}