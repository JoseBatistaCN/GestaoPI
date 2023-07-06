using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class Anuidade2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pagamento_anuidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dt_pagamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    nm_protocolo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vl_pago = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    anotacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagamento_anuidade", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "anuidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ano = table.Column<short>(type: "smallint", nullable: false),
                    ordinario = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    extraordinario = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PagamentoAnuidadeId = table.Column<int>(type: "int", nullable: true),
                    PatenteCodigo = table.Column<string>(type: "varchar(19)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anuidade", x => x.id);
                    table.ForeignKey(
                        name: "FK_anuidade_pagamento_anuidade_PagamentoAnuidadeId",
                        column: x => x.PagamentoAnuidadeId,
                        principalTable: "pagamento_anuidade",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_anuidade_patente_PatenteCodigo",
                        column: x => x.PatenteCodigo,
                        principalTable: "patente",
                        principalColumn: "codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_anuidade_PagamentoAnuidadeId",
                table: "anuidade",
                column: "PagamentoAnuidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_anuidade_PatenteCodigo",
                table: "anuidade",
                column: "PatenteCodigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anuidade");

            migrationBuilder.DropTable(
                name: "pagamento_anuidade");
        }
    }
}
