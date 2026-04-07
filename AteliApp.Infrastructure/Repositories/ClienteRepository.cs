using AteliApp.Domain.Entities;
using AteliApp.Domain.Interfaces;
using AteliApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AteliApp.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Cliente>> GetAllAsync()
    {
        return await _context.Clientes.ToListAsync();
    }

    public async Task<Cliente?> GetByIdAsync(Guid id)
    {
        return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
    }
}