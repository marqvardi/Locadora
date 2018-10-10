using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.DataAccess.DataAccess;
using Locadora.DataAccess.Entidades;
using Locadora.DataAccess;

namespace Locadora
{
    public partial class TelaAlugarForm : Form
    {
        private int _id;
        private string _nome;               

        //public TelaAlugarForm()
        //{
        //    InitializeComponent();
        //}

        public TelaAlugarForm(int id, string nome)
        {
            InitializeComponent();
            _id = id;
            _nome = nome;           
        }

        public void PuxarNome()
        {
            ClienteDataAccess cn = new ClienteDataAccess();
            label4.Text = Convert.ToString(_id);
            label5.Text = _nome;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            MidiaDataAccess md = new MidiaDataAccess();

            dataGridViewAlugar.DataSource = md.PesquisarPorTitulo(textBoxTituloSearch.Text);
            textBoxTituloSearch.Clear();
            textBoxTituloSearch.Focus();            
        }

        private void buttonAlugar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confimar o aluguel dos titulos", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            ConfirmacaoAlugarForm cf = new ConfirmacaoAlugarForm(_id, CarrinhoId_Midia, CarrinhoNomeFilme);
            cf.Show();

            this.Close();
        }              

        int rowIndex = 0;

        private void dataGridViewAlugar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        List<int> CarrinhoId_Midia = new List<int>();
        List<string> CarrinhoNomeFilme = new List<string>();

        DataTable dt = new DataTable();

        private void buttonAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0) return;
            DataGridViewRow LinhaSelecionada = dataGridViewAlugar.Rows[rowIndex];
            int checarQuantidadeEstoque = Convert.ToInt32(LinhaSelecionada.Cells[4].FormattedValue.ToString());

            if (checarQuantidadeEstoque <= 0)
            {
                MessageBox.Show("Estoque nao disponivel", "Alerta", MessageBoxButtons.OK);
                return;
            }
            else
            {
                int idMidia = Convert.ToInt16(LinhaSelecionada.Cells[0].FormattedValue.ToString());
                string NomeFilme = (LinhaSelecionada.Cells[1].FormattedValue.ToString());

                if (dt.Columns.Count <= 0)
                {
                    dt.Columns.Add("IdMidia");
                    dt.Columns.Add("Nome do Filme");
                }
                
                if (CarrinhoId_Midia.Contains(idMidia))
                {
                    MessageBox.Show("Item ja adicionado", "Alerta", MessageBoxButtons.OK);
                    return;
                }
                
                dt.Rows.Add(idMidia, NomeFilme);

                CarrinhoId_Midia.Add(idMidia);
                CarrinhoNomeFilme.Add(NomeFilme);
                            
                dataGridViewListaCarrinho.DataSource = dt;
            }
        }
       
    }
}

