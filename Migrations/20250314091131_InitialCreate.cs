using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Url" },
                values: new object[,]
                {
                    { 1, "Category 1", "category-1" },
                    { 2, "Category 2", "category-2" },
                    { 3, "Category 3", "category-3" },
                    { 4, "Category 4", "category-4" },
                    { 5, "Category 5", "category-5" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Image", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "slider-1.jpeg", "Slide 1", "slide-1" },
                    { 2, "slider-2.jpeg", "Slide 2", "slide-2" },
                    { 3, "slider-3.jpeg", "Slide 3", "slide-3" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "IsActive", "IsHome", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, "Product 1 Description", "1.jpeg", true, true, 10.0, "Product 1" },
                    { 2, 2, "Product 2 Description", "2.jpeg", true, true, 20.0, "Product 2" },
                    { 3, 3, "Product 3 Description", "3.jpeg", true, true, 30.0, "Product 3" },
                    { 4, 4, "Product 4 Description", "4.jpeg", true, true, 40.0, "Product 4" },
                    { 5, 5, "Product 5 Description", "5.jpeg", true, true, 50.0, "Product 5" },
                    { 6, 1, "Product 6 Description", "6.jpeg", true, true, 60.0, "Product 6" },
                    { 7, 2, "Product 7 Description", "7.jpeg", true, true, 70.0, "Product 7" },
                    { 8, 3, "Product 8 Description", "8.jpeg", true, true, 80.0, "Product 8" }
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
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
