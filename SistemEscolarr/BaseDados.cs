
using Microsoft.EntityFrameworkCore;

public class BaseDados : DbContext
{
	public BaseDados(DbContextOptions<BaseDados> options) : base(options)
    {
        
    }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    
	public DbSet<Disciplina> Disciplinas { get; set; }
	
	public DbSet<Nota> Notas { get; set; }	
}
 