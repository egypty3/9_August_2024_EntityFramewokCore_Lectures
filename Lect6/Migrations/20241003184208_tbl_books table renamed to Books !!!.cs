using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lect6.Migrations
{
    /// <inheritdoc />
    public partial class tbl_bookstablerenamedtoBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_book",
                table: "tbl_book");

            migrationBuilder.RenameTable(
                name: "tbl_book",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "tbl_book");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_book",
                table: "tbl_book",
                column: "BookId");
        }
    }
}
