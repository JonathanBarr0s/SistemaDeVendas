using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models
{
	public class ProdutoModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="O campo Nome é obrigatório.")]
		public string Nome { get; set; }
		public string Descricao { get; set; }
		[Required(ErrorMessage ="O campo Preço Unitário é obrigatório.")]
		public double PrecoUnitario { get; set; }
		[Required(ErrorMessage ="O campo Quantidade é obrigatório.")]
		public double QuantidadeEstoque { get; set; }
		public string UnidadeMedida { get; set; }
		public string LinkFoto { get; set; }
	}
}
