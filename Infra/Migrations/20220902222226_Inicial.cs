using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pecuarista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pecuarista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdPecuarista = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Pecuarista",
                        column: x => x.IdPecuarista,
                        principalTable: "Pecuarista",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompraGado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPecuarista = table.Column<int>(type: "int", nullable: false),
                    DataEntrega = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraGado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompraGado_Pecuarista",
                        column: x => x.IdPecuarista,
                        principalTable: "Pecuarista",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompraGadoItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCompraGado = table.Column<int>(type: "int", nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraGadoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompraGadoItem_Animal",
                        column: x => x.IdAnimal,
                        principalTable: "Animal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompraGadoItem_CompraGado",
                        column: x => x.IdCompraGado,
                        principalTable: "CompraGado",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_IdPecuarista",
                table: "Animal",
                column: "IdPecuarista");

            migrationBuilder.CreateIndex(
                name: "IX_CompraGado_IdPecuarista",
                table: "CompraGado",
                column: "IdPecuarista");

            migrationBuilder.CreateIndex(
                name: "IX_CompraGadoItem_IdAnimal",
                table: "CompraGadoItem",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_CompraGadoItem_IdCompraGado",
                table: "CompraGadoItem",
                column: "IdCompraGado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompraGadoItem");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "CompraGado");

            migrationBuilder.DropTable(
                name: "Pecuarista");
        }
    }
}
