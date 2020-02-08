using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddPassPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Passes",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Passes",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Passes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Passes");
        }
    }
}
