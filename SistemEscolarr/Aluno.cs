using SistemEscolarr;

public class Aluno
{
    private Nota nota;
    public Aluno() { }
    public Aluno(string nome, char sexo)
    {
        Nome = nome;
        Sexo = sexo;
    }

    public int ID { get; set; }
    public string Nome { get; set; }
    public char Sexo { get; set; }
    
    
}
