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
        public void PuxarValorAluguel(Valores va)
        {
            ConectarSQL();
           // int resultado = conexao.Query<int>("Select ValorAluguel from Valores where id = @id", va);
            DesconectarSQL();
        }

        //public int PuxarValorAluguel(int id)
        //{
        //    ConectarSQL();
        //    int resultado = Convert.ToInt32(conexao.Query<int>("Select ValorAluguel from Valores where id = @id"));
        //    DesconectarSQL();

        //    return resultado;
        //}

        public string  PuxarValorAluguel()
        {
            Valores va;
            int id = 1;
            ConectarSQL();
            va = conexao.QuerySingle<Valores>("Select ValorAluguel from Valores where Id = @id", new { id });
            //decimal resultado = conexao.Query<Valores>("Select ValorAluguel * from Valores where id = @id");
            string vb = Convert.ToString(va);
            return vb;
            DesconectarSQL();
           
        }


        public void ValorAluguelMultaNovo(Valores va)
        {
            ConectarSQL();
            conexao.Execute("update Valores set ValorAluguel = @valoraluguel, valormulta = @ValorMulta where id = @id", va);
            DesconectarSQL();
        }
    }
}
