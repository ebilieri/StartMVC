using Microsoft.EntityFrameworkCore.Migrations;

namespace Start.UI.Site.Migrations
{
    public partial class AlunosSobrenome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Alunos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Alunos");
        }
    }
}
