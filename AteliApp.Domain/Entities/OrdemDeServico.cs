using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Domain.Entities
{
    public class OrdemDeServico
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public Guid ClienteId { get; set; }
        public string Status { get; set; }
        public string TipoServico { get; set; }
        public decimal Valor { get; set; }
        public Guid? MedidasId { get; set; }
    }
}
