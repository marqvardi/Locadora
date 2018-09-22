using Dapper;
using Locadora.DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static Dapper.SqlMapper;

namespace Locadora.DataAccess.DataAccess
{
    public class ClienteDataAccess : DataAccessBase
    {       

        public void InsertSQLCliente(Cliente cliente)
        {
            
            ConectarSQL();
            //Explicar melhor esse lance de "output inserted.id"
            int id = conexao.Query<int>("insert into Cliente (Nome, Datanascimento, ativo) output inserted.Id values (@Nome, @datanascimento, @ativo)", cliente).Single();
            cliente.Id = id;
           
            DesconectarSQL();
        }

        public void InsertSQLEndereco(Endereco endereco)
        {
            ConectarSQL();
            conexao.Execute("insert into Endereco(Logradouro, Bairro, CEP, Numero, Complemento, id_cliente ) values (@logradouro, @bairro, @cep, @numero, @complemento, @idcliente)",  endereco);
            DesconectarSQL();
        }

        public IEnumerable<Cliente> PesquisarPorNome(string nome)
        {
            ConectarSQL();

            GridReader resultados = conexao.QueryMultiple("select * from cliente where Nome like @nome; select e.*, id_cliente as IdCliente from endereco e inner join cliente c on c.id = e.id_cliente where c.nome like @nome",
                new { nome = $"%{nome}%" });

            //GridReader resultados = conexao.QueryMultiple("select * from cliente where Nome like @nome; select e.*, id_cliente as IdCliente from endereco e inner join cliente c on c.id = e.id_cliente where c.nome like @nome",
            //    new { nome = $"%{nome}%" });

            // Nada claro na minha cabeca isso abaixo
            IEnumerable<Cliente> clientes = resultados.Read<Cliente>();

            IEnumerable<Endereco> enderecos = resultados.Read<Endereco>();

            foreach(Cliente cliente in clientes)
            {
                cliente.Enderecos.AddRange(enderecos.Where(e => e.IdCliente == cliente.Id)); //Nao entendi muito bem essa linha
            }

            DesconectarSQL();

            return clientes;
        }

        public List<Cliente> PesquisarPorId(int id)
        {
            List<Cliente> resultados = new List<Cliente>();

            ConectarSQL();
            SqlCommand comandoconsulta = new SqlCommand("select * from [Cliente] where id = @id", conexao);
            //comandoconsulta.Parameters.AddWithValue("@nome", "%" + nome + "%"); Mesma coisa que o debaixo. Mas melhor, ao inves de usar 3 endereco de memoria strings
            comandoconsulta.Parameters.AddWithValue("@id", id);

            //SqlDataReader leitor = comandoconsulta.ExecuteReader(); O cratera diz que e' melhor usar o VAR abaixo
            var leitor = comandoconsulta.ExecuteReader();

            while (leitor.Read())
            {
                Cliente c = new Cliente();
                c.Id = Convert.ToInt32(leitor["id"]);
                c.Nome = leitor["nome"].ToString();
              //  c.Endereco = leitor["endereco"].ToString();

                resultados.Add(c);
            }

            DesconectarSQL();

            return resultados;
            //grdPessoas.DataSource = dtPessoas;       

            //comandoconsulta.ExecuteNonQuery(); Nao e' necessario pois Select is Query
        }
       
        private int id;
        private string nome;

        public List<Cliente> AlugarPorId(int id)
        {
            List<Cliente> resultados = new List<Cliente>();

            ConectarSQL();
            SqlCommand comandoconsulta = new SqlCommand("select * from [Cliente] where id = @id", conexao);
            comandoconsulta.Parameters.AddWithValue("@id", id);

            var leitor = comandoconsulta.ExecuteReader();

            while (leitor.Read())
            {
                Cliente c = new Cliente();
                c.Id = Convert.ToInt32(leitor["id"]);
                c.Nome = leitor["nome"].ToString();
               // c.Endereco = leitor["endereco"].ToString();

                resultados.Add(c);
            }
            
            DesconectarSQL();

            return resultados;
        }      

        public void UpdateSQLEndereco(Endereco endereco)
        {
            ConectarSQL();
            conexao.Execute("update Endereco set Logradouro = @Logradouro, Bairro = @bairro, CEP = @cep, Numero = @numero, Complemento = @complemento where id = @id", endereco);
            //Ta dando bug aqui. ele muda o endereco. Mas depois que voce clica no "pesquisar" de novo, ele meio que copia os enderecos todos iguais.
            DesconectarSQL();
        }

        public void UpdateSQLCliente(Cliente cliente)
        {
            ConectarSQL();
            //conexao.Execute("update into Cliente (Nome, Datanascimento, ativo) output inserted.Id values (@Nome, @datanascimento, @ativo)", cliente);
            conexao.Execute("update [Cliente] set Nome = @nome, Datanascimento = @datanascimento, ativo = @ativo where id = @id", cliente);
            DesconectarSQL();
        }



        public void DeletarSQL(int id)
        {
            ConectarSQL();
            SqlCommand comando = new SqlCommand("delete from cliente where id = @id", conexao);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            DesconectarSQL();
        }

        public void PopularSQL()
        {
            ConectarSQL();
            SqlCommand comandoconsulta = new SqlCommand("Select * from cliente", conexao);
            SqlDataAdapter adaptador = new SqlDataAdapter(comandoconsulta);
            //DataTable dtPessoas = new DataTable();
            //adaptador.Fill(dtPessoas);

            //DesconectarSQL();

            //grdPessoas.DataSource = dtPessoas;            
        }
    }
}
