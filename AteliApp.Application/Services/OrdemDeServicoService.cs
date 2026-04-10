using AteliApp.Application.DTOs;
using AteliApp.Domain.Entities;
using AteliApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;

namespace AteliApp.Application.Services
{
    public class OrdemDeServicoService
    {
        public readonly IOrdemDeServicoRepository _ordemDeServicoRepository;

        public OrdemDeServicoService(IOrdemDeServicoRepository ordemDeServicoRepository)
        {
            _ordemDeServicoRepository = ordemDeServicoRepository;
        }

        public async Task CriarAsync(CriarOrdemDeServicoDto criarOrdemDeServicoDto)
        {
            var os = new OrdemDeServico
            {
                Id = Guid.NewGuid(),
                ClienteId = criarOrdemDeServicoDto.ClienteId,
                Titulo = criarOrdemDeServicoDto.Titulo,
                Descricao = criarOrdemDeServicoDto.Descricao,
                DataCriacao = DateTime.Now,
                DataEntrega = criarOrdemDeServicoDto.DataEntrega,
                Status = criarOrdemDeServicoDto.Status,
                TipoServico = criarOrdemDeServicoDto.TipoServico,
                Valor = criarOrdemDeServicoDto.Valor,
                MedidasId = criarOrdemDeServicoDto.MedidasId
            };
            await _ordemDeServicoRepository.AddAsync(os);
        }


        public async Task<OrdemDeServico> ObterPorIdAsync(Guid id)
        {
            var os = await _ordemDeServicoRepository.GetByIdAsync(id);
            if (os == null)
            {
                throw new KeyNotFoundException("Ordem de serviço não encontrada.");
            }
            return os;
        }

        public async Task AtualizarAsync(Guid id, AtualizarOrdemDeServicoDto osDto)
        {
            var os = await _ordemDeServicoRepository.GetByIdAsync(id);
            if (os == null)
            {
                throw new KeyNotFoundException("Ordem de serviço não encontrada.");
            }
            os.Titulo = osDto.Titulo ?? os.Titulo;
            os.Descricao = osDto.Descricao ?? os.Descricao;
            os.DataEntrega = osDto.DataEntrega ?? os.DataEntrega;
            os.Status = osDto.Status ?? os.Status;
            os.TipoServico = osDto.TipoServico ?? os.TipoServico;
            os.Valor = osDto.Valor ?? os.Valor;
            await _ordemDeServicoRepository.UpdateAsync(os);
        }

        public async Task<List<OrdemDeServico>> ListarAsync()
        {
            return await _ordemDeServicoRepository.GetAllAsync();
        }

        public async Task DeletarAsync(Guid id)
        {
            var os = await _ordemDeServicoRepository.GetByIdAsync(id);
            if (os == null)
            {
                throw new KeyNotFoundException("Ordem de serviço não encontrada.");
            }
            os.Status = "Excluída";
            await _ordemDeServicoRepository.DeleteAsync(id);
        }
    }
}
