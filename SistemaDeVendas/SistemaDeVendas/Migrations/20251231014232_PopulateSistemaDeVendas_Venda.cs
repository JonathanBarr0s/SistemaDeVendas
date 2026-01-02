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
					{ new DateTime(2025, 01, 19, 0, 0, 0, DateTimeKind.Utc), 3500.00m, 10, 10 },
					{ new DateTime(2025, 01, 20, 0, 0, 0, DateTimeKind.Utc), 780.00m,   11, 11 },
					{ new DateTime(2025, 01, 21, 0, 0, 0, DateTimeKind.Utc), 1299.90m,  12, 12 },
					{ new DateTime(2025, 01, 22, 0, 0, 0, DateTimeKind.Utc), 249.99m,   13, 13 },
					{ new DateTime(2025, 01, 23, 0, 0, 0, DateTimeKind.Utc), 980.00m,   14, 14 },
					{ new DateTime(2025, 01, 24, 0, 0, 0, DateTimeKind.Utc), 159.90m,   15, 15 },
					{ new DateTime(2025, 01, 25, 0, 0, 0, DateTimeKind.Utc), 2100.00m,  16, 16 },
					{ new DateTime(2025, 01, 26, 0, 0, 0, DateTimeKind.Utc), 499.90m,   17, 17 },
					{ new DateTime(2025, 01, 27, 0, 0, 0, DateTimeKind.Utc), 899.00m,   18, 18 },
					{ new DateTime(2025, 01, 28, 0, 0, 0, DateTimeKind.Utc), 75.00m,    19, 19 },
					{ new DateTime(2025, 01, 29, 0, 0, 0, DateTimeKind.Utc), 3100.00m,  20, 20 }
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
