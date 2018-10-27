using Locadora.DataAccess.DataAccess;
using System;
using System.Collections.Generic;

namespace Locadora.DataAccess.Entidades
{
    public class Aluguel
    {
        public int Id { get; set; }

        public List<ItemAluguel> Items { get; set; }
        private Valores _valores;
        public DateTime DataHora { get; set; }
        public bool Pago { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Status { get; set; }
    

        public Aluguel()
        {
            Items = new List<ItemAluguel>();
            ValoresDataAccess da = new ValoresDataAccess();
            _valores = new Valores();
            _valores.ValorAluguel = da.PuxarValorAluguel(1);
            _valores.ValorDesconto = da.PuxarValorDesconto(1);
            _valores.ValorMulta = da.PuxarValorMulta(1);
        }

        public List<Aluguel> Alugueis { get; set; }

        public Aluguel(Cliente cliente)
        {
            Items = new List<ItemAluguel>();
            ValoresDataAccess da = new ValoresDataAccess();
            _valores = new Valores();
            _valores.ValorAluguel = da.PuxarValorAluguel(1);
            _valores.ValorDesconto = da.PuxarValorDesconto(1);
            _valores.ValorMulta = da.PuxarValorMulta(1);

            Cliente = cliente;
            
        }

        public decimal ValorSubTotal
        {
            get
            {
                return _valores.ValorAluguel * Items.Count;
            }
        }

        public decimal ValorDesconto
        {
            get
            {
                if (Items.Count > 2)
                {
                    return _valores.ValorDesconto * (Items.Count - 2);
                }
                return 0;
            }
        }
        public decimal ValorTotal
        {
            get
            {
                return ValorSubTotal - ValorDesconto + ValorMulta;
            }
        }

        public decimal ValorMulta
        {
            get
            {
                return 0;
            }
        }

        public DateTime DataPrevisaoEntrega
        {
            get
            {
                return DataHora.AddDays(1);
            }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            internal set
            {
                cliente = value;
                if (cliente != null)
                {
                    IdCliente = cliente.Id;
                }
                else
                {
                    IdCliente = 0;
                }
            }
        }

        public int IdCliente { get; internal set; }



        //public bool HasMidia(Midia midiaAComparar)
        //{
        //    return Items
        //        .Select(itemAluguel => itemAluguel.Midia)
        //        .Any(midia => midia.Id == midiaAComparar.Id);
        //}
    }
}