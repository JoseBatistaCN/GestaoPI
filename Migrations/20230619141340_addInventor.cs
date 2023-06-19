using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class addInventor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventores_patente_PatenteCodigo",
                table: "Inventores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventores",
                table: "Inventores");

            migrationBuilder.DropIndex(
                name: "IX_Inventores_PatenteCodigo",
                table: "Inventores");

            migrationBuilder.DropColumn(
                name: "PatenteCodigo",
                table: "Inventores");

            migrationBuilder.RenameTable(
                name: "Inventores",
                newName: "inventor");

            migrationBuilder.AlterColumn<string>(
                name: "cod_despacho",
                table: "despacho_patente",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cod_despacho",
                table: "codigo_despacho_patente",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_inventor",
                table: "inventor",
                column: "id");

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

            migrationBuilder.CreateIndex(
                name: "IX_InventorPatente_PatentesCodigo",
                table: "InventorPatente",
                column: "PatentesCodigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventorPatente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inventor",
                table: "inventor");

            migrationBuilder.RenameTable(
                name: "inventor",
                newName: "Inventores");

            migrationBuilder.AlterColumn<string>(
                name: "cod_despacho",
                table: "despacho_patente",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cod_despacho",
                table: "codigo_despacho_patente",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PatenteCodigo",
                table: "Inventores",
                type: "varchar(19)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventores",
                table: "Inventores",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Inventores_PatenteCodigo",
                table: "Inventores",
                column: "PatenteCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventores_patente_PatenteCodigo",
                table: "Inventores",
                column: "PatenteCodigo",
                principalTable: "patente",
                principalColumn: "codigo");
        }
    }
}
