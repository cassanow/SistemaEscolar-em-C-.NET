using Microsoft.EntityFrameworkCore;

namespace SistemEscolarr
{
    public static class ConfigDbContext
    {
        public static BaseDados Criar()
        {
            var options = new DbContextOptionsBuilder<BaseDados>()
            .UseSqlServer("Server=DESKTOP-TP4TC98;Database=Escola;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

            var context = new BaseDados(options);

           return context;
        }
    }
}
