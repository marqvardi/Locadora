using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Locadora.DataAccess.DataAccess
{
    public class AlugarDataAccess: DataAccessBase
    {
        public void InserirAluguel(int id, List<int> carrinho)
        {
            foreach (var item in carrinho)
            {
                conexao.Execute("INSERT INTO ALUGUEL (id_cliente, Datahora) VALUES (@id_cliente, @)");
            }
            
        }
    }
}
