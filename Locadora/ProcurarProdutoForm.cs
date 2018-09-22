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
                if (comboBoxProcurarPorCategoria.Text == "Drama")
                {
                    md.PesquisarPorCategoria();
                    //dataGridViewProcurarTituloOuCategoria.DataSource = md.PesquisarPorCategoria(comboBoxProcurarPorCategoria.SelectedItem.ToString());
                }
                //dataGridViewProcurarTituloOuCategoria.DataSource = md.PesquisarPorCategoria("Drama");
                comboBoxProcurarPorCategoria.ResetText();
            }
        }

        private void ProcurarProdutoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'samplesDataSet.Midia' table. You can move, or remove it, as needed.
            this.midiaTableAdapter.Fill(this.samplesDataSet.Midia);

        }
    }
}
