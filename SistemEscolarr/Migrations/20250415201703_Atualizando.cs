using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemEscolarr.Migrations
{
    /// <inheritdoc />
    public partial class Atualizando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_AlunoID",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "AlunoID",
                table: "Notas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoID",
                table: "Notas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlunoID",
                table: "Notas",
                column: "AlunoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas",
                column: "AlunoID",
                principalTable: "Alunos",
                principalColumn: "ID");
        }
    }
}
