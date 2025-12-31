using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSistemaDeVendas_Cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.InsertData(
				table: "SistemaDeVendas_Cliente",
				columns: new[] { "Nome", "Sobrenome", "Email", "CPF", "Telefone" },
				values: new object[,]
				{
						{ "João", "Silva", "joao.silva@email.com", "12345678901", "11978457845" },
						{ "Maria", "Oliveira", "maria.oliveira@email.com", "23456789012", "11987654321" },
						{ "Carlos", "Santos", "carlos.santos@email.com", "34567890123", "11991234567" },
						{ "Ana", "Pereira", "ana.pereira@email.com", "45678901234", "11992345678" },
						{ "Lucas", "Costa", "lucas.costa@email.com", "56789012345", "11993456789" },
						{ "Fernanda", "Rodrigues", "fernanda.rodrigues@email.com", "67890123456", "11994567890" },
						{ "Rafael", "Almeida", "rafael.almeida@email.com", "78901234567", "11995678901" },
						{ "Juliana", "Lima", "juliana.lima@email.com", "89012345678", "11996789012" },
						{ "Bruno", "Martins", "bruno.martins@email.com", "90123456789", "11997890123" },
						{ "Patricia", "Gomes", "patricia.gomes@email.com", "01234567890", "11998901234" }
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
