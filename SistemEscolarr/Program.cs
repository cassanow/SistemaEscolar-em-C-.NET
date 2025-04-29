using System.Globalization;
using SistemEscolarr;

class Program
{

    static void Main(string[] args)
    {
        var context = ConfigDbContext.Criar();
        context.Database.EnsureCreated();
        bool santos = true;


        CadastroAluno aluno = new CadastroAluno(context);
        CadastroProfessor professor = new CadastroProfessor(context);
        CalcularNota calcular = new CalcularNota(context, aluno);
        CadastroDisciplinas disciplinas = new CadastroDisciplinas(context);


        while (santos == true)
        {
            Console.WriteLine("Escolha uma opcao");
            string opc = Console.ReadLine();
            int.TryParse(opc, out int opcao);
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Qual nome do aluno que deseja adicionar? ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Qual o sexo do aluno? ");
                    string sexo = Console.ReadLine();

                    if (char.TryParse(sexo, out char sexoImput) &&
                        (sexoImput == 'M' || sexoImput == 'F'))
                    {
                        aluno.AdicionarAluno(nome, sexoImput);
                    }
                    else
                    {
                        Console.WriteLine("Sexo invalido! Utilize apenas as letras M ou F");
                        return;
                    }

                    break;

                case 2:

                    Console.WriteLine("Deseja remover qual aluno?  ");
                    string id = Console.ReadLine();
                    if (!int.TryParse(id, out int idAluno))
                    {
                        Console.WriteLine("Por favor, digite um ID válido");
                    }
                    else
                    {
                        Aluno removerAluno = aluno.ObterPorID(idAluno);
                        Console.WriteLine($"Aluno {removerAluno.Nome} removido com sucesso! ");
                        aluno.RemoverAluno(idAluno);
                    }

                    break;
                case 3:
                    aluno.ListarAlunos();
                    break;
                case 4:

                    Console.WriteLine("Qual professor deseja adicionar? ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Qual o sexo do professor? ");
                    sexo = Console.ReadLine();

                    Console.WriteLine("Qual a disciplina do professor?");
                    string disciplina = Console.ReadLine();

                    if (char.TryParse(sexo, out sexoImput) &&
                        (sexoImput == 'M' || sexoImput == 'F'))
                    {
                        professor.AdicionarProfessor(nome, sexoImput, disciplina);
                    }
                    else
                    {
                        Console.WriteLine("Sexo invalido! Utilize apenas as letras M ou F");
                        return;
                    }

                    break;
                case 5:
                    Console.WriteLine("Deseja remover qual professor? ");
                    id = Console.ReadLine();
                    if (!int.TryParse(id, out int idProfessor))
                    {
                        Console.WriteLine("Por favor, digite um id válido");
                    }
                    else
                    {
                        Professor removerProfessor = professor.ObterProfessor(idProfessor);
                        Console.WriteLine($"Professor {removerProfessor.Nome} removido com sucesso!");
                        professor.RemoverProfessor(idProfessor);    
                    }
                    break;
                case 6:
                    professor.ListarProfessores();
                    break;
                case 7:
                    Console.WriteLine("Qual disciplina deseja adicionar? ");
                    nome = Console.ReadLine();
                    disciplinas.AdicionarDisciplina(nome);
                    break;
                case 8:
                    Console.WriteLine("Deseja remover qual disciplina?");
                    id = Console.ReadLine();
                    if (!int.TryParse(id, out int idDisciplina))
                    {
                        Console.WriteLine("Por favor, digite um id válido!");
                    }
                    else
                    {
                        Disciplina removerDisciplina = disciplinas.BuscarDisciplina(idDisciplina);
                        Console.WriteLine($"Disciplina {removerDisciplina.Nome} removidA com sucesso!");
                        disciplinas.RemoverDisciplina(idDisciplina);
                    }
                    break;
                case 9:
                    disciplinas.ListarDisciplinas();
                    break;
                case 10:
                    Console.WriteLine(
                        "Deseja colocar a nota de qual aluno no sistema? (por favor informe pelo ID do aluno) ");
                    id = Console.ReadLine();

                    if (!int.TryParse(id, out idAluno))
                    {
                        Console.WriteLine("Digite um id válido, por favor");
                    }
                    else
                    {
                        Aluno alunos = aluno.ObterPorID(idAluno);
                        if (alunos == null)
                        {
                            Console.WriteLine($"Aluno com o id {idAluno} não encontrado");
                            return;
                        }

                        Console.WriteLine($"Essas são as notas finais do aluno {alunos.Nome}");
                        calcular.CalcularNotas(idAluno);
                    }
                    break;

                    
            }
        }
    }
}