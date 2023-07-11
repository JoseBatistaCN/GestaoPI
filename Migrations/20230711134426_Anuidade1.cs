using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoPI.Migrations
{
    /// <inheritdoc />
    public partial class Anuidade1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anuidade_pagamento_anuidade_PagamentoAnuidadeId",
                table: "anuidade");

            migrationBuilder.DropForeignKey(
                name: "FK_anuidade_patente_PatenteCodigo",
                table: "anuidade");

            migrationBuilder.AlterColumn<decimal>(
                name: "vl_pago",
                table: "pagamento_anuidade",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dt_pagamento",
                table: "pagamento_anuidade",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<bool>(
                name: "pago",
                table: "pagamento_anuidade",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<byte>(
                name: "ano",
                table: "anuidade",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.UpdateData(
                table: "anuidade",
                keyColumn: "PatenteCodigo",
                keyValue: null,
                column: "PatenteCodigo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PatenteCodigo",
                table: "anuidade",
                type: "varchar(19)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(19)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "PagamentoAnuidadeId",
                table: "anuidade",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_anuidade_pagamento_anuidade_PagamentoAnuidadeId",
                table: "anuidade",
                column: "PagamentoAnuidadeId",
                principalTable: "pagamento_anuidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_anuidade_patente_PatenteCodigo",
                table: "anuidade",
                column: "PatenteCodigo",
                principalTable: "patente",
                principalColumn: "codigo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_anuidade_pagamento_anuidade_PagamentoAnuidadeId",
                table: "anuidade");

            migrationBuilder.DropForeignKey(
                name: "FK_anuidade_patente_PatenteCodigo",
                table: "anuidade");

            migrationBuilder.DropColumn(
                name: "pago",
                table: "pagamento_anuidade");

            migrationBuilder.AlterColumn<decimal>(
                name: "vl_pago",
                table: "pagamento_anuidade",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "dt_pagamento",
                table: "pagamento_anuidade",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "ano",
                table: "anuidade",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");

            migrationBuilder.AlterColumn<string>(
                name: "PatenteCodigo",
                table: "anuidade",
                type: "varchar(19)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(19)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "PagamentoAnuidadeId",
                table: "anuidade",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_anuidade_pagamento_anuidade_PagamentoAnuidadeId",
                table: "anuidade",
                column: "PagamentoAnuidadeId",
                principalTable: "pagamento_anuidade",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_anuidade_patente_PatenteCodigo",
                table: "anuidade",
                column: "PatenteCodigo",
                principalTable: "patente",
                principalColumn: "codigo");
        }
    }
}
