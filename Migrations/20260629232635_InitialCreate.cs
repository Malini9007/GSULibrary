using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GSULibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    GSUBookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    NumberOfCopy = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.GSUBookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "GSUBookId", "Author", "ISBN", "Name", "NumberOfCopy", "Price" },
                values: new object[,]
                {
                    { 1, "Robert C. Martin", "978-0132350884", "Clean Code", 3, 35.99m },
                    { 2, "Gang of Four", "978-0201633610", "Design Patterns", 1, 54.99m },
                    { 3, "David Thomas", "978-0135957059", "The Pragmatic Programmer", 2, 49.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
