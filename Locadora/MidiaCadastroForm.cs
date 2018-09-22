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
    public partial class MidiaCadastroForm : Form
    {
        public MidiaCadastroForm()
        {
            InitializeComponent();
        }

        private void LimparFocus()
        {
            textBoxCadastroQuantidade.Clear();
            textBoxCadastroTitulo.Clear();
            textBoxCadastroTitulo.Focus();
            comboBoxCadastroCategoria.ResetText();
            comboBoxCadastroMidia.ResetText();

        }

        private void buttonProdutoCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirma a inclusao do Titulo?", "Confirmacao", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No) return; 
            
            //Perguntar sobre deixar TAB nos comboBoxes
            

            MidiaDataAccess md = new MidiaDataAccess();
            Midia m = new Midia();
            m.Titulo = textBoxCadastroTitulo.Text;
            m.Quantidade = Convert.ToInt32(textBoxCadastroQuantidade.Text);
           // m.Categoria = comboBoxCadastroCategoria.Text;
           // m.TipoMidia = comboBoxCadastroMidia.Text;
            md.InsertSQLMidia(m);

            LimparFocus();
            
        }
    }
}
