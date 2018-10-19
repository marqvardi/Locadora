using System.Collections.Generic;

namespace Locadora.DataAccess.Entidades
{
    public class ItemAluguel
    {
        public int Id { get; set; }
        public int Id_Aluguel { get; set; }
        public int Quantidade { get; private set; }
        public Midia Midia { get; private set; }
        public bool StatusDevolucao { get; set; }
        public List<Aluguel> AluguelLista { get; set; }
        public Cliente Cliente { get; set; }

        public ItemAluguel(Cliente cliente, Midia midia, int quantidade = 1)
        {
            Midia = midia;
            Quantidade = quantidade;
        }

        public ItemAluguel()
        {
        }

        public string NomeMidia
        {
            get
            {
                return Midia.Titulo;
            }
        }      
    }
}