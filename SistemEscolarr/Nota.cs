
public class Nota
{
    public int ID { get; set; }
    public string Aluno { get; set; }
    public double Valor { get; set; }
    public string Disciplina { get; set; }
    
    public Nota() { }   

    public Nota(string aluno, double valor, string disciplina)
    {

        Aluno = aluno;
        Valor = valor;
        Disciplina = disciplina;
        
    }
    
}