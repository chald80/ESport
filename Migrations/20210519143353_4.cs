using Microsoft.EntityFrameworkCore.Migrations;

namespace ESport.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Profile",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_GameId",
                table: "Profile",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Games_GameId",
                table: "Profile",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Games_GameId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_GameId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Profile");
        }
    }
}
