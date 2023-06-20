using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class inventores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
