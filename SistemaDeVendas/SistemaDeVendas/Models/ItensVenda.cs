using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Models;

public partial class ItensVenda
{
    public int VendaId { get; set; }

    public int ProdutoId { get; set; }

    public decimal? QtdeProduto { get; set; }

    public decimal? PrecoProduto { get; set; }

    public virtual Produto Produto { get; set; } = null!;

    public virtual Venda Venda { get; set; } = null!;
}
