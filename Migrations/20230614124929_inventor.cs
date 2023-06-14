using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class inventor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patente_inventor_InventorID",
                table: "patente");

            migrationBuilder.DropIndex(
                name: "IX_patente_InventorID",
                table: "patente");

            migrationBuilder.DropColumn(
                name: "InventorID",
                table: "patente");

            migrationBuilder.CreateTable(
                name: "InventorPatente",
                columns: table => new
                {
                    InventoresInventorID = table.Column<int>(type: "int", nullable: false),
                    PatentesCodigo = table.Column<string>(type: "varchar(19)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorPatente", x => new { x.InventoresInventorID, x.PatentesCodigo });
                    table.ForeignKey(
                        name: "FK_InventorPatente_inventor_InventoresInventorID",
                        column: x => x.InventoresInventorID,
                        principalTable: "inventor",
                        principalColumn: "InventorID",
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

            migrationBuilder.AddColumn<int>(
                name: "InventorID",
                table: "patente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_patente_InventorID",
                table: "patente",
                column: "InventorID");

            migrationBuilder.AddForeignKey(
                name: "FK_patente_inventor_InventorID",
                table: "patente",
                column: "InventorID",
                principalTable: "inventor",
                principalColumn: "InventorID");
        }
    }
}
