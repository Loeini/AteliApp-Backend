using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Application.DTOs
{
    public class AtualizarOrdemDeServicoDto
    {
        public string? Titulo { get; }
        public string? Descricao { get; }
        public DateTime? DataEntrega { get; }
        public string? Status { get; }
        public string? TipoServico { get; }
        public decimal? Valor { get; }

        public AtualizarOrdemDeServicoDto(
            string? titulo, 
            string? descricao, 
            DateTime? dataEntrega, 
            string? status, 
            string? tipoServico, 
            decimal? valor)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataEntrega = dataEntrega;
            Status = status;
            TipoServico = tipoServico;
            Valor = valor;
        }
    }
}
