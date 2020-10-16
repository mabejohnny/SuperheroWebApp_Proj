using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroWebApp.Data.Migrations
{
    public partial class DoingAgainToTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Superheroes",
                table: "Superheroes");

            migrationBuilder.RenameTable(
                name: "Superheroes",
                newName: "Superheros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Superheros",
                table: "Superheros",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Superheros",
                table: "Superheros");

            migrationBuilder.RenameTable(
                name: "Superheros",
                newName: "Superheroes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Superheroes",
                table: "Superheroes",
                column: "Id");
        }
    }
}
