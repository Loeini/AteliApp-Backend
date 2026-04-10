using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Domain.Entities
{
    public class Medidas
    {
        public Guid Id { get; set; }
        public int IdCliente { get; set; }
        public int Altura { get; set; }
        public int Busto { get; set; }
        public int Cintura { get; set; }
        public int Quadril { get; set; }
        public int Ombro { get; set; }
        string Observacao { get; set; }

    }
}