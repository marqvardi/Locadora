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
        public AluguelPendentesForm()
        {
            InitializeComponent();
        }

        private List<Cliente> resultados;

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            ClienteDataAccess cd = new ClienteDataAccess();
            if (textBoxResultado.Text == null || textBoxResultado.Text == "") return;

            if (radioButtonNome.Checked)
            {          
                //resultados = cd.PesquisarPorNomePendente(textBoxResultado.Text).ToList();
                dgvPesquisar.DataSource = resultados;
                textBoxResultado.Clear();

            }
            if (radioButtonID.Checked)
            {

                //dgvPesquisar.DataSource = cd.PesquisarPorIdPendente(Convert.ToInt32(textBoxResultado.Text));
                textBoxResultado.Clear();
            }
        }
    }
}
