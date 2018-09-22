using Locadora.DataAccess.DataAccess;
using Locadora.DataAccess.Entidades;
using System;
using System.Windows.Forms;
using System.Data.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace Locadora
{
    public partial class PesquisarClienteForm : Form
    {
        public PesquisarClienteForm()
        {
            InitializeComponent();
        }

        private List<Cliente> resultados;
        private Cliente clienteCorrente;

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            resultados = new List<Cliente>();
            ClienteDataAccess cn = new ClienteDataAccess();

            if (radioButtonPorNome.Checked)
            {
                //Explicar por que ele lista todos os itens digitados e nao apenas a primeira occorencia? ToList()?
                resultados = cn.PesquisarPorNome(txtBoxPesquisarCliente.Text).ToList();
                dataGridViewPesquisarCliente.DataSource = resultados;
                txtBoxPesquisarCliente.Clear();
            }
            else
            {
                if (txtBoxPesquisarCliente.Text == "") return;
                else
                {
                    dataGridViewPesquisarCliente.DataSource = cn.PesquisarPorId(Convert.ToInt32(txtBoxPesquisarCliente.Text));
                    txtBoxPesquisarCliente.Clear();
                }
            }
        }

       
        private void dataGridViewPesquisarCliente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow LinhaSelecionada = dataGridViewPesquisarCliente.Rows[e.RowIndex];

          
            clienteCorrente.Id = Convert.ToInt32(LinhaSelecionada.Cells[0].FormattedValue);
            clienteCorrente.Nome = LinhaSelecionada.Cells[1].FormattedValue.ToString();
            clienteCorrente.DataNascimento = Convert.ToDateTime(LinhaSelecionada.Cells[2].FormattedValue.ToString());           

            ClienteDataAccess cn = new ClienteDataAccess();

            cn.UpdateSQLCliente(clienteCorrente);
            
        }

        private void dgvEndereco_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow LinhaSelecionada = dgvEndereco.Rows[e.RowIndex];
            Endereco enderecoCorrente = clienteCorrente.Enderecos[e.RowIndex];

          

            enderecoCorrente.Logradouro = LinhaSelecionada.Cells[1].FormattedValue.ToString();
            enderecoCorrente.Id = Convert.ToInt32(LinhaSelecionada.Cells[2].FormattedValue);
            enderecoCorrente.Bairro = LinhaSelecionada.Cells[3].FormattedValue.ToString();
            enderecoCorrente.Cep = LinhaSelecionada.Cells[4].FormattedValue.ToString();
            enderecoCorrente.Numero = LinhaSelecionada.Cells[5].FormattedValue.ToString();
            enderecoCorrente.Complemento = LinhaSelecionada.Cells[6].FormattedValue.ToString();

            ClienteDataAccess cn = new ClienteDataAccess();
            cn.UpdateSQLEndereco(enderecoCorrente);

        }


        int rowIndex = 0;

        private void dataGridViewPesquisarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            rowIndex = e.RowIndex;
            clienteCorrente = resultados[rowIndex];

            dgvEndereco.DataSource = clienteCorrente.Enderecos;  //Doideira esse caminho, explicar melhor. "ponto" endereco que e' complciado entender.          

            //MessageBox.Show("Confirmacao para apagar usuario?", "ATENCAO", MessageBoxButtons.YesNo);
        }

        private void buttonDeletarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmacao para apagar usuario?", "ATENCAO", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No) return;

            DataGridViewRow LinhaSelecionada = dataGridViewPesquisarCliente.Rows[rowIndex];
            int id = Convert.ToInt32(LinhaSelecionada.Cells[0].FormattedValue);

            //dataGridViewPesquisarCliente.Rows.Remove(LinhaSelecionada);
            ClienteDataAccess cn = new ClienteDataAccess();
            
            cn.DeletarSQL(id);
            
            dataGridViewPesquisarCliente.DataSource = cn.PesquisarPorNome("");
        }

       
        //private void dataGridViewPesquisarCliente_DoubleClick(object sender, EventArgs e)
        //{
        //    DataGridViewRow LinhaSelecionada = dataGridViewPesquisarCliente.Rows[rowIndex];
        //    int id = Convert.ToInt32(LinhaSelecionada.Cells[0].FormattedValue);
        //    string nome = (LinhaSelecionada.Cells[1].FormattedValue).ToString();

        //    TelaAlugarForm tl = new TelaAlugarForm(id, nome);
        //    tl.Show();
        //    //Como fazer para o formulario de pesquisar cliente fique inacessivel?

        //    tl.PuxarNome1();


        //}
    }
}
