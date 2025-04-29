public class Professor
{
    public int ID { get; set; } 
    public string Nome { get; set; }
    public char Sexo { get; set; }
    public string Disciplina { get; set; }

    public Professor() { }

    public Professor(string nome, char sexo, string disciplina)
    {
        Nome = nome;
        Sexo = sexo;
        Disciplina = disciplina;
    }
}
