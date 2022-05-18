using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopSite_Blazor.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Available at a lower price from other sellers that may not offer free Prime shipping.", "https://m.media-amazon.com/images/I/311AAjeId7L._AC_.jpg", 1795m, "Sony PlayStation 5" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "This product is intended for EU Region.  This CD Key will not work if your PS5 is not in EU region", "https://www.cjs-cdkeys.com/product_images/p/21371.jpg", 1200m, "FIFA 22 PSN" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "This product is intended for EU Region.  This CD Key will not work if your PS5 is not in EU region", "https://www.cjs-cdkeys.com/product_images/p/21371.jpg", 1200m, "FIFA 22 PSN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
