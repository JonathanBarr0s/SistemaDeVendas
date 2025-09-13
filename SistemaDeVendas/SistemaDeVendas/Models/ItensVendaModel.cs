namespace SistemaDeVendas.Models
{
	public class ItensVendaModel
	{
		public int Id_Venda { get; set; }
		public int Id_Produto { get; set; }
		public decimal Quantidade_Produto { get; set; }
		public decimal Preco_Produto { get; set; }
	}
}
