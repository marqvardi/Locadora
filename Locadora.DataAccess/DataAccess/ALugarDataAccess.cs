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
                        StatusDevolucao = item.StatusDevolucao,  
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
                    select distinct a.*, id_cliente as IdCliente from Aluguel a inner join cliente c on c.id = a.id_cliente where a.Status = @status and c.Nome like @nome;
                    select distinct i.* from Cliente c inner join Aluguel a on c.id = a.Id_cliente inner join ItemAluguel i on a.Id = i.Id_Aluguel where c.nome like @nome and a.Status = @status;
                    select distinct m.* from Cliente c inner join Aluguel a on c.id = a.Id_cliente inner join ItemAluguel i on a.Id = i.Id_Aluguel inner join Midia m on m.id = i.Id_Midia where c.nome like @nome and a.Status = @status;"
            ,
            new { nome = $"%{nome}%", status });


            IEnumerable<Cliente> clientes = resultados.Read<Cliente>();

            IEnumerable<Aluguel> alugueis = resultados.Read<Aluguel>();

            IEnumerable<ItemAluguel> itemsAluguel = resultados.Read<ItemAluguel>();

            IEnumerable<Midia> midias = resultados.Read<Midia>();                 
 
            
            foreach (ItemAluguel item in itemsAluguel)
            {
                item.Midia = midias.Single(m => m.Id == item.Id_Midia);
            }

            foreach (Aluguel aluguel in alugueis)
            {
                aluguel.Items.AddRange(itemsAluguel.Where(i => i.Id_Aluguel == aluguel.Id));
            }

            foreach (Cliente cliente in clientes)
            {
                cliente.Alugueis.AddRange(alugueis.Where(a => a.IdCliente == cliente.Id));
                cliente.Alugueis.ForEach(a => a.Cliente = cliente);
            }
                      
            DesconectarSQL();

            return clientes;
        }     

    }
}
