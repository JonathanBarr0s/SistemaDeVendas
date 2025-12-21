using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSistemaDeVendas_Vendedor : Migration
    {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "SistemaDeVendas_Vendedor",
				columns: new[]
				{
					"Nome",
					"Email",
					"Senha"
				},
				values: new object[,]
				{
					{ "Carlos Andrade",   "carlos.andrade@email.com",   "123456" },
					{ "Mariana Lopes",    "mariana.lopes@email.com",    "senha123" },
					{ "Eduardo Rocha",    "eduardo.rocha@email.com",    "eduardo123" },
					{ "Patrícia Nunes",   "patricia.nunes@email.com",   "teste123" },
					{ "Felipe Martins",   "felipe.martins@email.com",   "felipe123" },
					{ "Renata Souza",     "renata.souza@email.com",     "senha456" },
					{ "André Pacheco",    "andre.pacheco@email.com",    "andre123" },
					{ "Luciana Teixeira", "luciana.teixeira@email.com", "luciana123" },
					{ "Bruno Farias",     "bruno.farias@email.com",     "bruno123" },
					{ "Aline Barros",     "aline.barros@email.com",     "aline123" }
				}
			);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
