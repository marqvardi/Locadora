using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Dapper.SqlMapper;
using Locadora.DataAccess.Entidades;

namespace Locadora.DataAccess.DataAccess
{
    public class ValoresDataAccess : DataAccessBase
    {
        public int PuxarValorAluguel(int id)
        {
            ConectarSQL();            
            int resultado = Convert.ToInt32(conexao.Query("Select ValorAluguel from Valores where id = @id"));            
            DesconectarSQL();

            return resultado;
            
        }      

        public void ValorAluguelMultaNovo(Valores va)
        {
            ConectarSQL();
            conexao.Execute("update Valores set ValorAluguel = @valoraluguel, valormulta = @ValorMulta where id = @id", va);
            DesconectarSQL();
        }
    }
}
