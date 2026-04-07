using AteliApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task AddAsync(Cliente cliente);
        Task<List<Cliente>> GetAllAsync();
        Task<Cliente?> GetByIdAsync(Guid id);

    }
}