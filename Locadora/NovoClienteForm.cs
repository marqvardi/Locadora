using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.DataAccess;
using Locadora.DataAccess.DataAccess;
using Locadora.DataAccess.Entidades;
using System.Transactions;

namespace Locadora
{
    public partial class NovoClienteForm : Form
    {
        public NovoClienteForm()
        {
            InitializeComponent();
        }

        private void LimparFocus()
        {
            txtboxNome.Clear();           
            textBoxClienteComplemento.Clear();
            textBoxClienteLogradouro.Clear();
            textBoxClienteNumeroCasa.Clear();
            dateTimeClienteDOB.ResetText();
            textBoxClienteCEP.Clear();
            textBoxClienteBairro.Clear();
            txtboxNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteDataAccess cn = new ClienteDataAccess();

            Cliente c = new Cliente
            {
                Nome = txtboxNome.Text,
                DataNascimento = dateTimeClienteDOB.Value,
                Ativo = true
            };
            using (var scope = new TransactionScope())
            {
                cn.InsertSQLCliente(c);

                Endereco en = new Endereco(c.Id);

                en.Logradouro = textBoxClienteLogradouro.Text;
                en.Bairro = textBoxClienteBairro.Text;
                en.Cep = textBoxClienteCEP.Text;
                en.Numero = textBoxClienteNumeroCasa.Text;
                en.Complemento = textBoxClienteComplemento.Text;

                cn.InsertSQLEndereco(en);
                scope.Complete();

            }
            MessageBox.Show("Usuario cadastrado com sucesso.", "Aviso:", MessageBoxButtons.OK);

            LimparFocus();
        }
    }
}
