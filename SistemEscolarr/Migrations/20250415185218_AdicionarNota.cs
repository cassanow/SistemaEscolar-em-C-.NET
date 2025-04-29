using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemEscolarr.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarNota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoID = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Disciplina = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nota_Alunos_AlunoID",
                        column: x => x.AlunoID,
                        principalTable: "Alunos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nota_AlunoID",
                table: "Nota",
                column: "AlunoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nota");
        }
    }
}
