namespace SistemEscolarr;

public class CadastroDisciplinas
{
    private readonly BaseDados _context;

    public CadastroDisciplinas(BaseDados context)
    {
        _context = context;
        
    }
    public void AdicionarDisciplina(string nome)
    {
        Disciplina novoDisciplina = new Disciplina(nome);   
        _context.Add(novoDisciplina);   
        _context.SaveChanges();
        Console.WriteLine($"A Disciplina {novoDisciplina.Nome} foi adicionada com sucesso");
            
    }

    public void RemoverDisciplina(int idDisciplina)
    {
        Disciplina disciplina = _context.Disciplinas.Find(idDisciplina);
        if(disciplina != null)
        {
            _context.Disciplinas.Remove(disciplina);
            _context.SaveChanges();
        }
        else
        {
            Console.WriteLine("Não foi encontrada nenhuma Disciplina cadastrada com esse ID!");
        }
    }

    public void ListarDisciplinas()
    {
        var disciplinas  = _context.Disciplinas.ToList();
        if (disciplinas.Count == 0)
        {
            Console.WriteLine("Nenhuma disciplina encontrada");
        }

        foreach (var discp in disciplinas)
        {
            Console.WriteLine();
            Console.WriteLine(discp.Nome);
        }
    }

    public Disciplina BuscarDisciplina(int id)
    {
        return _context.Disciplinas.Find(id);
    }
}