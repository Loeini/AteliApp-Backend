using AteliApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Domain.Interfaces
{
    public interface IOrdemDeServicoRepository
    {
        Task AddAsync(OrdemDeServico os);
        Task UpdateAsync(OrdemDeServico os);
        Task<List<OrdemDeServico>> GetAllAsync();
        Task<OrdemDeServico?> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
    }
}