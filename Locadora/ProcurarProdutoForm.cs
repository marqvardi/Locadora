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
    public partial class ProcurarProdutoForm : Form
    {
        public ProcurarProdutoForm()
        {
            InitializeComponent();            
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            MidiaDataAccess md = new MidiaDataAccess();

            if (radioButtonProcurarPorTitulo.Checked)
            {
                dataGridViewProcurarTituloOuCategoria.DataSource = md.PesquisarPorTitulo(textBoxProcurarPorTitulo.Text);
                textBoxProcurarPorTitulo.Clear();
                textBoxProcurarPorTitulo.Focus();
            }
            if (radioButtonProcurarPorCategoria.Checked)
            {
                if (comboBoxProcurarPorCategoria.Text == "") return;
                else
                {
                   //dataGridViewProcurarTituloOuCategoria.DataSource = md.PesquisarPorCategoria(Convert.ToInt32(comboBoxProcurarPorCategoria.Text));
                }

                //string current = (string)comboBoxProcurarPorCategoria.SelectedItem;

                //md.PesquisarPorCategoria(current);
                //md.PesquisarPorCategoria(2);
                
                //dataGridViewProcurarTituloOuCategoria.DataSource = md.PesquisarPorCategoria("Drama");
                comboBoxProcurarPorCategoria.ResetText();
            }
        }

        private void ProcurarProdutoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'samplesDataSet.Midia' table. You can move, or remove it, as needed.
            //this.midiaTableAdapter.Fill(this.samplesDataSet.Midia);

        }
    }
}
