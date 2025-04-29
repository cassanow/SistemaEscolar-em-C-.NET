using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemEscolarr.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarDnV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas");

            migrationBuilder.AlterColumn<string>(
                name: "Disciplina",
                table: "Notas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoID",
                table: "Notas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Aluno",
                table: "Notas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas",
                column: "AlunoID",
                principalTable: "Alunos",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "Aluno",
                table: "Notas");

            migrationBuilder.AlterColumn<int>(
                name: "Disciplina",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoID",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas",
                column: "AlunoID",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
