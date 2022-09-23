using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectAp.Migrations
{
    public partial class CatagoryList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrderName",
                table: "catagories",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "DisplayOrder",
                table: "catagories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "catagories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "catagories",
                newName: "DisplayOrderName");
        }
    }
}
