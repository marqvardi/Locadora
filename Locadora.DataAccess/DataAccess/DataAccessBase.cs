using System.Data.SqlClient;

namespace Locadora.DataAccess.DataAccess
{
    public abstract class DataAccessBase
    {
        public DataAccessBase()
        {
           //Perguntar porque tive que tirar daqui o NEW connection string da linha 15.
        }
        private const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Locadora;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected SqlConnection conexao = null;

        protected void ConectarSQL()
        {
            conexao = new SqlConnection(CONNECTION_STRING);
            conexao.Open();
        }

        protected void DesconectarSQL()
        {
            conexao.Close();
            conexao.Dispose();
        }
    }
}
