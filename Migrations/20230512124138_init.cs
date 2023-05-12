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
                name: "codigo_despacho_patente",
                columns: table => new
                {
                    codigo_despacho = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codigo_despacho_patente", x => x.codigo_despacho);
                })
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
                name: "patente",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(19)", maxLength: 19, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resumo = table.Column<string>(type: "mediumtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                name: "revista",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revista", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "status_patente",
                columns: table => new
                {
                    status = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_patente", x => x.status);
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
                name: "despacho_patente",
                columns: table => new
                {
                    patente_codigo = table.Column<string>(type: "varchar(19)", maxLength: 19, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    revista_codigo = table.Column<int>(type: "int", nullable: false),
                    codigo_despacho = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    validade = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    cumprido = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_despacho_patente", x => new { x.patente_codigo, x.revista_codigo });
                    table.ForeignKey(
                        name: "FK_despacho_patente_codigo_despacho_patente_codigo_despacho",
                        column: x => x.codigo_despacho,
                        principalTable: "codigo_despacho_patente",
                        principalColumn: "codigo_despacho",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_patente_patente_patente_codigo",
                        column: x => x.patente_codigo,
                        principalTable: "patente",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_patente_revista_revista_codigo",
                        column: x => x.revista_codigo,
                        principalTable: "revista",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_codigo_despacho",
                table: "despacho_patente",
                column: "codigo_despacho");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_revista_codigo",
                table: "despacho_patente",
                column: "revista_codigo");

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
                name: "despacho_patente");

            migrationBuilder.DropTable(
                name: "servico_patente");

            migrationBuilder.DropTable(
                name: "status_patente");

            migrationBuilder.DropTable(
                name: "codigo_despacho_patente");

            migrationBuilder.DropTable(
                name: "revista");

            migrationBuilder.DropTable(
                name: "codigo_servico_patente");

            migrationBuilder.DropTable(
                name: "patente");
        }
    }
}
