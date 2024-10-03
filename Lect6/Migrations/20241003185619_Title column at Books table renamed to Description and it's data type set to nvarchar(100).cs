using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lect6.Migrations
{
    /// <inheritdoc />
    public partial class TitlecolumnatBookstablerenamedtoDescriptionanditsdatatypesettonvarchar100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "Readables",
                table: "Books",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Readables",
                table: "Books",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "Readables",
                table: "Books",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "Readables",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
