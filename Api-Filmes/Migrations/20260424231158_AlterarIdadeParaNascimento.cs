using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Filmes.Migrations
{
    /// <inheritdoc />
    public partial class AlterarIdadeParaNascimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Diretores");

            migrationBuilder.AddColumn<string>(
                name: "Nascimento",
                table: "Diretores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Diretores");

            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Diretores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
