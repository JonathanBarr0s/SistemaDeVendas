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
				columns: new[] { "Nome", "CPF_CNPJ", "Email", "Senha" },
				values: new object[,]
				{
					{ "João Silva",     "12345678901", "joao.silva@email.com",     "123456" },
					{ "Maria Santos",  "23456789012", "maria.santos@email.com",  "senha123" },
					{ "Pedro Oliveira","34567890123", "pedro.oliveira@email.com","abc123" },
					{ "Ana Costa",     "45678901234", "ana.costa@email.com",     "teste123" },
					{ "Lucas Pereira", "56789012345", "lucas.pereira@email.com", "lucas123" },
					{ "Fernanda Lima", "67890123456", "fernanda.lima@email.com", "senha456" },
					{ "Rafael Gomes",  "78901234567", "rafael.gomes@email.com",  "rafa123" },
					{ "Camila Rocha",  "89012345678", "camila.rocha@email.com",  "camila123" },
					{ "Bruno Alves",   "90123456789", "bruno.alves@email.com",   "bruno123" },
					{ "Juliana Martins","01234567890","juliana.martins@email.com","juliana123" }
				}
			);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
