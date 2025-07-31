using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Models;

public partial class Venda
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Total { get; set; }

    public int VendedorId { get; set; }

    public int ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Vendedor Vendedor { get; set; } = null!;
}
