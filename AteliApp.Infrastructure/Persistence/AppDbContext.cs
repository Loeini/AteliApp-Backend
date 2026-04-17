using AteliApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AteliApp.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Medidas> Medidas => Set<Medidas>();
    public DbSet<OrdemDeServico> OrdensDeServico => Set<OrdemDeServico>();
}