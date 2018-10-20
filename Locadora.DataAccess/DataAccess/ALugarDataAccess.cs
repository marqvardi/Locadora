using Dapper;
using Locadora.DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Dapper.SqlMapper;

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
            al.Id = id;

            foreach (var item in al.Items)  
            {
                conexao.Execute("insert into ItemAluguel (Id_Aluguel, Id_Midia, Quantidade, StatusDevolucao) values (@IdAluguel, @IdMidia, @Quantidade, @StatusDevolucao)",
                    new {
                        IdAluguel = id,
                        IdMidia = item.Midia.Id,                        
                        item.Quantidade,
                        StatusDevolucao = item.StatusDevolucao                        
                });                           
            }
            foreach (var item in al.Items)
            {               
                conexao.Execute("update MIdia set QuantidadeAlugada = @QuantidadeAlugada + 1 where Id = @idMidia",
                    new {
                        QuantidadeAlugada = item.Midia.QuantidadeAlugada,
                        idMidia = item.Midia.Id
                    });
            }
             
            DesconectarSQL();
        }

        public IEnumerable<Cliente> PesquisarPorPendencia(string nome, string status)
        {
            ConectarSQL();

            GridReader resultados = conexao.QueryMultiple(@"select * from cliente where Nome like @nome;
                    select a.*, id_cliente as IdCliente from Aluguel a inner join cliente c on c.id = a.id_cliente where a.Status = status
                    select * from Aluguel a inner join ItemAluguel i on a.Id = i.Id_Aluguel"
                   ,
               new { nome = $"%{nome}%" });
                        
            IEnumerable<Cliente> clientes = resultados.Read<Cliente>();

            IEnumerable<Aluguel> aluguel = resultados.Read<Aluguel>();

            IEnumerable<ItemAluguel> itemAluguel = resultados.Read<ItemAluguel>();

            foreach (Cliente cliente in clientes)
            {
                //cliente.Alugueis.AddRange(items); //FUNCIONA PARCIALMENTE            
                cliente.Alugueis.AddRange(aluguel.Where(a => a.IdCliente == cliente.Id));
                
                cliente.ItemAluguel.AddRange(itemAluguel.Where(i => i.Id == cliente.Id));
            }

            DesconectarSQL();

            return clientes;
        }

        //public IEnumerable<ItemAluguel> PuxarItensAlugados(int idAluguel_ItemALuguel, int Id_Aluguel)
        //{
        //    ConectarSQL();

        //    GridReader resultados = conexao.QueryMultiple("select * from itemAluguel where Id_Aluguel like @idAluguel_ItemALuguel; select a.*, id_cliente as IdCliente from Aluguel a inner join ItemAluguel c on c.id = a.id_cliente where a.Id = Id_Aluguel");         
          
        //    IEnumerable<Aluguel> aluguel = resultados.Read<Aluguel>();

        //    IEnumerable<ItemAluguel> items = resultados.Read<ItemAluguel>();

        //    foreach (ItemAluguel item in items)
        //    {   
        //        item.AluguelLista.AddRange(aluguel.Where(a => a.Id == item.Id_Aluguel));
        //    }

        //    DesconectarSQL();

        //    return items;
        //}

    }
}
