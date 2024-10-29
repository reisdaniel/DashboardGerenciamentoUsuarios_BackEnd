using DashboardGerenciamentoUsuarios.Core.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurações adicionais, como constraints ou relações
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
    }
}