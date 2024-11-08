using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    // Configurando a string de conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Substitua pela sua string de conexão
        optionsBuilder.UseSqlServer("Server=localhost;Database=BibliotecaApi;User=root;Password=12345678;");
    }
}