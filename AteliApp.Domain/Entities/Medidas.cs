using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Domain.Entities
{
    public class Medidas
    {
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Busto { get; set; }
        public decimal? Cintura { get; set; }
        public decimal? Quadril { get; set; }
        public decimal? Ombro { get; set; }
        public string? Outros { get; set; }
        public string? Observacao { get; set; }

    }
}