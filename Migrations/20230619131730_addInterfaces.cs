using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class addInterfaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "codigo_servico_patente",
                columns: table => new
                {
                    servico = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor_sem_desconto = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    valor_com_desconto = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codigo_servico_patente", x => x.servico);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "desenho_industrial",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desenho_industrial", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "patente",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(19)", maxLength: 19, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resumo = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    situacao = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    exame = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    publicacao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    anotacao = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patente", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "programa_de_computador",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programa_de_computador", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "revista",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revista", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inventores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PatenteCodigo = table.Column<string>(type: "varchar(19)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventores_patente_PatenteCodigo",
                        column: x => x.PatenteCodigo,
                        principalTable: "patente",
                        principalColumn: "codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "servico_patente",
                columns: table => new
                {
                    id_servico_patente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    patente_codigo = table.Column<string>(type: "varchar(19)", maxLength: 19, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo_servico_patente = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    protocolo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servico_patente", x => x.id_servico_patente);
                    table.ForeignKey(
                        name: "FK_servico_patente_codigo_servico_patente_codigo_servico_patente",
                        column: x => x.codigo_servico_patente,
                        principalTable: "codigo_servico_patente",
                        principalColumn: "servico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_servico_patente_patente_patente_codigo",
                        column: x => x.patente_codigo,
                        principalTable: "patente",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DespachoPatentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codigo_despacho = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    patente_codigo = table.Column<string>(type: "varchar(19)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    revista = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DespachoPatentes", x => x.id);
                    table.ForeignKey(
                        name: "FK_DespachoPatentes_patente_patente_codigo",
                        column: x => x.patente_codigo,
                        principalTable: "patente",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DespachoPatentes_revista_revista",
                        column: x => x.revista,
                        principalTable: "revista",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DespachoPatentes_patente_codigo",
                table: "DespachoPatentes",
                column: "patente_codigo");

            migrationBuilder.CreateIndex(
                name: "IX_DespachoPatentes_revista",
                table: "DespachoPatentes",
                column: "revista");

            migrationBuilder.CreateIndex(
                name: "IX_Inventores_PatenteCodigo",
                table: "Inventores",
                column: "PatenteCodigo");

            migrationBuilder.CreateIndex(
                name: "codigo_UNIQUE",
                table: "patente",
                column: "codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_servico_patente_codigo_servico_patente",
                table: "servico_patente",
                column: "codigo_servico_patente");

            migrationBuilder.CreateIndex(
                name: "IX_servico_patente_patente_codigo",
                table: "servico_patente",
                column: "patente_codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "desenho_industrial");

            migrationBuilder.DropTable(
                name: "DespachoPatentes");

            migrationBuilder.DropTable(
                name: "Inventores");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "programa_de_computador");

            migrationBuilder.DropTable(
                name: "servico_patente");

            migrationBuilder.DropTable(
                name: "revista");

            migrationBuilder.DropTable(
                name: "codigo_servico_patente");

            migrationBuilder.DropTable(
                name: "patente");
        }
    }
}
