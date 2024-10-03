using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lect6.Migrations
{
    /// <inheritdoc />
    public partial class Bookstablemovedtothereadablesschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Readables");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Books",
                newSchema: "Readables");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Books",
                schema: "Readables",
                newName: "Books");
        }
    }
}
