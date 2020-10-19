using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Eshop.Migrations
{
    public partial class AddDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "Money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { 1, 854.0m, 5 },
                    { 2, 144.8m, 8 },
                    { 3, 442.0m, 4 },
                    { 4, 2500m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[,]
                {
                    { 1, "Asp.net آموزش", 1, "Asp.net Core 3" },
                    { 2, "Blazor آموزش", 2, "Blazor‌" },
                    { 3, "PWA آموزش", 3, "PWA" },
                    { 4, "Entity آموزش", 4, "Entity" }
                });

            migrationBuilder.InsertData(
                table: "categoryToProducts",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "categoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");
        }
    }
}
