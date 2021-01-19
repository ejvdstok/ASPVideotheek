using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class genrenaam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Genres",
                newName: "GenreNaam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreNaam",
                table: "Genres",
                newName: "Genre");
        }
    }
}
