using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class namen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_GenreNr",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "GenreNr",
                table: "Genres");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Genres",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "fk_GenreNr",
                table: "Films",
                column: "GenreNr",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_GenreNr",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Genres");

            migrationBuilder.AddColumn<int>(
                name: "GenreNr",
                table: "Genres",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreNr");

            migrationBuilder.AddForeignKey(
                name: "fk_GenreNr",
                table: "Films",
                column: "GenreNr",
                principalTable: "Genres",
                principalColumn: "GenreNr",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
