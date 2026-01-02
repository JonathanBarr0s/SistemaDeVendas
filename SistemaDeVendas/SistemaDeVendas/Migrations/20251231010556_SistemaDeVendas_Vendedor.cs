using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class SistemaDeVendas_Vendedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.InsertData(
				table: "SistemaDeVendas_Vendedor",
				columns: new[] { "Nome", "Sobrenome", "Email", "Senha" },
				values: new object[,]
				{
					{ "Carlos", "Silva", "carlos.silva@loja.com", "123456" },
					{ "Mariana", "Souza", "mariana.souza@loja.com", "senha123" },
					{ "Rafael", "Oliveira", "rafael.oliveira@loja.com", "eduardo123" },
					{ "Juliana", "Pereira", "juliana.pereira@loja.com", "teste123" },
					{ "Lucas", "Costa", "lucas.costa@loja.com", "felipe123" },
					{ "Fernanda", "Almeida", "fernanda.almeida@loja.com", "senha456" },
					{ "Bruno", "Martins", "bruno.martins@loja.com", "andre123" },
					{ "Patricia", "Gomes", "patricia.gomes@loja.com", "luciana123" },
					{ "Daniel", "Ribeiro", "daniel.ribeiro@loja.com", "bruno123" },
					{ "Jonathan", "Barros", "jonathan@email.com", "123456" },
					{ "Eduardo", "Ferreira", "eduardo.ferreira@loja.com", "senha789" },
					{ "Camila", "Araujo", "camila.araujo@loja.com", "camila123" },
					{ "Thiago", "Nunes", "thiago.nunes@loja.com", "thiago123" },
					{ "Renata", "Teixeira", "renata.teixeira@loja.com", "renata123" },
					{ "Felipe", "Moreira", "felipe.moreira@loja.com", "felipe456" },
					{ "Vanessa", "Pinto", "vanessa.pinto@loja.com", "vanessa123" },
					{ "Gustavo", "Melo", "gustavo.melo@loja.com", "gustavo123" },
					{ "Larissa", "Farias", "larissa.farias@loja.com", "larissa123" },
					{ "Anderson", "Batista", "anderson.batista@loja.com", "anderson123" },
					{ "Paula", "Freitas", "paula.freitas@loja.com", "paula123" }
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
