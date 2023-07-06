using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class Anuidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_despacho_marca_revista_cod_revista",
                table: "despacho_marca");

            migrationBuilder.DropForeignKey(
                name: "FK_despacho_patente_codigo_despacho_patente_cod_despacho",
                table: "despacho_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_despacho_patente_revista_cod_revista",
                table: "despacho_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_despacho_programa_de_computador_revista_cod_revista",
                table: "despacho_programa_de_computador");

            migrationBuilder.RenameColumn(
                name: "dt_revista",
                table: "revista",
                newName: "dt_publicacao");

            migrationBuilder.RenameColumn(
                name: "cod_revista",
                table: "revista",
                newName: "nm_revista");

            migrationBuilder.RenameColumn(
                name: "cod_revista",
                table: "despacho_programa_de_computador",
                newName: "nm_revista");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_programa_de_computador_cod_revista",
                table: "despacho_programa_de_computador",
                newName: "IX_despacho_programa_de_computador_nm_revista");

            migrationBuilder.RenameColumn(
                name: "cod_revista",
                table: "despacho_patente",
                newName: "nm_revista");

            migrationBuilder.RenameColumn(
                name: "cod_despacho",
                table: "despacho_patente",
                newName: "cod");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_patente_cod_revista",
                table: "despacho_patente",
                newName: "IX_despacho_patente_nm_revista");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_patente_cod_despacho",
                table: "despacho_patente",
                newName: "IX_despacho_patente_cod");

            migrationBuilder.RenameColumn(
                name: "cod_revista",
                table: "despacho_marca",
                newName: "nm_revista");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_marca_cod_revista",
                table: "despacho_marca",
                newName: "IX_despacho_marca_nm_revista");

            migrationBuilder.RenameColumn(
                name: "cod_despacho",
                table: "codigo_despacho_programa_de_computador",
                newName: "cod");

            migrationBuilder.RenameColumn(
                name: "cod_despacho",
                table: "codigo_despacho_patente",
                newName: "cod");

            migrationBuilder.RenameColumn(
                name: "cod_despacho",
                table: "codigo_despacho_marcas",
                newName: "cod");

            migrationBuilder.AddColumn<string>(
                name: "titular",
                table: "programa_de_computador",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "codigo_despacho_programa_de_computador",
                keyColumn: "titulo",
                keyValue: null,
                column: "titulo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "codigo_despacho_programa_de_computador",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "codigo_despacho_patente",
                keyColumn: "titulo",
                keyValue: null,
                column: "titulo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "codigo_despacho_patente",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "codigo_despacho_marcas",
                keyColumn: "titulo",
                keyValue: null,
                column: "titulo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "codigo_despacho_marcas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_marca_revista_nm_revista",
                table: "despacho_marca",
                column: "nm_revista",
                principalTable: "revista",
                principalColumn: "nm_revista",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_patente_codigo_despacho_patente_cod",
                table: "despacho_patente",
                column: "cod",
                principalTable: "codigo_despacho_patente",
                principalColumn: "cod",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_patente_revista_nm_revista",
                table: "despacho_patente",
                column: "nm_revista",
                principalTable: "revista",
                principalColumn: "nm_revista",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_programa_de_computador_revista_nm_revista",
                table: "despacho_programa_de_computador",
                column: "nm_revista",
                principalTable: "revista",
                principalColumn: "nm_revista",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_despacho_marca_revista_nm_revista",
                table: "despacho_marca");

            migrationBuilder.DropForeignKey(
                name: "FK_despacho_patente_codigo_despacho_patente_cod",
                table: "despacho_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_despacho_patente_revista_nm_revista",
                table: "despacho_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_despacho_programa_de_computador_revista_nm_revista",
                table: "despacho_programa_de_computador");

            migrationBuilder.DropColumn(
                name: "titular",
                table: "programa_de_computador");

            migrationBuilder.RenameColumn(
                name: "dt_publicacao",
                table: "revista",
                newName: "dt_revista");

            migrationBuilder.RenameColumn(
                name: "nm_revista",
                table: "revista",
                newName: "cod_revista");

            migrationBuilder.RenameColumn(
                name: "nm_revista",
                table: "despacho_programa_de_computador",
                newName: "cod_revista");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_programa_de_computador_nm_revista",
                table: "despacho_programa_de_computador",
                newName: "IX_despacho_programa_de_computador_cod_revista");

            migrationBuilder.RenameColumn(
                name: "nm_revista",
                table: "despacho_patente",
                newName: "cod_revista");

            migrationBuilder.RenameColumn(
                name: "cod",
                table: "despacho_patente",
                newName: "cod_despacho");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_patente_nm_revista",
                table: "despacho_patente",
                newName: "IX_despacho_patente_cod_revista");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_patente_cod",
                table: "despacho_patente",
                newName: "IX_despacho_patente_cod_despacho");

            migrationBuilder.RenameColumn(
                name: "nm_revista",
                table: "despacho_marca",
                newName: "cod_revista");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_marca_nm_revista",
                table: "despacho_marca",
                newName: "IX_despacho_marca_cod_revista");

            migrationBuilder.RenameColumn(
                name: "cod",
                table: "codigo_despacho_programa_de_computador",
                newName: "cod_despacho");

            migrationBuilder.RenameColumn(
                name: "cod",
                table: "codigo_despacho_patente",
                newName: "cod_despacho");

            migrationBuilder.RenameColumn(
                name: "cod",
                table: "codigo_despacho_marcas",
                newName: "cod_despacho");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "codigo_despacho_programa_de_computador",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "codigo_despacho_patente",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "codigo_despacho_marcas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_marca_revista_cod_revista",
                table: "despacho_marca",
                column: "cod_revista",
                principalTable: "revista",
                principalColumn: "cod_revista",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_patente_codigo_despacho_patente_cod_despacho",
                table: "despacho_patente",
                column: "cod_despacho",
                principalTable: "codigo_despacho_patente",
                principalColumn: "cod_despacho",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_patente_revista_cod_revista",
                table: "despacho_patente",
                column: "cod_revista",
                principalTable: "revista",
                principalColumn: "cod_revista",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_programa_de_computador_revista_cod_revista",
                table: "despacho_programa_de_computador",
                column: "cod_revista",
                principalTable: "revista",
                principalColumn: "cod_revista",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
