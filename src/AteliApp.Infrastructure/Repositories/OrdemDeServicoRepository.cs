using AteliApp.Domain.Entities;
using AteliApp.Domain.Interfaces;
using AteliApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AteliApp.Infrastructure.Repositories;

public class OrdemDeServicoRepository : IOrdemDeServicoRepository
{
    private readonly AppDbContext _context;

    public OrdemDeServicoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(OrdemDeServico os)
    {
        await _context.OrdensDeServico.AddAsync(os);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(OrdemDeServico os)
    {
        _context.OrdensDeServico.Update(os);
        await _context.SaveChangesAsync();
    }

    public async Task<List<OrdemDeServico>> GetAllAsync()
    {
        return await _context.OrdensDeServico.ToListAsync();
    }

    public async Task<OrdemDeServico?> GetByIdAsync(Guid id)
    {
        return await _context.OrdensDeServico.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task DeleteAsync(Guid id)
    {
        var os = await GetByIdAsync(id);
        if (os != null)
        {
            _context.OrdensDeServico.Remove(os);
            await _context.SaveChangesAsync();
        }
    }
}