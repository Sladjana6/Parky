using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkyAPI.Migrations
{
    public partial class RenamedTableNationalParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalParks",
                table: "NationalParks");

            migrationBuilder.RenameTable(
                name: "NationalParks",
                newName: "NationalPark");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalPark",
                table: "NationalPark",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NationalPark",
                table: "NationalPark");

            migrationBuilder.RenameTable(
                name: "NationalPark",
                newName: "NationalParks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationalParks",
                table: "NationalParks",
                column: "Id");
        }
    }
}
