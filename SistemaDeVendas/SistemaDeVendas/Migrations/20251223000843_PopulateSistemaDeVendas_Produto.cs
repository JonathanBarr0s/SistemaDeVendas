using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSistemaDeVendas_Produto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.InsertData(
				table: "SistemaDeVendas_Produto",
				columns: new[]
				{
					"Nome",
					"Descricao",
					"Preco_Unitario",
					"Quantidade_Estoque",
					"Unidade_Medida"
				},
				values: new object[,]
				{
					{ "Notebook Dell", "Notebook Dell Inspiron 15", 3500.00m, 15m, "UN" },
					{ "Mouse Logitech", "Mouse sem fio Logitech", 120.90m, 50m, "UN" },
					{ "Teclado Mecânico", "Teclado mecânico RGB", 450.00m, 20m, "UN" },
					{ "Monitor 24\"", "Monitor Full HD 24 polegadas", 899.99m, 12m, "UN" },
					{ "Cabo HDMI", "Cabo HDMI 2.0 2 metros", 35.50m, 100m, "UN" },
					{ "SSD 500GB", "SSD NVMe 500GB", 399.90m, 25m, "UN" },
					{ "Fonte 600W", "Fonte ATX 600W 80 Plus", 520.00m, 10m, "UN" },
					{ "Headset Gamer", "Headset com microfone", 299.99m, 18m, "UN" },
					{ "Pendrive 64GB", "Pendrive USB 3.0", 59.90m, 40m, "UN" },
					{ "Cadeira Gamer", "Cadeira ergonômica gamer", 1200.00m, 5m, "UN" }
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
