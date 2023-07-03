using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class MoreClassesModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampoDeAplicacao",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProgramaDeComputadorCodigo = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampoDeAplicacao", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_CampoDeAplicacao_programa_de_computador_ProgramaDeComputador~",
                        column: x => x.ProgramaDeComputadorCodigo,
                        principalTable: "programa_de_computador",
                        principalColumn: "cod_programa_de_computador");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "codigo_despacho_marcas",
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
                    table.PrimaryKey("PK_codigo_despacho_marcas", x => x.cod_despacho);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "codigo_despacho_programa_de_computador",
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
                    table.PrimaryKey("PK_codigo_despacho_programa_de_computador", x => x.cod_despacho);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "linguagem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProgramaDeComputadorCodigo = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linguagem", x => x.id);
                    table.ForeignKey(
                        name: "FK_linguagem_programa_de_computador_ProgramaDeComputadorCodigo",
                        column: x => x.ProgramaDeComputadorCodigo,
                        principalTable: "programa_de_computador",
                        principalColumn: "cod_programa_de_computador");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_programa",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProgramaDeComputadorCodigo = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_programa", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_tipo_programa_programa_de_computador_ProgramaDeComputadorCod~",
                        column: x => x.ProgramaDeComputadorCodigo,
                        principalTable: "programa_de_computador",
                        principalColumn: "cod_programa_de_computador");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "despacho_marca",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cod_despacho = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_marca = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_revista = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_despacho_marca", x => x.id);
                    table.ForeignKey(
                        name: "FK_despacho_marca_codigo_despacho_marcas_cod_despacho",
                        column: x => x.cod_despacho,
                        principalTable: "codigo_despacho_marcas",
                        principalColumn: "cod_despacho",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_marca_marca_cod_marca",
                        column: x => x.cod_marca,
                        principalTable: "marca",
                        principalColumn: "cod_marca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_marca_revista_cod_revista",
                        column: x => x.cod_revista,
                        principalTable: "revista",
                        principalColumn: "cod_revista",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "despacho_programa_de_computador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cod_despacho = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_programa_de_computador = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_revista = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_despacho_programa_de_computador", x => x.id);
                    table.ForeignKey(
                        name: "FK_despacho_programa_de_computador_codigo_despacho_programa_de_~",
                        column: x => x.cod_despacho,
                        principalTable: "codigo_despacho_programa_de_computador",
                        principalColumn: "cod_despacho",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_programa_de_computador_programa_de_computador_cod_p~",
                        column: x => x.cod_programa_de_computador,
                        principalTable: "programa_de_computador",
                        principalColumn: "cod_programa_de_computador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_despacho_programa_de_computador_revista_cod_revista",
                        column: x => x.cod_revista,
                        principalTable: "revista",
                        principalColumn: "cod_revista",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CampoDeAplicacao_ProgramaDeComputadorCodigo",
                table: "CampoDeAplicacao",
                column: "ProgramaDeComputadorCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_marca_cod_despacho",
                table: "despacho_marca",
                column: "cod_despacho");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_marca_cod_marca",
                table: "despacho_marca",
                column: "cod_marca");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_marca_cod_revista",
                table: "despacho_marca",
                column: "cod_revista");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_programa_de_computador_cod_despacho",
                table: "despacho_programa_de_computador",
                column: "cod_despacho");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_programa_de_computador_cod_programa_de_computador",
                table: "despacho_programa_de_computador",
                column: "cod_programa_de_computador");

            migrationBuilder.CreateIndex(
                name: "IX_despacho_programa_de_computador_cod_revista",
                table: "despacho_programa_de_computador",
                column: "cod_revista");

            migrationBuilder.CreateIndex(
                name: "IX_linguagem_ProgramaDeComputadorCodigo",
                table: "linguagem",
                column: "ProgramaDeComputadorCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_tipo_programa_ProgramaDeComputadorCodigo",
                table: "tipo_programa",
                column: "ProgramaDeComputadorCodigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampoDeAplicacao");

            migrationBuilder.DropTable(
                name: "despacho_marca");

            migrationBuilder.DropTable(
                name: "despacho_programa_de_computador");

            migrationBuilder.DropTable(
                name: "linguagem");

            migrationBuilder.DropTable(
                name: "tipo_programa");

            migrationBuilder.DropTable(
                name: "codigo_despacho_marcas");

            migrationBuilder.DropTable(
                name: "codigo_despacho_programa_de_computador");
        }
    }
}
