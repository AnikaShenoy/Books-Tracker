using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class updateToBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Borrower",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Lender",
                table: "Items",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Items",
                newName: "Genre");

            migrationBuilder.AddColumn<float>(
                name: "Rating",
                table: "Items",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Items",
                newName: "Lender");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Items",
                newName: "ItemName");

            migrationBuilder.AddColumn<string>(
                name: "Borrower",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
