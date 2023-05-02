using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class addProcessos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "codigo_despachos_patente");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "patente");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "revista");

            migrationBuilder.DropColumn(
                name: "codigo",
                table: "revista");

            migrationBuilder.DropColumn(
                name: "data",
                table: "revista");

            migrationBuilder.RenameTable(
                name: "revista",
                newName: "Revistas");

            migrationBuilder.AlterDatabase(
                oldCollation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "patente")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "Revistas")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "patente",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "patente",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "situacao",
                table: "patente",
                type: "enum('Em Processo','Concedido')",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "enum('Em Processo','Concedido')",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "resumo",
                table: "patente",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "anotacao",
                table: "patente",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "codigo",
                table: "patente",
                type: "varchar(19)",
                maxLength: 19,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(16)",
                oldFixedLength: true,
                oldMaxLength: 16)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AddColumn<ushort>(
                name: "numeroRevista",
                table: "Revistas",
                type: "smallint unsigned",
                nullable: false,
                defaultValue: (ushort)0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataPublicacao",
                table: "Revistas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_patente",
                table: "patente",
                column: "codigo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Revistas",
                table: "Revistas",
                column: "numeroRevista");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_patente",
                table: "patente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Revistas",
                table: "Revistas");

            migrationBuilder.DropColumn(
                name: "numeroRevista",
                table: "Revistas");

            migrationBuilder.DropColumn(
                name: "dataPublicacao",
                table: "Revistas");

            migrationBuilder.RenameTable(
                name: "Revistas",
                newName: "revista");

            migrationBuilder.AlterDatabase(
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "patente")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "revista")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "patente",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "patente",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "situacao",
                table: "patente",
                type: "enum('Em Processo','Concedido')",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "enum('Em Processo','Concedido')",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "resumo",
                table: "patente",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "anotacao",
                table: "patente",
                type: "text",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "codigo",
                table: "patente",
                type: "char(16)",
                fixedLength: true,
                maxLength: 16,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(19)",
                oldMaxLength: 19)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "codigo",
                table: "revista",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "data",
                table: "revista",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1));

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "patente",
                column: "codigo");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "revista",
                column: "codigo");

            migrationBuilder.CreateTable(
                name: "codigo_despachos_patente",
                columns: table => new
                {
                    codigo_id = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cumprimento = table.Column<int>(type: "int", nullable: true),
                    descricao = table.Column<string>(type: "varchar(255)", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.codigo_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "descricao_UNIQUE",
                table: "codigo_despachos_patente",
                column: "descricao",
                unique: true);
        }
    }
}
