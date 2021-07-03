using Microsoft.EntityFrameworkCore.Migrations;

namespace fanfiction.Migrations
{
    public partial class Fanfiction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fanfics_Genres_FanficGenreGenreId",
                table: "Fanfics");

            migrationBuilder.RenameColumn(
                name: "FanficGenreGenreId",
                table: "Fanfics",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Fanfics_FanficGenreGenreId",
                table: "Fanfics",
                newName: "IX_Fanfics_GenreId");

            migrationBuilder.AddColumn<int>(
                name: "FandomId",
                table: "Fanfics",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fandom",
                columns: table => new
                {
                    FandomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fandom", x => x.FandomId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fanfics_FandomId",
                table: "Fanfics",
                column: "FandomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfics_Fandom_FandomId",
                table: "Fanfics",
                column: "FandomId",
                principalTable: "Fandom",
                principalColumn: "FandomId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfics_Genres_GenreId",
                table: "Fanfics",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fanfics_Fandom_FandomId",
                table: "Fanfics");

            migrationBuilder.DropForeignKey(
                name: "FK_Fanfics_Genres_GenreId",
                table: "Fanfics");

            migrationBuilder.DropTable(
                name: "Fandom");

            migrationBuilder.DropIndex(
                name: "IX_Fanfics_FandomId",
                table: "Fanfics");

            migrationBuilder.DropColumn(
                name: "FandomId",
                table: "Fanfics");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Fanfics",
                newName: "FanficGenreGenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Fanfics_GenreId",
                table: "Fanfics",
                newName: "IX_Fanfics_FanficGenreGenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fanfics_Genres_FanficGenreGenreId",
                table: "Fanfics",
                column: "FanficGenreGenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
