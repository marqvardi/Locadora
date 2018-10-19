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
        int rowIndex;
        private Cliente clienteCorrente;
        private List<Cliente> resultados;      

        public AluguelPendentesForm()
        {
            InitializeComponent();
        }
        
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AlugarDataAccess al = new AlugarDataAccess();
            resultados = new List<Cliente>();

            resultados = al.PesquisarPorPendencia(textBoxResultado.Text, "").ToList();
            dgvPesquisar.DataSource = resultados;

            //resultados = al.PesquisarPorPendencia(textBoxResultado.Text, "").ToList();
            //dgvPesquisar.DataSource = resultados;


        }

        private void dgvPesquisar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            rowIndex = e.RowIndex;
            clienteCorrente = resultados[rowIndex];

            dgvAluguel.DataSource = clienteCorrente.Alugueis;
        }

        private void dgvAluguel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlugarDataAccess al = new AlugarDataAccess();

            if (e.RowIndex < 0) return;
            rowIndex = e.RowIndex;
            clienteCorrente = resultados[rowIndex];
            
            dgvItensAlugados.DataSource = clienteCorrente.ItemAluguel;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
