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
                name: "inventor",
                columns: table => new
                {
                    InventorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventor", x => x.InventorID);
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
                name: "desenho_industrial",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InventorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desenho_industrial", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_desenho_industrial_inventor_InventorID",
                        column: x => x.InventorID,
                        principalTable: "inventor",
                        principalColumn: "InventorID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    marca = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apresentacao = table.Column<int>(type: "int", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false),
                    InventorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_marca_inventor_InventorID",
                        column: x => x.InventorID,
                        principalTable: "inventor",
                        principalColumn: "InventorID");
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InventorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patente", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_patente_inventor_InventorID",
                        column: x => x.InventorID,
                        principalTable: "inventor",
                        principalColumn: "InventorID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "programa_de_computador",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_deposito = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    data_registro = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    InventorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programa_de_computador", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_programa_de_computador_inventor_InventorID",
                        column: x => x.InventorID,
                        principalTable: "inventor",
                        principalColumn: "InventorID");
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

            migrationBuilder.CreateIndex(
                name: "IX_desenho_industrial_InventorID",
                table: "desenho_industrial",
                column: "InventorID");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_codigo_despacho",
                table: "despacho_patente",
                column: "codigo_despacho");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_revista_codigo",
                table: "despacho_patente",
                column: "revista_codigo");

            migrationBuilder.CreateIndex(
                name: "IX_marca_InventorID",
                table: "marca",
                column: "InventorID");

            migrationBuilder.CreateIndex(
                name: "codigo_UNIQUE",
                table: "patente",
                column: "codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_patente_InventorID",
                table: "patente",
                column: "InventorID");

            migrationBuilder.CreateIndex(
                name: "IX_programa_de_computador_InventorID",
                table: "programa_de_computador",
                column: "InventorID");

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
                name: "despacho_patente");

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
                name: "codigo_servico_patente");

            migrationBuilder.DropTable(
                name: "patente");

            migrationBuilder.DropTable(
                name: "inventor");
        }
    }
}
