using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "codigodespachospatente",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "codigoservicopatente",
                columns: table => new
                {
                    Servico = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorSemDesconto = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    ValorComDesconto = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Servico);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "patente",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "char(19)", fixedLength: true, maxLength: 19, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resumo = table.Column<string>(type: "mediumtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    exame = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    publicacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    anotacao = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "revista",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DespachoPatente_patente_codigo = table.Column<string>(type: "char(19)", fixedLength: true, maxLength: 19, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "servicopatente",
                columns: table => new
                {
                    servicoPatente_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    patente_codigo = table.Column<string>(type: "char(19)", fixedLength: true, maxLength: 19, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo_patente = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    servico_codigo = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.servicoPatente_id);
                    table.ForeignKey(
                        name: "FK_servicopatente_codigoservicopatente_servico_codigo",
                        column: x => x.servico_codigo,
                        principalTable: "codigoservicopatente",
                        principalColumn: "Servico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ServicoPatente_patente",
                        column: x => x.patente_codigo,
                        principalTable: "patente",
                        principalColumn: "codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "despachopatente",
                columns: table => new
                {
                    patente_codigo = table.Column<string>(type: "char(19)", fixedLength: true, maxLength: 19, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    revista_codigo = table.Column<int>(type: "int", nullable: false),
                    CodigoDespachosPatente_Codigo = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    validade_codigo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    cumprido = table.Column<sbyte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.patente_codigo, x.revista_codigo })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_DespachoPatente_CodigoDespachosPatente",
                        column: x => x.CodigoDespachosPatente_Codigo,
                        principalTable: "codigodespachospatente",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "fk_DespachoPatente_patente",
                        column: x => x.patente_codigo,
                        principalTable: "patente",
                        principalColumn: "codigo");
                    table.ForeignKey(
                        name: "fk_DespachoPatente_revista",
                        column: x => x.revista_codigo,
                        principalTable: "revista",
                        principalColumn: "codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "fk_DespachoPatente_CodigoDespachosPatente1_idx",
                table: "despachopatente",
                column: "CodigoDespachosPatente_Codigo");

            migrationBuilder.CreateIndex(
                name: "fk_DespachoPatente_patente1_idx",
                table: "despachopatente",
                column: "patente_codigo");

            migrationBuilder.CreateIndex(
                name: "fk_DespachoPatente_revista1_idx",
                table: "despachopatente",
                column: "revista_codigo");

            migrationBuilder.CreateIndex(
                name: "codigo_UNIQUE",
                table: "patente",
                column: "codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_ServicoPatente_patente1_idx",
                table: "servicopatente",
                column: "patente_codigo");

            migrationBuilder.CreateIndex(
                name: "IX_servicopatente_servico_codigo",
                table: "servicopatente",
                column: "servico_codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "despachopatente");

            migrationBuilder.DropTable(
                name: "servicopatente");

            migrationBuilder.DropTable(
                name: "codigodespachospatente");

            migrationBuilder.DropTable(
                name: "revista");

            migrationBuilder.DropTable(
                name: "codigoservicopatente");

            migrationBuilder.DropTable(
                name: "patente");
        }
    }
}
