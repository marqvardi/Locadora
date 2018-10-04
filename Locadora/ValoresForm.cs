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
    public partial class ValoresForm : Form
    {
        ValoresDataAccess va = new ValoresDataAccess();

        public ValoresForm()
        {
            InitializeComponent();
            //int valor = va.PuxarValorAluguel(1);       
           
            //labelValueAtualAluguel.Text = Convert.ToString(valor);                      
        }
        
        public void Limpartxtbox()
        {
            textBoxValorAluguel.Clear();
            textBoxValorMulta.Clear();
            textBoxValorAluguel.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Valores vl = new Valores();
            MessageBox.Show("Tem certeza que deseja incluir os valores?", "Confirmacao", MessageBoxButtons.OKCancel);
            vl.Id = 1;
            vl.ValorAluguel = Convert.ToDecimal(textBoxValorAluguel.Text);
            vl.ValorMulta = Convert.ToDecimal(textBoxValorMulta.Text);

            va.ValorAluguelMultaNovo(vl);
          
            MessageBox.Show("Mensagem incluida", "Okey baby", MessageBoxButtons.OK);
            Limpartxtbox();
            
            
        }
    }
}
