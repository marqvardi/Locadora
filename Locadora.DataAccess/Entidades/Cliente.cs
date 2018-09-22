using System;
using System.Collections.Generic;

namespace Locadora.DataAccess.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            Enderecos = new List<Endereco>();
            Alugueis = new List<Aluguel>();
        }

        public int Id { get; set; }

        public string  Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public bool Ativo { get; set; }


        public List<Endereco> Enderecos { get; set; } 

        public List<Aluguel> Alugueis { get; set; }
    }
}
