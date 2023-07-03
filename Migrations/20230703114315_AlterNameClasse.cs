using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class AlterNameClasse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampoDeAplicacao_programa_de_computador_ProgramaDeComputador~",
                table: "CampoDeAplicacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampoDeAplicacao",
                table: "CampoDeAplicacao");

            migrationBuilder.RenameTable(
                name: "CampoDeAplicacao",
                newName: "campo_de_aplicacao");

            migrationBuilder.RenameIndex(
                name: "IX_CampoDeAplicacao_ProgramaDeComputadorCodigo",
                table: "campo_de_aplicacao",
                newName: "IX_campo_de_aplicacao_ProgramaDeComputadorCodigo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_campo_de_aplicacao",
                table: "campo_de_aplicacao",
                column: "codigo");

            migrationBuilder.AddForeignKey(
                name: "FK_campo_de_aplicacao_programa_de_computador_ProgramaDeComputad~",
                table: "campo_de_aplicacao",
                column: "ProgramaDeComputadorCodigo",
                principalTable: "programa_de_computador",
                principalColumn: "cod_programa_de_computador");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_campo_de_aplicacao_programa_de_computador_ProgramaDeComputad~",
                table: "campo_de_aplicacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_campo_de_aplicacao",
                table: "campo_de_aplicacao");

            migrationBuilder.RenameTable(
                name: "campo_de_aplicacao",
                newName: "CampoDeAplicacao");

            migrationBuilder.RenameIndex(
                name: "IX_campo_de_aplicacao_ProgramaDeComputadorCodigo",
                table: "CampoDeAplicacao",
                newName: "IX_CampoDeAplicacao_ProgramaDeComputadorCodigo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampoDeAplicacao",
                table: "CampoDeAplicacao",
                column: "codigo");

            migrationBuilder.AddForeignKey(
                name: "FK_CampoDeAplicacao_programa_de_computador_ProgramaDeComputador~",
                table: "CampoDeAplicacao",
                column: "ProgramaDeComputadorCodigo",
                principalTable: "programa_de_computador",
                principalColumn: "cod_programa_de_computador");
        }
    }
}
