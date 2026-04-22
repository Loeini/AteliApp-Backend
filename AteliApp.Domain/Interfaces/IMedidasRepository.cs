using AteliApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Domain.Interfaces
{
    public interface IMedidasRepository
    {
        Task AddAsync(Medidas medidas);
        Task UpdateAsync(Medidas medidas);
        Task<List<Medidas>> GetAllAsync();
        Task<Medidas?> GetByIdAsync(Guid id);
        Task<List<Medidas>> GetByClienteIdAsync(Guid idCliente);

    }
}