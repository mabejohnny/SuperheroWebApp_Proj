using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroWebApp.Data.Migrations
{
    public partial class UpdateSuperheroModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Superheroes");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Superheroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Superheroes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Superheroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
