namespace SistemaDeVendas.Models
{
	public class VendaDetalhesViewModel
	{
		public int VendaId { get; set; }
		public DateTime Data { get; set; }

		public string Cliente { get; set; }
		public string Vendedor { get; set; }

		public decimal Total { get; set; }

		public List<ItemVendaDetalhe> Itens { get; set; } = new();

		public class ItemVendaDetalhe
		{
			public string Produto { get; set; }
			public decimal Quantidade { get; set; }
			public decimal PrecoUnitario { get; set; }
			public decimal Subtotal => Quantidade * PrecoUnitario;
		}
	}
}
