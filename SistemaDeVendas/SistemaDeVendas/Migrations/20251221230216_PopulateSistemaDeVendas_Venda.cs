using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSistemaDeVendas_Venda : Migration
    {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "SistemaDeVendas_Venda",
				columns: new[]
				{
					"Data",
					"Total",
					"Id_Vendedor",
					"Id_Cliente"
				},
				values: new object[,]
				{
					{ new DateTime(2025, 01, 10, 0, 0, 0, DateTimeKind.Utc), 3620.90m, 1, 1 },
					{ new DateTime(2025, 01, 11, 0, 0, 0, DateTimeKind.Utc), 899.99m,  2, 2 },
					{ new DateTime(2025, 01, 12, 0, 0, 0, DateTimeKind.Utc), 1550.00m, 3, 3 },
					{ new DateTime(2025, 01, 13, 0, 0, 0, DateTimeKind.Utc), 299.99m,  4, 4 },
					{ new DateTime(2025, 01, 14, 0, 0, 0, DateTimeKind.Utc), 450.00m,  5, 5 },
					{ new DateTime(2025, 01, 15, 0, 0, 0, DateTimeKind.Utc), 520.00m,  6, 6 },
					{ new DateTime(2025, 01, 16, 0, 0, 0, DateTimeKind.Utc), 1200.00m, 7, 7 },
					{ new DateTime(2025, 01, 17, 0, 0, 0, DateTimeKind.Utc), 399.90m,  8, 8 },
					{ new DateTime(2025, 01, 18, 0, 0, 0, DateTimeKind.Utc), 59.90m,   9, 9 },
					{ new DateTime(2025, 01, 19, 0, 0, 0, DateTimeKind.Utc), 3500.00m, 10, 10 }
				}
			);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
