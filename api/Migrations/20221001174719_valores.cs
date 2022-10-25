using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class valores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "Idade",
                table: "animais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "pessoa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "animais",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
