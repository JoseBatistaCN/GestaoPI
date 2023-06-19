using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class addCodigoDespacho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cod_despacho",
                table: "despacho_patente",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "codigo_despacho_patente",
                columns: table => new
                {
                    cod_despacho = table.Column<string>(type: "varchar(255)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_despacho_patente_cod_despacho",
                table: "despacho_patente",
                column: "cod_despacho");

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_patente_codigo_despacho_patente_cod_despacho",
                table: "despacho_patente",
                column: "cod_despacho",
                principalTable: "codigo_despacho_patente",
                principalColumn: "cod_despacho",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_despacho_patente_codigo_despacho_patente_cod_despacho",
                table: "despacho_patente");

            migrationBuilder.DropTable(
                name: "codigo_despacho_patente");

            migrationBuilder.DropIndex(
                name: "IX_despacho_patente_cod_despacho",
                table: "despacho_patente");

            migrationBuilder.AlterColumn<string>(
                name: "cod_despacho",
                table: "despacho_patente",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
