using AteliApp.Application.DTOs;
using AteliApp.Domain.Entities;
using AteliApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Application.Services
{
    public class MedidasService
    {

        private readonly IMedidasRepository _medidasRepository;

        public MedidasService(IMedidasRepository medidasRepository)
        {
            _medidasRepository = medidasRepository;
        }

        public async Task CriarAsync(CriarMedidasDto criarMedidasDto)
        {

            var medidas = new Medidas
            {
                Id = Guid.NewGuid(),
                IdCliente = criarMedidasDto.IdCliente,
                Altura = criarMedidasDto.Altura,
                Busto = criarMedidasDto.Busto,
                Cintura = criarMedidasDto.Cintura,
                Quadril = criarMedidasDto.Quadril,
                Ombro = criarMedidasDto.Ombro,
                Outros = criarMedidasDto.Outros,
                Observacao = criarMedidasDto.Observacao
            };

            await _medidasRepository.AddAsync(medidas);
        }

        public async Task<Medidas> ObterPorIdAsync(Guid id)
        {
            var medidas = await _medidasRepository.GetByIdAsync(id);
            if (medidas == null)
                throw new KeyNotFoundException("Medidas não encontradas.");
            return medidas;
        }

        public async Task AtualizarAsync(Guid id, AtualizarMedidasDto atualizarMedidasDto)
        {
            var medidas = await _medidasRepository.GetByIdAsync(id);
            if (medidas == null)
                throw new KeyNotFoundException("Medidas não encontradas.");
            medidas.Altura = atualizarMedidasDto.Altura ?? medidas.Altura;
            medidas.Busto = atualizarMedidasDto.Busto ?? medidas.Busto;
            medidas.Cintura = atualizarMedidasDto.Cintura ?? medidas.Cintura;
            medidas.Quadril = atualizarMedidasDto.Quadril ?? medidas.Quadril;
            medidas.Ombro = atualizarMedidasDto.Ombro ?? medidas.Ombro;
            medidas.Outros = atualizarMedidasDto.Outros ?? medidas.Outros;
            medidas.Observacao = atualizarMedidasDto.Observacao ?? medidas.Observacao;
            await _medidasRepository.UpdateAsync(medidas);
        }

        public async Task<List<Medidas>> ListarAsync()
        {
            return await _medidasRepository.GetAllAsync();
        }

        public async Task<List<Medidas>> ObterPorClienteIdAsync(Guid idCliente)
        {
            return await _medidasRepository.GetByClienteIdAsync(idCliente);
        }
    }
}
          