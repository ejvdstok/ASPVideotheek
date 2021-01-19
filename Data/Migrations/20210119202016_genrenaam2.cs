using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class genrenaam2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_GenreNr",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "fk_BandNr",
                table: "Verhuur");

            migrationBuilder.DropIndex(
                name: "BANDNR",
                table: "Verhuur");

            migrationBuilder.DropIndex(
                name: "IX_Films_GenreNr",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "BandNr",
                table: "Verhuur");

            migrationBuilder.DropColumn(
                name: "GenreNr",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Verhuur",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Films",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "FilmId",
                table: "Verhuur",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_GenreId",
                table: "Films",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "fk_GenreId",
                table: "Films",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_FilmId",
                table: "Verhuur",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_GenreId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "fk_FilmId",
                table: "Verhuur");

            migrationBuilder.DropIndex(
                name: "FilmId",
                table: "Verhuur");

            migrationBuilder.DropIndex(
                name: "IX_Films_GenreId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Verhuur");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "BandNr",
                table: "Verhuur",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreNr",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "BANDNR",
                table: "Verhuur",
                column: "BandNr");

            migrationBuilder.CreateIndex(
                name: "IX_Films_GenreNr",
                table: "Films",
                column: "GenreNr");

            migrationBuilder.AddForeignKey(
                name: "fk_GenreNr",
                table: "Films",
                column: "GenreNr",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_BandNr",
                table: "Verhuur",
                column: "BandNr",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
