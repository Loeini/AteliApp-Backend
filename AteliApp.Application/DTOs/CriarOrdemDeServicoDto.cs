using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Application.DTOs
{
    public class CriarOrdemDeServicoDto
    {
        public Guid ClienteId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Status { get; set; }
        public string TipoServico { get; set; }
        public decimal Valor { get; set; }
        public Guid? MedidasId { get; set; }

        public CriarOrdemDeServicoDto(
            Guid clienteId, 
            string titulo, 
            string descricao, 
            DateTime? dataEntrega, 
            string status, 
            string tipoServico, 
            decimal valor, 
            Guid? medidasId)
        {
            ClienteId = clienteId;
            Titulo = titulo;
            Descricao = descricao;
            DataEntrega = dataEntrega;
            Status = status;
            TipoServico = tipoServico;
            Valor = valor;
            MedidasId = medidasId;
        }

    }
}
