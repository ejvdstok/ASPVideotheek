using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreNr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreNr);
                });

            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantNr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Voornaam = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Straat_Nr = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PostCode = table.Column<int>(nullable: false),
                    Gemeente = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    KlantStat = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    HuurAantal = table.Column<int>(nullable: false),
                    DatumLid = table.Column<DateTime>(type: "date", nullable: false),
                    Lidgeld = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantNr);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    GenreNr = table.Column<int>(nullable: false),
                    InVoorraad = table.Column<int>(nullable: false),
                    UitVoorraad = table.Column<int>(nullable: false),
                    Prijs = table.Column<decimal>(type: "money", nullable: false),
                    TotaalVerhuurd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                    table.ForeignKey(
                        name: "fk_GenreNr",
                        column: x => x.GenreNr,
                        principalTable: "Genres",
                        principalColumn: "GenreNr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Verhuur",
                columns: table => new
                {
                    VerhuurNr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlantNr = table.Column<int>(nullable: false),
                    BandNr = table.Column<int>(nullable: false),
                    VerhuurDatum = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verhuur", x => x.VerhuurNr);
                    table.ForeignKey(
                        name: "fk_BandNr",
                        column: x => x.BandNr,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_KlantNr",
                        column: x => x.KlantNr,
                        principalTable: "Klanten",
                        principalColumn: "KlantNr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_GenreNr",
                table: "Films",
                column: "GenreNr");

            migrationBuilder.CreateIndex(
                name: "DATUMLID",
                table: "Klanten",
                column: "DatumLid");

            migrationBuilder.CreateIndex(
                name: "POSTCODE",
                table: "Klanten",
                column: "PostCode");

            migrationBuilder.CreateIndex(
                name: "BANDNR",
                table: "Verhuur",
                column: "BandNr");

            migrationBuilder.CreateIndex(
                name: "KlantNr",
                table: "Verhuur",
                column: "KlantNr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verhuur");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Klanten");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
