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
    public partial class ConfirmacaoAluguelForm : Form
    {
        public ConfirmacaoAluguelForm()
        {
            InitializeComponent();
        }

        public ConfirmacaoAluguelForm(int idCliente, List<int> carrinho)
        {
            int _idCliente = idCliente;
            List<int> Carrinho = carrinho;          
            //labelIdCliente.Text = Convert.ToString(_idCliente);           
        }   


    }
}
