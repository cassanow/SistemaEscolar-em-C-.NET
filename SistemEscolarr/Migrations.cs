using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace SistemEscolarr
{
    public class BaseDadosFactory : IDesignTimeDbContextFactory<BaseDados>
    {
        public BaseDados CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var connectionString = configuration.GetConnectionString("Default") 
                                   ?? "Server=DESKTOP-TP4TC98;Database=Escola;Trusted_Connection=True;TrustServerCertificate=True;";

            var optionsBuilder = new DbContextOptionsBuilder<BaseDados>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BaseDados(optionsBuilder.Options);
        }
    }
}