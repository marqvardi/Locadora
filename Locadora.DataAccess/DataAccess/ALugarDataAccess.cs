using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Locadora.DataAccess.Entidades;

namespace Locadora.DataAccess.DataAccess
{
    public class AlugarDataAccess: DataAccessBase
    {
        public void InserirAluguel(Aluguel al, List<int> carrinho)
        {
            //Colocar o TransactSQL
            ItemAluguel ia = new ItemAluguel();

            int id = conexao.Query<int>("insert into Aluguel (Id_Cliente, DataHora, ValorSubTotal, ValorDesconto, ValorTotal, ValorMulta, Pago, DataEntrega, DataPrevisaoEntrega, Status) output inserted.Id values (@d_Cliente, @DataHora, @ValorSubTotal, @ValorDesconto, @ValorTotal, @ValorMulta, @Pago, @DataEntrega, @DataPrevisaoEntrega, @Status)", al).Single();
            
            foreach (var item in carrinho) //1001 . 1002. 1003
            {
                Midia md = new Midia();
                
                ia.Quantidade = 1;
                
                
                md.Id = item; // Id_Midia no banco de dados

                conexao.Execute("insert into ItemAluguel (Id_Aluguel, Id_Midia, Quantidade) values (@ia.ID, @md.Id, ia.Quantidade)");

                // int pegarquantidade = select quantidade where Midia_id = item 
                // int novaquantidade -= pegarquantidade;
                // insert novaquantidade where Midia_id = id

                    //UPDATE table
                    //SET field = GREATEST(0, field - 1)
                    //WHERE id = $number  
               
                string processQuery = "insert into ItemAluguel VALUES (@A, @B)";
                conexao.Execute(processQuery, item);                
            }

        }
    }
}
