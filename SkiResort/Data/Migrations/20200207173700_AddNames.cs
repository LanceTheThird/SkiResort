using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Turnstiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Passes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cards",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AccessRights",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AccessRights",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Turnstiles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Passes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AccessRights");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AccessRights");
        }
    }
}
