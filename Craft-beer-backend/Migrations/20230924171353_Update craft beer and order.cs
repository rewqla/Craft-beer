using Microsoft.EntityFrameworkCore.Migrations;

namespace Craft_beer_backend.Migrations
{
    public partial class Updatecraftbeerandorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CustomerInfos");

            migrationBuilder.AddColumn<double>(
                name: "Raiting",
                table: "CraftBeers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Raiting",
                table: "CraftBeers");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CustomerInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
