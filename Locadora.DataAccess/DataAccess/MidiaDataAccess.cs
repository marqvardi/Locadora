using Dapper;
using Locadora.DataAccess.Entidades;
using System.Collections.Generic;

namespace Locadora.DataAccess.DataAccess
{
    public class MidiaDataAccess : DataAccessBase
    {
        public void InsertSQLMidia(Midia midia)
        {
            ConectarSQL();
            conexao.Execute("insert into midia (Titulo, quantidade, categoria, tipomidia) values (@Titulo, @quantidade, @categoria, @tipomidia)", midia);
            DesconectarSQL();
        }

        public IEnumerable<Midia> PesquisarPorTitulo(string titulo)
        {
            ConectarSQL();
            IEnumerable<Midia> resultados = conexao.Query<Midia>("select * from Midia where Titulo like @titulo", new { titulo = $"%{titulo}%" });
            DesconectarSQL();

            return resultados;
        }

        public IEnumerable<Midia> PesquisarPorCategoria()
        {
            ConectarSQL();
            IEnumerable<Midia> resultados = conexao.Query<Midia>("select categoria from Midia where categoria = 'Drama'");
            DesconectarSQL();

            return resultados;
        }

        public void TituloAlugado(int idCliente, int idTitulo)
        {

        }

        //public string PesquisarPorCategoria(string cat)
        //{
        //    ConectarSQL();
        //    //IEnumerable<Midia> resultados = conexao.Query<Midia>("select * from Midia where categoria like @categoria");
        //    //IEnumerable<Midia> resultados = conexao.Query<Midia>("select Categoria from Midia where categoria  like @drama", cat);
        //    //string resultados = conexao.Query("select Categoria from Midia where categoria =", cat).ToString();

        //    DesconectarSQL();

        //    return resultados;
        //}
    }
}
