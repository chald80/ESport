using Microsoft.EntityFrameworkCore.Migrations;

namespace ESport.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Profile_ProfileId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Games_GameId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_GameId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Games_ProfileId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileName",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GameProfile",
                columns: table => new
                {
                    GamesGameId = table.Column<int>(type: "int", nullable: false),
                    ProfilesProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameProfile", x => new { x.GamesGameId, x.ProfilesProfileId });
                    table.ForeignKey(
                        name: "FK_GameProfile_Games_GamesGameId",
                        column: x => x.GamesGameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameProfile_Profile_ProfilesProfileId",
                        column: x => x.ProfilesProfileId,
                        principalTable: "Profile",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameProfile_ProfilesProfileId",
                table: "GameProfile",
                column: "ProfilesProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameProfile");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileName",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Profile",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_GameId",
                table: "Profile",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_ProfileId",
                table: "Games",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Profile_ProfileId",
                table: "Games",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Games_GameId",
                table: "Profile",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
