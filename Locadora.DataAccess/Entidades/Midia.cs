namespace Locadora.DataAccess.Entidades
{
    public class Midia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        //public int Quantidade { get; set; }
        //public Categoria Categoria { get; set; }
        public int QuantidadeComprada { get; set; }
        public int QuantidadeAlugada { get; set; }
        public int QuantidaDisponivel { get; set; }
        public TiposMidia TipoMidia { get; set; }    
        public TipoDeCategoria TipoCategoria { get; set; }
        public int Id_categoria { get; set; }

    }
}
