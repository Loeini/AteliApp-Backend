﻿using AteliApp.Application.DTOs;
using AteliApp.Domain.Entities;
using AteliApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Application.Services
{
    public class ClienteService
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task CriarAsync(CriarClienteDto criarClienteDto)
        {
            if (string.IsNullOrWhiteSpace(criarClienteDto.Cpf) || string.IsNullOrWhiteSpace(criarClienteDto.Nome) )
                throw new ArgumentException("Nome e CPF do cliente são obrigatórios.");

            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Cpf = criarClienteDto.Cpf,
                Nome = criarClienteDto.Nome,
                Telefone = criarClienteDto.Telefone,
                Email = criarClienteDto.Email,
                Endereco = criarClienteDto.Endereco

            };

            await _clienteRepository.AddAsync(cliente);
        }

        public async Task<Cliente> ObterPorIdAsync(Guid id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);
            if (cliente == null)
                throw new KeyNotFoundException("Cliente não encontrado.");
            return cliente;
        }

        public async Task AtualizarAsync(Guid id, AtualizarClienteDto atualizarClienteDto)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);
            if (cliente == null)
                throw new KeyNotFoundException("Cliente não encontrado.");
            cliente.Cpf = atualizarClienteDto.Cpf ?? cliente.Cpf;
            cliente.Nome = atualizarClienteDto.Nome ?? cliente.Nome;
            cliente.Telefone = atualizarClienteDto.Telefone ?? cliente.Telefone;
            cliente.Email = atualizarClienteDto.Email ?? cliente.Email;
            cliente.Endereco = atualizarClienteDto.Endereco ?? cliente.Endereco;
            await _clienteRepository.UpdateAsync(cliente);
        }

        public async Task<List<Cliente>> ListarAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

    }
}