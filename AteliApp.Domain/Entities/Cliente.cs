using System;
using System.Collections.Generic;
using System.Text;

namespace AteliApp.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public String Cpf { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        //public Medidas Medidas { get; set; }


    }
}