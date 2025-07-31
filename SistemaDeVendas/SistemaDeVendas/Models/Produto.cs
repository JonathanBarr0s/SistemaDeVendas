using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Models;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public decimal? PrecoUnitario { get; set; }

    public decimal? QuantidadeEstoque { get; set; }

    public string? UnidadeMedida { get; set; }

    public string? LinkFoto { get; set; }
}
