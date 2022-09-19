using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectAp.Migrations
{
    public partial class AddCatagory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "catagories",
                newName: "DisplayOrderName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrderName",
                table: "catagories",
                newName: "DisplayOrder");
        }
    }
}
