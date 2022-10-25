using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class atualizacaoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "animais",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_animais_ResponsavelId",
                table: "animais",
                column: "ResponsavelId");

            migrationBuilder.AddForeignKey(
                name: "FK_animais_pessoa_ResponsavelId",
                table: "animais",
                column: "ResponsavelId",
                principalTable: "pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animais_pessoa_ResponsavelId",
                table: "animais");

            migrationBuilder.DropIndex(
                name: "IX_animais_ResponsavelId",
                table: "animais");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "animais");
        }
    }
}
