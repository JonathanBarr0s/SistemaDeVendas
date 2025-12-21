using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SistemaDeVendas.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SistemaDeVendas_Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CPF_CNPJ = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaDeVendas_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SistemaDeVendas_ItensVenda",
                columns: table => new
                {
                    Id_Venda = table.Column<int>(type: "integer", nullable: false),
                    Id_Produto = table.Column<int>(type: "integer", nullable: false),
                    Quantidade_Produto = table.Column<decimal>(type: "numeric", nullable: false),
                    Preco_Produto = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaDeVendas_ItensVenda", x => new { x.Id_Venda, x.Id_Produto });
                });

            migrationBuilder.CreateTable(
                name: "SistemaDeVendas_Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Preco_Unitario = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantidade_Estoque = table.Column<decimal>(type: "numeric", nullable: false),
                    Unidade_Medida = table.Column<string>(type: "text", nullable: true),
                    Link_Foto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaDeVendas_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SistemaDeVendas_Venda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    Id_Vendedor = table.Column<int>(type: "integer", nullable: false),
                    Id_Cliente = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaDeVendas_Venda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SistemaDeVendas_Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaDeVendas_Vendedor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SistemaDeVendas_Cliente");

            migrationBuilder.DropTable(
                name: "SistemaDeVendas_ItensVenda");

            migrationBuilder.DropTable(
                name: "SistemaDeVendas_Produto");

            migrationBuilder.DropTable(
                name: "SistemaDeVendas_Venda");

            migrationBuilder.DropTable(
                name: "SistemaDeVendas_Vendedor");
        }
    }
}
