using System.ComponentModel.DataAnnotations;

namespace SistemaDeVendas.Models
{
	public class ProdutoModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage ="O campo Nome é obrigatório.")]
		public string Nome { get; set; }

		public string Descricao { get; set; }

		[Required(ErrorMessage = "O campo Preço Unitário é obrigatório.")]
		public decimal? Preco_Unitario { get; set; }

		[Required(ErrorMessage = "O campo Quantidade é obrigatório.")]
		public decimal? Quantidade_Estoque { get; set; }





		//public int Id { get; set; }

		//[Required(ErrorMessage = "O campo Nome é obrigatório.")]
		//public string Nome { get; set; }

		//public string Descricao { get; set; }

		//[Required(ErrorMessage = "O campo Preço Unitário é obrigatório.")]
		//public decimal? Preco_Unitario { get; set; }

		//[Required(ErrorMessage = "O campo Quantidade é obrigatório.")]
		//public decimal? Quantidade_Estoque { get; set; }

		//public string Unidade_Medida { get; set; }

		//public string Link_Foto { get; set; }
	}
}
