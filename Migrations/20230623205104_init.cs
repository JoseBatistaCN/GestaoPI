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
                    cod_despacho = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prazo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codigo_despacho_patente", x => x.cod_despacho);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "codigo_servico_patente",
                columns: table => new
                {
                    cod_servico = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    servico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor_sem_desconto = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    valor_com_desconto = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codigo_servico_patente", x => x.cod_servico);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "desenho_industrial",
                columns: table => new
                {
                    cod_desenho_industrial = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desenho_industrial", x => x.cod_desenho_industrial);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nm_inventor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventor", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    cod_marca = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    marca = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.cod_marca);
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
                    situacao = table.Column<int>(type: "int", nullable: false),
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
                    cod_programa_de_computador = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Concessao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programa_de_computador", x => x.cod_programa_de_computador);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "revista",
                columns: table => new
                {
                    cod_revista = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dt_revista = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revista", x => x.cod_revista);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InventorPatente",
                columns: table => new
                {
                    InventoresId = table.Column<int>(type: "int", nullable: false),
                    PatentesCodigo = table.Column<string>(type: "varchar(19)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorPatente", x => new { x.InventoresId, x.PatentesCodigo });
                    table.ForeignKey(
                        name: "FK_InventorPatente_inventor_InventoresId",
                        column: x => x.InventoresId,
                        principalTable: "inventor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventorPatente_patente_PatentesCodigo",
                        column: x => x.PatentesCodigo,
                        principalTable: "patente",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "servico_patente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cod_patente = table.Column<string>(type: "varchar(19)", maxLength: 19, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_servico_patente = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    protocolo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dt_servico = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servico_patente", x => x.id);
                    table.ForeignKey(
                        name: "FK_servico_patente_codigo_servico_patente_cod_servico_patente",
                        column: x => x.cod_servico_patente,
                        principalTable: "codigo_servico_patente",
                        principalColumn: "cod_servico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_servico_patente_patente_cod_patente",
                        column: x => x.cod_patente,
                        principalTable: "patente",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "despacho_patente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cod_despacho = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_patente = table.Column<string>(type: "varchar(19)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_revista = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_despacho_patente", x => x.id);
                    table.ForeignKey(
                        name: "FK_despacho_patente_codigo_despacho_patente_cod_despacho",
                        column: x => x.cod_despacho,
                        principalTable: "codigo_despacho_patente",
                        principalColumn: "cod_despacho",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_patente_patente_cod_patente",
                        column: x => x.cod_patente,
                        principalTable: "patente",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_patente_revista_cod_revista",
                        column: x => x.cod_revista,
                        principalTable: "revista",
                        principalColumn: "cod_revista",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_cod_despacho",
                table: "despacho_patente",
                column: "cod_despacho");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_cod_patente",
                table: "despacho_patente",
                column: "cod_patente");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_cod_revista",
                table: "despacho_patente",
                column: "cod_revista");

            migrationBuilder.CreateIndex(
                name: "IX_InventorPatente_PatentesCodigo",
                table: "InventorPatente",
                column: "PatentesCodigo");

            migrationBuilder.CreateIndex(
                name: "codigo_UNIQUE",
                table: "patente",
                column: "codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_servico_patente_cod_patente",
                table: "servico_patente",
                column: "cod_patente");

            migrationBuilder.CreateIndex(
                name: "IX_servico_patente_cod_servico_patente",
                table: "servico_patente",
                column: "cod_servico_patente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "desenho_industrial");

            migrationBuilder.DropTable(
                name: "despacho_patente");

            migrationBuilder.DropTable(
                name: "InventorPatente");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "programa_de_computador");

            migrationBuilder.DropTable(
                name: "servico_patente");

            migrationBuilder.DropTable(
                name: "codigo_despacho_patente");

            migrationBuilder.DropTable(
                name: "revista");

            migrationBuilder.DropTable(
                name: "inventor");

            migrationBuilder.DropTable(
                name: "codigo_servico_patente");

            migrationBuilder.DropTable(
                name: "patente");
        }
    }
}
