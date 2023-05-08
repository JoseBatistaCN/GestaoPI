using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class servicopatent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_servicopatente_codigoservicopatente_servico_codigo",
                table: "servicopatente");

            migrationBuilder.RenameColumn(
                name: "servico_codigo",
                table: "servicopatente",
                newName: "codigo_servico_patente");

            migrationBuilder.RenameIndex(
                name: "IX_servicopatente_servico_codigo",
                table: "servicopatente",
                newName: "IX_servicopatente_codigo_servico_patente");

            migrationBuilder.AddForeignKey(
                name: "FK_servicopatente_codigoservicopatente_codigo_servico_patente",
                table: "servicopatente",
                column: "codigo_servico_patente",
                principalTable: "codigoservicopatente",
                principalColumn: "Servico",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_servicopatente_codigoservicopatente_codigo_servico_patente",
                table: "servicopatente");

            migrationBuilder.RenameColumn(
                name: "codigo_servico_patente",
                table: "servicopatente",
                newName: "servico_codigo");

            migrationBuilder.RenameIndex(
                name: "IX_servicopatente_codigo_servico_patente",
                table: "servicopatente",
                newName: "IX_servicopatente_servico_codigo");

            migrationBuilder.AddForeignKey(
                name: "FK_servicopatente_codigoservicopatente_servico_codigo",
                table: "servicopatente",
                column: "servico_codigo",
                principalTable: "codigoservicopatente",
                principalColumn: "Servico",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
