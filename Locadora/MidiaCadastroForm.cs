using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
                                
            MidiaDataAccess md = new MidiaDataAccess();
            Midia m = new Midia();
            Categoria c = new Categoria();

            if (comboBoxCadastroCategoria.Text == "Suspense")
            {
                c.Id = 0;
                c.Nome = Convert.ToString(TipoDeCategoria.Suspense);
            }
            if (comboBoxCadastroCategoria.Text == "Terror")
            {
                c.Id = Convert.ToInt32(TipoDeCategoria.Terror);
                c.Nome = "Terror";
            }
            if (comboBoxCadastroCategoria.Text == "Acao")
            {
                c.Id = Convert.ToInt32(TipoDeCategoria.Acao);
                c.Nome = "Acao";
            }
            if (comboBoxCadastroCategoria.Text == "Comedia")
            {
                c.Id = Convert.ToInt32(TipoDeCategoria.Comedia);
                c.Nome = "Comedia";                
            }
            if (comboBoxCadastroCategoria.Text == "Aventura")
            {
                c.Id = Convert.ToInt32(TipoDeCategoria.Aventura);
                c.Nome = "Aventura";
            }
            c.Ativo = true;

            m.Titulo = textBoxCadastroTitulo.Text;
            m.QuantidadeComprada = Convert.ToInt32(textBoxCadastroQuantidade.Text);
            if (comboBoxCadastroMidia.Text == "Blueray")
            {                
                m.TipoMidia = TiposMidia.Blueray;
                m.Id_categoria = c.Id;
            }
            if (comboBoxCadastroMidia.Text == "DVD")
            {
                m.TipoMidia = TiposMidia.DVD;
                m.Id_categoria = c.Id;
            }
            if (comboBoxCadastroMidia.Text == "VHS")
            {
                m.TipoMidia = TiposMidia.VHS;
                m.Id_categoria = c.Id;                
            }
           
            md.InsertSQLMidia(m);

            MessageBox.Show("Produto incluido com sucesso!", "Confirmacao", MessageBoxButtons.OK);
         
            LimparFocus();
            
        }
    }
}
