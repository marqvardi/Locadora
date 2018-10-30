using Dapper;
using Locadora.DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using static Dapper.SqlMapper;

namespace Locadora.DataAccess.DataAccess
{
    public class AlugarDataAccess: DataAccessBase
    {
        public void InserirAluguel(Aluguel aluguel)
        {           
            aluguel.DataHora = DateTime.Now;            
            
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
                                                          @DataPrevisaoEntrega) ", aluguel).Single();
            aluguel.Id = id;

            foreach (var item in aluguel.Items)
            {
                item.Aluguel = aluguel;
                InserirItemAluguel(item);
                DarBaixaEstoque(item.Midia);
            }

            DesconectarSQL();
        }

        private void DarBaixaEstoque(Midia midia)
        {
            conexao.Execute("update MIdia set QuantidadeAlugada = QuantidadeAlugada + 1 where Id = @Id", midia);
        }

        private void InserirItemAluguel(ItemAluguel item)
        {
            conexao.Execute("insert into ItemAluguel (Id_Aluguel, Id_Midia, Quantidade, StatusDevolucao) values (@Id_Aluguel, @Id_Midia, @Quantidade, @StatusDevolucao)", item);
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

        public void DevolverAluguel(Aluguel aluguel)
        {
            ConectarSQL();
            foreach (var item in aluguel.Items.Where(item => item.StatusDevolucao))
            {
                 DevolverItem(item);
                 DevolverEstoque(item.Midia);
            }

            if (aluguel.Items.All(item => item.StatusDevolucao))
            {                
                aluguel.DataEntrega = DateTime.Now;
                PagarAluguel(aluguel);
                //Colocar o Valor Total no Caixa
                //Podemos colocar os descontos e multas apenas para apreciacao
            }

            DesconectarSQL();
        }

        private void PagarAluguel(Aluguel aluguel)
        {
            conexao.Execute("update Aluguel set Pago = 1, DataEntrega = @DataEntrega where Id = @Id", aluguel);
        }

        private void DevolverEstoque(Midia midia)
        {
            conexao.Execute("update Midia set QuantidadeAlugada = QuantidadeAlugada - 1 where Id = @Id", midia);
        }

        private void DevolverItem(ItemAluguel item)
        {
            conexao.Execute("update ItemAluguel set StatusDevolucao = @StatusDevolucao where Id_Aluguel = @Id_Aluguel and Id_Midia = @Id_Midia", item);
        }
    }
}
