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
				},
				values: new object[,]
				{
					{ "Notebook Dell", "Notebook Dell Inspiron 15", 3500.00, 15 },
					{ "Mouse Logitech", "Mouse sem fio Logitech", 120.90, 50 },
					{ "Teclado Mecânico", "Teclado mecânico RGB", 450.00, 20 },
					{ "Monitor 24\"", "Monitor Full HD 24 polegadas", 899.99, 12 },
					{ "Cabo HDMI", "Cabo HDMI 2.0 2 metros", 35.50, 100 },
					{ "SSD 500GB", "SSD NVMe 500GB", 399.90, 25 },
					{ "Fonte 600W", "Fonte ATX 600W 80 Plus", 520.00, 10 },
					{ "Headset Gamer", "Headset com microfone", 299.99, 18 },
					{ "Pendrive 64GB", "Pendrive USB 3.0", 59.90, 40 },
					{ "Cadeira Gamer", "Cadeira ergonômica gamer", 1200.00, 5 }
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
