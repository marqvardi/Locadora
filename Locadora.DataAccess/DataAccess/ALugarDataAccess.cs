using Dapper;
using Locadora.DataAccess.Entidades;
using System;
using System.Linq;

namespace Locadora.DataAccess.DataAccess
{
    public class AlugarDataAccess: DataAccessBase
    {
        public void InserirAluguel(Aluguel al)
        {
            al.DataHora = DateTime.Now;
            ConectarSQL();
            int id = conexao.Query<int>(@"INSERT INTO aluguel 
                                                        (id_cliente, 
                                                         valorsubtotal, 
                                                         dataHora,
                                                         valordesconto,  
                                                         valormulta, 
                                                         pago, 
                                                         dataentrega, 
                                                         dataprevisaoentrega) 
                                            output      inserted.id 
                                            VALUES      ( @IdCliente, 
                                                          @ValorSubTotal, 
                                                          @dataHora,
                                                          @ValorDesconto, 
                                                          @ValorMulta, 
                                                          @Pago, 
                                                          @DataEntrega, 
                                                          @DataPrevisaoEntrega) ", al).Single();
            
            foreach (var item in al.Items)  
            {
                conexao.Execute("insert into ItemAluguel (Id_Aluguel, Id_Midia, Quantidade) values (@IdAluguel, @IdMidia, @Quantidade)",
                    new {
                        IdAluguel = id,
                        IdMidia = item.Midia.Id,
                        item.Quantidade
                });
                           
            }
            al.Id = id;
            DesconectarSQL();
        }
    }
}
