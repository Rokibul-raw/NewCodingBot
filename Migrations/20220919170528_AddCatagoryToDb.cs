using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectAp.Migrations
{
    public partial class AddCatagoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "catagories",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "Displayrder",
                table: "catagories",
                newName: "DisplayOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "catagories",
                newName: "dateTime");

            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "catagories",
                newName: "Displayrder");
        }
    }
}
