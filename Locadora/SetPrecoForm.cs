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
    public partial class SetPrecoForm : Form
    {
        public SetPrecoForm()
        {
            InitializeComponent();
        }

        private decimal PrecoAluguel = 0;

        private void buttonSetPreco_Click(object sender, EventArgs e)
        {
            textBoxSetPreco.Focus();
            DialogResult resultado = MessageBox.Show("Confirma o preco do aluguel?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No) return;
            
            PrecoAluguel = Convert.ToDecimal(textBoxSetPreco.Text);
            textBoxSetPreco.Clear();

            MessageBox.Show(Convert.ToString(PrecoAluguel)); // Como adicionar um texto e + o valor adicionado
            
        }
    }
}
