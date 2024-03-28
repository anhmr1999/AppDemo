using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcore.CodeFirst.Migrations
{
    public partial class Set_Price_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "product_price",
                table: "table_product",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "table_product",
                keyColumn: "product_key",
                keyValue: 1,
                column: "product_price",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "table_product",
                keyColumn: "product_key",
                keyValue: 2,
                columns: new[] { "product_id", "product_price" },
                values: new object[] { new Guid("e6b6e7e4-6839-4323-a63f-e78bf7da44ec"), 100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "product_price",
                table: "table_product",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "table_product",
                keyColumn: "product_key",
                keyValue: 1,
                column: "product_price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "table_product",
                keyColumn: "product_key",
                keyValue: 2,
                columns: new[] { "product_id", "product_price" },
                values: new object[] { new Guid("1ac61a6b-da50-4e40-9a90-8041eb24ebb9"), 100m });
        }
    }
}
