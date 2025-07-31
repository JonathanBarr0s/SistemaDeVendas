using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? CpfCnpj { get; set; }

    public string? Email { get; set; }

    public string? Senha { get; set; }

    public virtual ICollection<Venda> Venda { get; set; } = new List<Venda>();
}
