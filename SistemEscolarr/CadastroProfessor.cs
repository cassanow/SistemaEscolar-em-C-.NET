using Microsoft.EntityFrameworkCore;

namespace SistemEscolarr
{
    class CadastroProfessor
    {
        private readonly BaseDados _context;

        public CadastroProfessor(BaseDados context)
        {
            _context = context;
           
        }
        public void AdicionarProfessor(string nome, char sexo, string disciplina)
        {
            Professor professor = new Professor(nome, sexo, disciplina);
            _context.Add(professor);
            _context.SaveChanges();
            Console.WriteLine($"Novo professor registrado!\n{professor.ID}\n{professor.Nome}\n{professor.Sexo}\n{professor.Disciplina}");
        }

        public void RemoverProfessor(int id)
        {
            Professor professor = _context.Professores.FirstOrDefault(p => p.ID == id);
            if (professor == null)
            {
                Console.WriteLine("Não há nenhum professor cadastrado com esse ID");
                return;
            }
            else
            {
                _context.Remove(professor);
                _context.SaveChanges();
                Console.WriteLine($"Professor com o ID {id} removido");
            }
        }

        public void ListarProfessores()
        {
            var professores = _context.Professores.ToList();
            if(professores.Count == 0)
            {
                Console.WriteLine("Não há professores registrados em nossa base de dados");
            }
            foreach(var professor in professores)
            {
                Console.WriteLine($"Professor: {professor.ID}\n{professor.Nome}\n{professor.Sexo}\n{professor.Disciplina}");
            }
        }

        public Professor ObterProfessor(int id)
        {
            return _context.Professores.FirstOrDefault(p => p.ID == id);
            
        }
    }
}
