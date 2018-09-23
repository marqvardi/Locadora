using System;
using System.Collections.Generic;

namespace Locadora.DataAccess.Entidades
{
    public class Aluguel
    {
        /// <summary>
        ///  O meu comentario eh melhor
        /// </summary>
        public DateTime DataHora { get; set; }
        public decimal ValorSubTotal { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorMulta { get; set; }
        public bool Pago { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Status { get; set; }

        public List<ItemAluguel> Items { get; set; }

    }
}