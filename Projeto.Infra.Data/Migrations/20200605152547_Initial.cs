using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    CategoriaId = table.Column<Guid>(nullable: false),
                    FornecedorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
