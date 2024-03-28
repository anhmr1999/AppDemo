using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcore.CodeFirst.Migrations
{
    public partial class Update_Table_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "table_product");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "table_product",
                newName: "product_price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "table_product",
                newName: "product_name");

            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "table_product",
                newName: "product_available");

            migrationBuilder.AlterColumn<string>(
                name: "product_name",
                table: "table_product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_table_product",
                table: "table_product",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_table_product",
                table: "table_product");

            migrationBuilder.RenameTable(
                name: "table_product",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "product_price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "product_name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "product_available",
                table: "Products",
                newName: "IsAvailable");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
