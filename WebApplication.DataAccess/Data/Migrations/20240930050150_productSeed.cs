using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Data.Migrations
{
    /// <inheritdoc />
    public partial class productSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Praesent vitae sodales libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Nancy Weaver", "Curabitur aliquet quam id dui posuere blandit.", "SWD9999002", 105.0, 95.0, 85.0, 90.0, "Mystery of the Old" },
                    { 3, "George R. R. Brown", "Sed porttitor lectus nibh.", "SWD9999003", 120.0, 110.0, 100.0, 105.0, "The Final Frontier" },
                    { 4, "Diana Prince", "Vivamus magna justo, lacinia eget consectetur sed.", "SWD9999004", 115.0, 105.0, 95.0, 100.0, "Secrets of the Universe" },
                    { 5, "Mark Twain", "Nulla porttitor accumsan tincidunt.", "SWD9999005", 98.0, 88.0, 78.0, 83.0, "Adventures of Tomorrow" },
                    { 6, "Jane Austen", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "SWD9999006", 125.0, 115.0, 105.0, 110.0, "Legends of the Past" },
                    { 7, "H.P. Lovecraft", "Vestibulum ac diam sit amet quam vehicula elementum.", "SWD9999007", 135.0, 125.0, 115.0, 120.0, "Voyage to the Stars" },
                    { 8, "Isaac Asimov", "Donec sollicitudin molestie malesuada.", "SWD9999008", 145.0, 135.0, 125.0, 130.0, "Chronicles of the Unknown" },
                    { 9, "Stephen King", "Vivamus suscipit tortor eget felis porttitor volutpat.", "SWD9999009", 110.0, 100.0, 90.0, 95.0, "Echoes of Eternity" },
                    { 10, "J.K. Rowling", "Pellentesque in ipsum id orci porta dapibus.", "SWD9999010", 130.0, 120.0, 110.0, 115.0, "Winds of Fate" }
                });
        }

        /// <inheritdoc />
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
