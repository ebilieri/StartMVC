using Microsoft.EntityFrameworkCore.Migrations;

namespace Start.UI.Site.Migrations
{
    public partial class RemoveAlunoSobrenome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Alunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Alunos",
                nullable: true);
        }
    }
}
