using AteliApp.Domain.Entities;
using AteliApp.Domain.Interfaces;
using AteliApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AteliApp.Infrastructure.Repositories;

public class MedidasRepository : IMedidasRepository
{
    private readonly AppDbContext _context;

    public MedidasRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Medidas medidas)
    {
        _context.Medidas.Add(medidas);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Medidas medidas)
    {
        _context.Medidas.Update(medidas);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Medidas>> GetAllAsync()
    {
        return await _context.Medidas.ToListAsync();
    }

    public async Task<Medidas?> GetByIdAsync(Guid id)
    {
        return await _context.Medidas.FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<List<Medidas>> GetByClienteIdAsync(Guid idCliente)
    {
        return await _context.Medidas.Where(m => m.IdCliente == idCliente).ToListAsync();
    }
}