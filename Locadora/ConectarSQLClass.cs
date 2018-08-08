using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Locadora
{
    class ConectarSQLClass
    {
            public ConectarSQLClass()
            {
                conexao = new SqlConnection(CONNECTION_STRING);
            }
            private const string CONNECTION_STRING = "Data Source=DESKTOP-0T43HD8\\SQLEXPRESS;Initial Catalog=Samples;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conexao = null;

            public void ConectarSQL()
            {
               conexao.Open();
            }

            public void DesconectarSQL()
            {
                conexao.Close();
                conexao.Dispose();
            }

            public void InsertSQL(string nome, string endereco)
            {
                
                SqlCommand comando = new SqlCommand("insert into Cliente(Nome, Endereco) values (@nome, @endereco)", conexao);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@endereco", endereco);
                
                comando.ExecuteNonQuery();
            }



            public void UpdateSQL()
            {
                SqlCommand comando = new SqlCommand("update Pessoas set Nome = @nome, idade = @idade where id = @id", conexao);
                //comando.Parameters.AddWithValue("@nome", txtnome.Text);
                //comando.Parameters.AddWithValue("@idade", txtidade.Text);
                //comando.Parameters.AddWithValue("@id", _id);

                comando.ExecuteNonQuery();
            }

            public void DeletarSQL()
            {
                SqlCommand comando = new SqlCommand("delete from Pessoas where id = @id", conexao);
                //comando.Parameters.AddWithValue("@id", _id);

                comando.ExecuteNonQuery();
            }

            public void PopularSQL()
            {
                SqlCommand comandoconsulta = new SqlCommand("Select id , Nome, Idade from Pessoas", conexao);
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoconsulta);
                //System.Data.DataTable dtPessoas = new DataTable();
                //adaptador.Fill(dtPessoas);


                //grdPessoas.DataSource = dtPessoas;

                //txtnome.Focus();
                //txtnome.Clear();
                //txtidade.Clear();
            }

            public void Limpar(string nome, int idade)
            {
                //txtnome.Focus(); Como fazer pois nao tem esse metodos de windows form aqui.
                //txtnome.Clear();
                //txtidade.Clear();
            }        
    }
}
