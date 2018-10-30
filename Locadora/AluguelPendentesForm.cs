using Locadora.DataAccess.DataAccess;
using Locadora.DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Locadora
{
    public partial class AluguelPendentesForm : Form
    {
        int rowIndexCliente;
        int rowIndexAluguel;

        private Cliente clienteCorrente;
        private List<Cliente> resultados;

        private Aluguel aluguelCorrente;      

        public AluguelPendentesForm()
        {
            InitializeComponent();
            comboBoxPendencia.Text = "Atrasado";
            dgvItensAlugados.AutoGenerateColumns = false;
            dgvAluguel.AutoGenerateColumns = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AlugarDataAccess al = new AlugarDataAccess();
            resultados = new List<Cliente>();
            resultados = al.PesquisarPorPendencia(textBoxResultado.Text, comboBoxPendencia.Text).ToList();

            dgvPesquisar.DataSource = resultados;
            dgvAluguel.DataSource = null;
            dgvItensAlugados.DataSource = null;
        }

        private void dgvPesquisar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            rowIndexCliente = e.RowIndex;
            clienteCorrente = resultados[rowIndexCliente];

            dgvAluguel.DataSource = null;
            dgvAluguel.DataSource = clienteCorrente.Alugueis;
            dgvItensAlugados.DataSource = null;
        }      

        private void dgvAluguel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            rowIndexAluguel = e.RowIndex;
            aluguelCorrente = clienteCorrente.Alugueis[rowIndexAluguel];            

            dgvItensAlugados.DataSource = null;
            dgvItensAlugados.DataSource = aluguelCorrente.Items;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult men = MessageBox.Show("Deseja mesmo devolver?", "Alerta", MessageBoxButtons.OKCancel);
            if (men == DialogResult.Cancel) return;

            foreach (DataGridViewRow row in dgvItensAlugados.Rows)
            {
                DataGridViewCheckBoxCell celula = (DataGridViewCheckBoxCell)row.Cells[StatusDevolucaoCol.Name];
                aluguelCorrente.Items[row.Index].StatusDevolucao = Convert.ToBoolean(celula.Value);             
            }     

            AlugarDataAccess alugarDataAccess = new AlugarDataAccess();
            alugarDataAccess.DevolverAluguel(aluguelCorrente);
            dgvItensAlugados.DataSource = null;
            dgvAluguel.DataSource = null;
        }
    }
}
