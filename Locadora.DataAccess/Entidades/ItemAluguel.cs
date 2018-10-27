namespace Locadora.DataAccess.Entidades
{
    public class ItemAluguel
    {
        public ItemAluguel()
        {
        }

        public ItemAluguel(Aluguel aluguel, Midia midia, int quantidade = 1)
        {
            Midia = midia;
            Quantidade = quantidade;
            Aluguel = aluguel;
        }

        
        public int Quantidade { get; private set; }

        public bool StatusDevolucao { get; set; }

        public string NomeMidia
        {
            get
            {
                return Midia.Titulo;
            }
        }

        public Midia Midia { get; internal set; }
        public int Id_Midia { get; internal set; }

        public Aluguel Aluguel { get; internal set; }
        public int Id_Aluguel { get; internal set; }
    }
}