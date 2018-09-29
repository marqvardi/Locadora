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
                int id = 0;
                if (comboBoxProcurarPorCategoria.Text == "Suspense")
                {
                    id = 0;                    
                }
                if (comboBoxProcurarPorCategoria.Text == "Terror")
                {
                    id = 1;
                }
                if (comboBoxProcurarPorCategoria.Text == "Acao")
                {
                    id = 2;
                }
                if (comboBoxProcurarPorCategoria.Text == "Comedia")
                {
                    id = 3;
                }
                if (comboBoxProcurarPorCategoria.Text == "Aventura")
                {
                    id = 4;
                }
                else
                {
                    return;
                }
                md.PesquisarPorCategoria(id);
                //dataGridViewProcurarTituloOuCategoria.DataSource = md.PesquisarPorCategoria(comboBoxProcurarPorCategoria.SelectedItem.ToString());

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
