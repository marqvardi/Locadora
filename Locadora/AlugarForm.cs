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

namespace Locadora
{
    public partial class AlugarForm : Form
    {
        public AlugarForm()
        {
            InitializeComponent();
        }       

        int rowIndex = 0;

        private void dataGridViewAlugar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            rowIndex = e.RowIndex;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            ClienteDataAccess cn = new ClienteDataAccess();

            if (radioButtonPorNome.Checked)
            {
                dataGridViewAlugar.DataSource = cn.PesquisarPorNome(txtBoxPesquisarCliente.Text);
                txtBoxPesquisarCliente.Clear();
            }
            else
            {
                if (txtBoxPesquisarCliente.Text == "" || txtBoxPesquisarCliente.Text == null)
                {
                    return;
                }
                //Tratamento para quando nao insere nada ou nao encontrado
                dataGridViewAlugar.DataSource = cn.PesquisarPorId(Convert.ToInt32(txtBoxPesquisarCliente.Text));
                txtBoxPesquisarCliente.Clear();
            }
        }

        private void dataGridViewAlugar_DoubleClick(object sender, EventArgs e)
        {            
            DataGridViewRow LinhaSelecionada = dataGridViewAlugar.Rows[rowIndex];
            int id = Convert.ToInt32(LinhaSelecionada.Cells[0].FormattedValue);
            ClienteDataAccess da = new ClienteDataAccess();            
            Cliente cliente = da.PesquisarPorId(id);

            TelaAlugarForm tl = new TelaAlugarForm(cliente);
            tl.Show();       

            tl.PuxarNome();           

        }
    }
}
