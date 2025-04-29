
using SistemEscolarr;

public class CalcularNota
{
    
    private Disciplina disciplina;
    private CadastroAluno alunos;    
    private CadastroDisciplinas disciplinas;
    private readonly BaseDados _context;

    public CalcularNota(BaseDados context, CadastroAluno cadastroAluno)
    {
        _context = context;
        alunos = cadastroAluno;
    }

    public void CalcularNotas(int idAlunos)
    {
        Console.WriteLine("Qual disciplina deseja registrar as notas? ");
        string id = Console.ReadLine();
        
        int.TryParse(id, out int idDisciplina);  
        disciplina = _context.Disciplinas.Find(idDisciplina);
        var disciplinas = _context.Disciplinas.ToList();
        if (disciplinas.Count == 0)
        {
            Console.WriteLine("Não há nenhuma disciplina registrada");
        }
        else if (disciplina == null)
        {
            Console.WriteLine("Não há nenhuma disciplina registrada com esse ID");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{disciplina.Nome}");

            Console.WriteLine("Qual foi a primeira nota do Aluno? ");
            double Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a segunda nota do Aluno? ");
            double Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a primeira nota de trabalho que o aluno obteve? ");
            double notaTrabalho1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a segunda nota de trabalho que o aluno obteve? ");
            double notaTrabalho2 = double.Parse(Console.ReadLine());

            double Valor = (Nota1 + Nota2 + notaTrabalho1 + notaTrabalho2) / 4;
           
            Console.WriteLine($"{Valor} em {disciplina.Nome}"); 
            
            
            Aluno aluno = alunos.ObterPorID(idAlunos);   
            string nomeAluno = aluno.Nome;
            string nomeDisciplina = disciplina.Nome;    
            Nota nota = new Nota(nomeAluno, Valor, nomeDisciplina); 
            _context.Add(nota);
            _context.SaveChanges(); 
        }

    }
}

