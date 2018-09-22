namespace Locadora.DataAccess.Entidades
{
    public class Endereco
    {

        internal Endereco()
        {

        }

        public Endereco(int idCliente)
        {
            IdCliente = idCliente;
        }

        public int IdCliente { get; private set; }
        public string Logradouro { get; set; }
        public int Id { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

    }
}