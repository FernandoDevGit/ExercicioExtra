using Microsoft.EntityFrameworkCore.Migrations;

namespace LivroVisita.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Visitante",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Email",
                table: "Visitante",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
