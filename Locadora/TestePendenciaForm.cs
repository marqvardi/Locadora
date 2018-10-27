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
    public partial class TestePendenciaForm : Form
    {
        private Cliente Cliente;

        public TestePendenciaForm(Cliente cliente)
        {
            AlugarDataAccess al = new AlugarDataAccess();
            
            InitializeComponent();
            Cliente = cliente;
            labelNomeCliente.Text = cliente.Nome;
            labelIdCliente.Text = Convert.ToString(cliente.Id);
            
        }      

    }
}
