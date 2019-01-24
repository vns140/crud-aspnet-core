using Microsoft.EntityFrameworkCore.Migrations;

namespace estudo.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DDDCelular",
                table: "Mecanicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DDDTelefone",
                table: "Mecanicos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DDDCelular",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "DDDTelefone",
                table: "Mecanicos");
        }
    }
}
