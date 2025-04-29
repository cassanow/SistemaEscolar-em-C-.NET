using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemEscolarr.Migrations
{
    /// <inheritdoc />
    public partial class Atualizar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Alunos_AlunoID",
                table: "Nota");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nota",
                table: "Nota");

            migrationBuilder.RenameTable(
                name: "Nota",
                newName: "Notas");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_AlunoID",
                table: "Notas",
                newName: "IX_Notas_AlunoID");

            migrationBuilder.AlterColumn<int>(
                name: "Disciplina",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notas",
                table: "Notas",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas",
                column: "AlunoID",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Alunos_AlunoID",
                table: "Notas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notas",
                table: "Notas");

            migrationBuilder.RenameTable(
                name: "Notas",
                newName: "Nota");

            migrationBuilder.RenameIndex(
                name: "IX_Notas_AlunoID",
                table: "Nota",
                newName: "IX_Nota_AlunoID");

            migrationBuilder.AlterColumn<string>(
                name: "Disciplina",
                table: "Nota",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nota",
                table: "Nota",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Alunos_AlunoID",
                table: "Nota",
                column: "AlunoID",
                principalTable: "Alunos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
