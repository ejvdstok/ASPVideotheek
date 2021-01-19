using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class klantid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_KlantNr",
                table: "Verhuur");

            migrationBuilder.DropIndex(
                name: "KlantNr",
                table: "Verhuur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klanten",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "KlantNr",
                table: "Verhuur");

            migrationBuilder.DropColumn(
                name: "KlantNr",
                table: "Klanten");

            migrationBuilder.AddColumn<int>(
                name: "KlantId",
                table: "Verhuur",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KlantId",
                table: "Klanten",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klanten",
                table: "Klanten",
                column: "KlantId");

            migrationBuilder.CreateIndex(
                name: "KlantId",
                table: "Verhuur",
                column: "KlantId");

            migrationBuilder.AddForeignKey(
                name: "fk_KlantId",
                table: "Verhuur",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "KlantId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_KlantId",
                table: "Verhuur");

            migrationBuilder.DropIndex(
                name: "KlantId",
                table: "Verhuur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klanten",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "KlantId",
                table: "Verhuur");

            migrationBuilder.DropColumn(
                name: "KlantId",
                table: "Klanten");

            migrationBuilder.AddColumn<int>(
                name: "KlantNr",
                table: "Verhuur",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KlantNr",
                table: "Klanten",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klanten",
                table: "Klanten",
                column: "KlantNr");

            migrationBuilder.CreateIndex(
                name: "KlantNr",
                table: "Verhuur",
                column: "KlantNr");

            migrationBuilder.AddForeignKey(
                name: "fk_KlantNr",
                table: "Verhuur",
                column: "KlantNr",
                principalTable: "Klanten",
                principalColumn: "KlantNr",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
