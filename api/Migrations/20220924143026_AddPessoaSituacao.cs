using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddPessoaSituacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Situacao",
                table: "pessoa",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                ;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "pessoa");
        }
    }
}
