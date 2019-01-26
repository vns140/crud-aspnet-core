using Microsoft.EntityFrameworkCore.Migrations;

namespace estudo.Migrations
{
    public partial class mudancas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eletrica",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "Mecanica",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "Suspensao",
                table: "Mecanicos");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Mecanicos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotaMedia",
                table: "Mecanicos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Mecanicos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "NotaMedia",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Mecanicos");

            migrationBuilder.AddColumn<bool>(
                name: "Eletrica",
                table: "Mecanicos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mecanica",
                table: "Mecanicos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Suspensao",
                table: "Mecanicos",
                nullable: false,
                defaultValue: false);
        }
    }
}
