using Microsoft.EntityFrameworkCore.Migrations;

namespace Cms.Migrations
{
    public partial class updategood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Goods",
                newName: "HasToll");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasToll",
                table: "Goods",
                newName: "MyProperty");
        }
    }
}
