using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class situacaoPatente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patente_status_patente_status",
                table: "patente");

            migrationBuilder.DropTable(
                name: "status_patente");

            migrationBuilder.DropIndex(
                name: "IX_patente_status",
                table: "patente");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "patente");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "patente",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "patente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "situacao",
                table: "patente",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "situacao_patente",
                columns: table => new
                {
                    situacao = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_situacao_patente", x => x.situacao);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_patente_situacao",
                table: "patente",
                column: "situacao");

            migrationBuilder.AddForeignKey(
                name: "FK_patente_situacao_patente_situacao",
                table: "patente",
                column: "situacao",
                principalTable: "situacao_patente",
                principalColumn: "situacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patente_situacao_patente_situacao",
                table: "patente");

            migrationBuilder.DropTable(
                name: "situacao_patente");

            migrationBuilder.DropIndex(
                name: "IX_patente_situacao",
                table: "patente");

            migrationBuilder.DropColumn(
                name: "situacao",
                table: "patente");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "patente",
                newName: "status");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "patente",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "patente",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.CreateIndex(
                name: "IX_patente_status",
                table: "patente",
                column: "status");

            migrationBuilder.AddForeignKey(
                name: "FK_patente_status_patente_status",
                table: "patente",
                column: "status",
                principalTable: "status_patente",
                principalColumn: "status");
        }
    }
}
