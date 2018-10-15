namespace Locadora.DataAccess.Entidades
{
    public class ItemAluguel
    {
        public int Quantidade { get; private set; }
        public Midia Midia { get; private set; }
        public bool StatusDevolucao { get; set; }

        public ItemAluguel(Midia midia, int quantidade = 1)
        {
            Midia = midia;
            Quantidade = quantidade;
        }           

        public string NomeMidia {
            get
            {
                return Midia.Titulo;
            }
        }        
    }
}