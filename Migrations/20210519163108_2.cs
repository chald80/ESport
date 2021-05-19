using Microsoft.EntityFrameworkCore.Migrations;

namespace ESport.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameProfile");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Profile_ProfileId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_ProfileId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Games");

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
    }
}
