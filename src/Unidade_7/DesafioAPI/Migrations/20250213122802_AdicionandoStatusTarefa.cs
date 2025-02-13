using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio_API.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoStatusTarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusTarefa",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusTarefa",
                table: "Tarefas");
        }
    }
}
