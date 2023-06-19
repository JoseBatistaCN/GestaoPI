using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class changeNamesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DespachoPatentes_patente_patente_codigo",
                table: "DespachoPatentes");

            migrationBuilder.DropForeignKey(
                name: "FK_DespachoPatentes_revista_revista",
                table: "DespachoPatentes");

            migrationBuilder.DropForeignKey(
                name: "FK_servico_patente_codigo_servico_patente_codigo_servico_patente",
                table: "servico_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_servico_patente_patente_patente_codigo",
                table: "servico_patente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_codigo_servico_patente",
                table: "codigo_servico_patente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DespachoPatentes",
                table: "DespachoPatentes");

            migrationBuilder.RenameTable(
                name: "DespachoPatentes",
                newName: "despacho_patente");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "servico_patente",
                newName: "dt_servico");

            migrationBuilder.RenameColumn(
                name: "patente_codigo",
                table: "servico_patente",
                newName: "cod_patente");

            migrationBuilder.RenameColumn(
                name: "codigo_servico_patente",
                table: "servico_patente",
                newName: "cod_servico_patente");

            migrationBuilder.RenameColumn(
                name: "id_servico_patente",
                table: "servico_patente",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_servico_patente_patente_codigo",
                table: "servico_patente",
                newName: "IX_servico_patente_cod_patente");

            migrationBuilder.RenameIndex(
                name: "IX_servico_patente_codigo_servico_patente",
                table: "servico_patente",
                newName: "IX_servico_patente_cod_servico_patente");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "revista",
                newName: "dt_revista");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "revista",
                newName: "cod_revista");

            migrationBuilder.RenameColumn(
                name: "Deposito",
                table: "programa_de_computador",
                newName: "deposito");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "programa_de_computador",
                newName: "cod_programa_de_computador");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "marca",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "marca",
                newName: "cod_marca");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inventores",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Inventores",
                newName: "nm_inventor");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "desenho_industrial",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Deposito",
                table: "desenho_industrial",
                newName: "deposito");

            migrationBuilder.RenameColumn(
                name: "Concessao",
                table: "desenho_industrial",
                newName: "concessao");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "desenho_industrial",
                newName: "cod_desenho_industrial");

            migrationBuilder.RenameColumn(
                name: "revista",
                table: "despacho_patente",
                newName: "cod_revista");

            migrationBuilder.RenameColumn(
                name: "patente_codigo",
                table: "despacho_patente",
                newName: "cod_patente");

            migrationBuilder.RenameColumn(
                name: "codigo_despacho",
                table: "despacho_patente",
                newName: "cod_despacho");

            migrationBuilder.RenameIndex(
                name: "IX_DespachoPatentes_revista",
                table: "despacho_patente",
                newName: "IX_despacho_patente_cod_revista");

            migrationBuilder.RenameIndex(
                name: "IX_DespachoPatentes_patente_codigo",
                table: "despacho_patente",
                newName: "IX_despacho_patente_cod_patente");

            migrationBuilder.UpdateData(
                table: "marca",
                keyColumn: "marca",
                keyValue: null,
                column: "marca",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "marca",
                table: "marca",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "servico",
                table: "codigo_servico_patente",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "cod_servico",
                table: "codigo_servico_patente",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_codigo_servico_patente",
                table: "codigo_servico_patente",
                column: "cod_servico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_despacho_patente",
                table: "despacho_patente",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_patente_patente_cod_patente",
                table: "despacho_patente",
                column: "cod_patente",
                principalTable: "patente",
                principalColumn: "codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_despacho_patente_revista_cod_revista",
                table: "despacho_patente",
                column: "cod_revista",
                principalTable: "revista",
                principalColumn: "cod_revista",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_servico_patente_codigo_servico_patente_cod_servico_patente",
                table: "servico_patente",
                column: "cod_servico_patente",
                principalTable: "codigo_servico_patente",
                principalColumn: "cod_servico",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_servico_patente_patente_cod_patente",
                table: "servico_patente",
                column: "cod_patente",
                principalTable: "patente",
                principalColumn: "codigo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_despacho_patente_patente_cod_patente",
                table: "despacho_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_despacho_patente_revista_cod_revista",
                table: "despacho_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_servico_patente_codigo_servico_patente_cod_servico_patente",
                table: "servico_patente");

            migrationBuilder.DropForeignKey(
                name: "FK_servico_patente_patente_cod_patente",
                table: "servico_patente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_codigo_servico_patente",
                table: "codigo_servico_patente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_despacho_patente",
                table: "despacho_patente");

            migrationBuilder.DropColumn(
                name: "cod_servico",
                table: "codigo_servico_patente");

            migrationBuilder.RenameTable(
                name: "despacho_patente",
                newName: "DespachoPatentes");

            migrationBuilder.RenameColumn(
                name: "dt_servico",
                table: "servico_patente",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "cod_servico_patente",
                table: "servico_patente",
                newName: "codigo_servico_patente");

            migrationBuilder.RenameColumn(
                name: "cod_patente",
                table: "servico_patente",
                newName: "patente_codigo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "servico_patente",
                newName: "id_servico_patente");

            migrationBuilder.RenameIndex(
                name: "IX_servico_patente_cod_servico_patente",
                table: "servico_patente",
                newName: "IX_servico_patente_codigo_servico_patente");

            migrationBuilder.RenameIndex(
                name: "IX_servico_patente_cod_patente",
                table: "servico_patente",
                newName: "IX_servico_patente_patente_codigo");

            migrationBuilder.RenameColumn(
                name: "dt_revista",
                table: "revista",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "cod_revista",
                table: "revista",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "deposito",
                table: "programa_de_computador",
                newName: "Deposito");

            migrationBuilder.RenameColumn(
                name: "cod_programa_de_computador",
                table: "programa_de_computador",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "marca",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "cod_marca",
                table: "marca",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Inventores",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nm_inventor",
                table: "Inventores",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "desenho_industrial",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "deposito",
                table: "desenho_industrial",
                newName: "Deposito");

            migrationBuilder.RenameColumn(
                name: "concessao",
                table: "desenho_industrial",
                newName: "Concessao");

            migrationBuilder.RenameColumn(
                name: "cod_desenho_industrial",
                table: "desenho_industrial",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "cod_revista",
                table: "DespachoPatentes",
                newName: "revista");

            migrationBuilder.RenameColumn(
                name: "cod_patente",
                table: "DespachoPatentes",
                newName: "patente_codigo");

            migrationBuilder.RenameColumn(
                name: "cod_despacho",
                table: "DespachoPatentes",
                newName: "codigo_despacho");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_patente_cod_revista",
                table: "DespachoPatentes",
                newName: "IX_DespachoPatentes_revista");

            migrationBuilder.RenameIndex(
                name: "IX_despacho_patente_cod_patente",
                table: "DespachoPatentes",
                newName: "IX_DespachoPatentes_patente_codigo");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "marca",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "servico",
                table: "codigo_servico_patente",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_codigo_servico_patente",
                table: "codigo_servico_patente",
                column: "servico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DespachoPatentes",
                table: "DespachoPatentes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_DespachoPatentes_patente_patente_codigo",
                table: "DespachoPatentes",
                column: "patente_codigo",
                principalTable: "patente",
                principalColumn: "codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DespachoPatentes_revista_revista",
                table: "DespachoPatentes",
                column: "revista",
                principalTable: "revista",
                principalColumn: "codigo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_servico_patente_codigo_servico_patente_codigo_servico_patente",
                table: "servico_patente",
                column: "codigo_servico_patente",
                principalTable: "codigo_servico_patente",
                principalColumn: "servico",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_servico_patente_patente_patente_codigo",
                table: "servico_patente",
                column: "patente_codigo",
                principalTable: "patente",
                principalColumn: "codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
