using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class navpropAndforeignkeyProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "Scifi" },
                    { 3, 3, "History" },
                    { 4, 4, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", 1, "Praesent vitae sodales libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Nancy Weaver", 1, "Curabitur aliquet quam id dui posuere blandit.", "SWD9999002", 105.0, 95.0, 85.0, 90.0, "Mystery of the Old" },
                    { 3, "George R. R. Brown", 1, "Sed porttitor lectus nibh.", "SWD9999003", 120.0, 110.0, 100.0, 105.0, "The Final Frontier" },
                    { 4, "Diana Prince", 2, "Vivamus magna justo, lacinia eget consectetur sed.", "SWD9999004", 115.0, 105.0, 95.0, 100.0, "Secrets of the Universe" },
                    { 5, "Mark Twain", 4, "Nulla porttitor accumsan tincidunt.", "SWD9999005", 98.0, 88.0, 78.0, 83.0, "Adventures of Tomorrow" },
                    { 6, "Jane Austen", 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "SWD9999006", 125.0, 115.0, 105.0, 110.0, "Legends of the Past" },
                    { 7, "H.P. Lovecraft", 2, "Vestibulum ac diam sit amet quam vehicula elementum.", "SWD9999007", 135.0, 125.0, 115.0, 120.0, "Voyage to the Stars" },
                    { 8, "Isaac Asimov", 2, "Donec sollicitudin molestie malesuada.", "SWD9999008", 145.0, 135.0, 125.0, 130.0, "Chronicles of the Unknown" },
                    { 9, "Stephen King", 3, "Vivamus suscipit tortor eget felis porttitor volutpat.", "SWD9999009", 110.0, 100.0, 90.0, 95.0, "Echoes of Eternity" },
                    { 10, "J.K. Rowling", 2, "Pellentesque in ipsum id orci porta dapibus.", "SWD9999010", 130.0, 120.0, 110.0, 115.0, "Winds of Fate" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
