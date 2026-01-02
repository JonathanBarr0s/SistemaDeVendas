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
						{ "Patricia", "Gomes", "patricia.gomes@email.com", "01234567890", "11998901234" },
						{ "Eduardo", "Ramos", "eduardo.ramos@email.com", "11223344556", "11999112233" },
						{ "Camila", "Araujo", "camila.araujo@email.com", "22334455667", "11999223344" },
						{ "Thiago", "Barbosa", "thiago.barbosa@email.com", "33445566778", "11999334455" },
						{ "Renata", "Mendes", "renata.mendes@email.com", "44556677889", "11999445566" },
						{ "Diego", "Teixeira", "diego.teixeira@email.com", "55667788990", "11999556677" },
						{ "Vanessa", "Freitas", "vanessa.freitas@email.com", "66778899001", "11999667788" },
						{ "André", "Nascimento", "andre.nascimento@email.com", "77889900112", "11999778899" },
						{ "Bianca", "Farias", "bianca.farias@email.com", "88990011223", "11999889900" },
						{ "Gustavo", "Pacheco", "gustavo.pacheco@email.com", "99001122334", "11999990011" },
						{ "Larissa", "Moreira", "larissa.moreira@email.com", "10111213145", "11990001122" }
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
