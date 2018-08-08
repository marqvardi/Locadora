using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Locadora
{
    public partial class Formulario : Form
    {
                        
        public Formulario()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void testeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarNovosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConectarSQLClass cp = new ConectarSQLClass();
            cp.ConectarSQL();
            cp.InsertSQL(txtBoxNome.Text, txtBoxEndereco.Text);
            cp.DesconectarSQL();        

        }
    }
}
