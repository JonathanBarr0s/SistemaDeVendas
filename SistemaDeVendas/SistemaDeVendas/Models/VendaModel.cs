namespace SistemaDeVendas.Models
{
	public class VendaModel
	{
		public int Id { get; set; }
		public DateTime Data { get; set; }

		public decimal Total { get; set; }

		public int Id_Vendedor { get; set; }

		public int Id_Cliente { get; set; }
	}
}
