using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeVendas.Models
{
	[Table("SistemaDeVendas_ItensVenda")]
	public class ItensVendaModel
	{
		public int Id_Venda { get; set; }
		public int Id_Produto { get; set; }
		public decimal Quantidade_Produto { get; set; }
		public decimal Preco_Produto { get; set; }
	}
}
