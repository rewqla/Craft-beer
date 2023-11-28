using Microsoft.EntityFrameworkCore.Migrations;

namespace Craft_beer_backend.Migrations
{
    public partial class Addshortdecriptionfieldtothecraftbeer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDesc",
                table: "CraftBeers",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDesc",
                table: "CraftBeers");
        }
    }
}
