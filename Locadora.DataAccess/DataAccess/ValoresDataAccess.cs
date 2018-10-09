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
        public decimal PuxarValorAluguel(int id)
        {
            ConectarSQL();
            Decimal resultado = conexao.ExecuteScalar<int>("SELECT ValorAluguel FROM Valores");
            DesconectarSQL();
            return resultado;
        }

        public decimal PuxarValorMulta(int id)
        {
            ConectarSQL();
            Decimal resultado = conexao.ExecuteScalar<int>("SELECT ValorMulta FROM Valores");
            DesconectarSQL();
            return resultado;
        }

        public decimal PuxarValorDesconto(int id)
        {
            ConectarSQL();
            Decimal resultado = conexao.ExecuteScalar<int>("SELECT ValorDesconto FROM Valores");
            DesconectarSQL();
            return resultado;
        }

        public void ValorAluguelMultaNovo(Valores va)
        {
            ConectarSQL();
            conexao.Execute("update Valores set ValorAluguel = @valoraluguel, valormulta = @ValorMulta, valorDesconto = @ValorDesconto where id = @id", va);
            DesconectarSQL();
        }
    }
}
