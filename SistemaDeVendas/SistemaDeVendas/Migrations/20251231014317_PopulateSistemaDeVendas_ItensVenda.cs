using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSistemaDeVendas_ItensVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.InsertData(
				table: "SistemaDeVendas_ItensVenda",
				columns: new[]
				{
					"Id_Venda",
					"Id_Produto",
					"Quantidade_Produto",
					"Preco_Produto"
				},
				values: new object[,]
				{
					{ 1, 1, 1m, 3500.00m },
					{ 2, 4, 1m, 899.99m },
					{ 3, 1, 1m, 1550.00m },
					{ 4, 8, 1m, 299.99m },
					{ 5, 3, 1m, 450.00m },
					{ 6, 7, 1m, 520.00m },
					{ 7, 10, 1m, 1200.00m },
					{ 8, 6, 1m, 399.90m },
					{ 9, 9, 1m, 59.90m },
					{ 10, 1, 1m, 3500.00m },
					{ 11, 5, 1m, 780.00m  },
					{ 12, 2, 1m, 1299.90m },
					{ 13, 8, 1m, 249.99m  },
					{ 14, 4, 1m, 980.00m  },
					{ 15, 9, 1m, 159.90m  },
					{ 16, 1, 1m, 2100.00m },
					{ 17, 6, 1m, 499.90m  },
					{ 18, 7, 1m, 899.00m  },
					{ 19, 10,1m, 75.00m   },
					{ 20, 3, 1m, 3100.00m }
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
