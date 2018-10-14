using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.DataAccess.Entidades;
using Locadora.DataAccess.DataAccess;

namespace Locadora
{
    public partial class ConfirmacaoAlugarForm : Form
    {
        private Aluguel _aluguel;

        public ConfirmacaoAlugarForm(Aluguel aluguel)
        {
            InitializeComponent();
            _aluguel = aluguel;
            labelIDCliente.Text = aluguel.Cliente.Id.ToString();
            labelValorSubtotal.Text = aluguel.ValorSubTotal.ToString("C2"); 
            labelValorDesconto.Text = aluguel.ValorDesconto.ToString("C2"); 
            labelValorMulta.Text = aluguel.ValorMulta.ToString("C2");
            labelValorTotal.Text = aluguel.ValorTotal.ToString("C2");

            dgvConfirmar.DataSource = aluguel.Items;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("","", MessageBoxButtons.OKCancel);
            if (result == DialogResult.No ) return;        

            AlugarDataAccess inserirAluguel = new AlugarDataAccess();
            inserirAluguel.InserirAluguel(_aluguel);

            MessageBox.Show("Aluguel incluido com sucesso.","Informacao.", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
