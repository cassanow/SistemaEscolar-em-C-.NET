
public class CadastroAluno
{
    private readonly BaseDados _context;

    public CadastroAluno(BaseDados context)
    {
        _context = context;
    }
    public void AdicionarAluno(string nome, char sexo)
    {
        Aluno novoAluno = new Aluno(nome, sexo);
        _context.Add(novoAluno);
        _context.SaveChanges();
        Console.WriteLine($"Novo aluno registrado!\n{novoAluno.ID} {novoAluno.Nome} {novoAluno.Sexo}");
    }

    public void RemoverAluno(int id)
    {
        Aluno aluno = _context.Alunos.FirstOrDefault(a => a.ID == id);
        if (aluno == null)
        {
            Console.WriteLine("Nenhum aluno encontrado registrado com esse ID");
        }
        else
        {
            _context.Remove(aluno);
            Console.WriteLine($"Aluno com o id {id} removido");
        }
    }
    public void ListarAlunos()
    {
        var alunos = _context.Alunos.ToList();
        if (alunos.Count == 0)
        {
            Console.WriteLine("Não há nenhum aluno em nossa base de dados");
        }
        else
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno.Nome}");
            }
        }
    }

    public Aluno ObterPorID(int id)
    {
        return _context.Alunos.FirstOrDefault(a => a.ID == id);
    }
}

