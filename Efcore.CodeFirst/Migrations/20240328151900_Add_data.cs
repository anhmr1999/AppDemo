using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcore.CodeFirst.Migrations
{
    public partial class Add_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_table_product",
                table: "table_product");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "table_product",
                newName: "product_id");

            migrationBuilder.AlterColumn<decimal>(
                name: "product_price",
                table: "table_product",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<Guid>(
                name: "product_id",
                table: "table_product",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "product_key",
                table: "table_product",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_table_product",
                table: "table_product",
                column: "product_key");

            migrationBuilder.InsertData(
                table: "table_product",
                columns: new[] { "product_key", "product_id", "product_available", "product_name", "product_price" },
                values: new object[] { 1, null, false, "Product 1", 10m });

            migrationBuilder.InsertData(
                table: "table_product",
                columns: new[] { "product_key", "product_id", "product_available", "product_name", "product_price" },
                values: new object[] { 2, new Guid("1ac61a6b-da50-4e40-9a90-8041eb24ebb9"), false, "Pro max", 100m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_table_product",
                table: "table_product");

            migrationBuilder.DeleteData(
                table: "table_product",
                keyColumn: "product_key",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "table_product",
                keyColumn: "product_key",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "product_key",
                table: "table_product");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "table_product",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "product_price",
                table: "table_product",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "table_product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_table_product",
                table: "table_product",
                column: "Id");
        }
    }
}
