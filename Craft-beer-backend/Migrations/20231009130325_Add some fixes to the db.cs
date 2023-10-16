using Microsoft.EntityFrameworkCore.Migrations;

namespace Craft_beer_backend.Migrations
{
    public partial class Addsomefixestothedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInfos_AspNetUsers_DbUserId",
                table: "CustomerInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_CraftBeers_CraftBeerId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_DbUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "Raiting",
                table: "CraftBeers",
                newName: "Rating");

            migrationBuilder.AlterColumn<long>(
                name: "DbUserId",
                table: "Orders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CraftBeerId",
                table: "OrderItems",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DbUserId",
                table: "CustomerInfos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInfos_AspNetUsers_DbUserId",
                table: "CustomerInfos",
                column: "DbUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_CraftBeers_CraftBeerId",
                table: "OrderItems",
                column: "CraftBeerId",
                principalTable: "CraftBeers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_DbUserId",
                table: "Orders",
                column: "DbUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInfos_AspNetUsers_DbUserId",
                table: "CustomerInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_CraftBeers_CraftBeerId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_DbUserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "CraftBeers",
                newName: "Raiting");

            migrationBuilder.AlterColumn<long>(
                name: "DbUserId",
                table: "Orders",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CraftBeerId",
                table: "OrderItems",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "DbUserId",
                table: "CustomerInfos",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInfos_AspNetUsers_DbUserId",
                table: "CustomerInfos",
                column: "DbUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_CraftBeers_CraftBeerId",
                table: "OrderItems",
                column: "CraftBeerId",
                principalTable: "CraftBeers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_DbUserId",
                table: "Orders",
                column: "DbUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
