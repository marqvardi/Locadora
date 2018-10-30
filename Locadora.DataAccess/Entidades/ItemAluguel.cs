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


        private Midia _midia;

        public Midia Midia
        {
            get
            {
                return _midia;
            }
            internal set
            {
                _midia = value;
                Id_Midia = value != null
                    ? _midia.Id 
                    : 0;
            }
        }

        public int Id_Midia { get; internal set; }


        private Aluguel _aluguel;
        public Aluguel Aluguel {
            get
            {
                return _aluguel;
            }
            internal set
            {
                _aluguel = value;
                Id_Aluguel = value != null
                    ? _aluguel.Id
                    : 0;
            }
        }

        public int Id_Aluguel { get; internal set; }
    }
}