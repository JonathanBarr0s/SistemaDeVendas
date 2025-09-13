using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models;

namespace SistemaDeVendas.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

		public DbSet<ClienteModel> Cliente { get; set; }
		public DbSet<VendedorModel> Vendedor { get; set; }
		public DbSet<ProdutoModel> Produto { get; set; }
		public DbSet<VendaModel> Venda { get; set; }
		public DbSet<ItensVendaModel> Itens_Venda { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// chave composta
			modelBuilder.Entity<ItensVendaModel>()
				.HasKey(iv => new { iv.Id_Venda, iv.Id_Produto });

			base.OnModelCreating(modelBuilder);
		}
	}
}