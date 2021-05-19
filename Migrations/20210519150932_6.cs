using Microsoft.EntityFrameworkCore.Migrations;

namespace ESport.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Games_GameId",
                table: "Maps");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_Maps_MapsId",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_MapsId",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Maps_GameId",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "MapsId",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Maps");

            migrationBuilder.AlterColumn<string>(
                name: "MapsName",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GameMap",
                columns: table => new
                {
                    GamesGameId = table.Column<int>(type: "int", nullable: false),
                    MapsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameMap", x => new { x.GamesGameId, x.MapsId });
                    table.ForeignKey(
                        name: "FK_GameMap_Games_GamesGameId",
                        column: x => x.GamesGameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameMap_Maps_MapsId",
                        column: x => x.MapsId,
                        principalTable: "Maps",
                        principalColumn: "MapsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapScore",
                columns: table => new
                {
                    MapsId = table.Column<int>(type: "int", nullable: false),
                    ScoresScoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapScore", x => new { x.MapsId, x.ScoresScoreId });
                    table.ForeignKey(
                        name: "FK_MapScore_Maps_MapsId",
                        column: x => x.MapsId,
                        principalTable: "Maps",
                        principalColumn: "MapsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapScore_Score_ScoresScoreId",
                        column: x => x.ScoresScoreId,
                        principalTable: "Score",
                        principalColumn: "ScoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameMap_MapsId",
                table: "GameMap",
                column: "MapsId");

            migrationBuilder.CreateIndex(
                name: "IX_MapScore_ScoresScoreId",
                table: "MapScore",
                column: "ScoresScoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameMap");

            migrationBuilder.DropTable(
                name: "MapScore");

            migrationBuilder.AddColumn<int>(
                name: "MapsId",
                table: "Score",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MapsName",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Maps",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Score_MapsId",
                table: "Score",
                column: "MapsId");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_GameId",
                table: "Maps",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Games_GameId",
                table: "Maps",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Maps_MapsId",
                table: "Score",
                column: "MapsId",
                principalTable: "Maps",
                principalColumn: "MapsId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
