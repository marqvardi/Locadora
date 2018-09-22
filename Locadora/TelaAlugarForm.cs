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
using Locadora.DataAccess;

namespace Locadora
{
    public partial class TelaAlugarForm : Form
    {
        private int _id;
        private string _nome;

        //public TelaAlugarForm()
        //{
        //    InitializeComponent();
        //}

        public TelaAlugarForm(int id, string nome)
        {
            InitializeComponent();
            _id = id;
            _nome = nome;
        }

        public void PuxarNome()
        {
            ClienteDataAccess cn = new ClienteDataAccess();
            dataGridViewAlugar.DataSource = cn.AlugarPorId(_id);

            //labelID.Text = Convert.ToString(cn.PesquisarPorId(_id));
            //textBoxId.Text = Convert.ToString(cn.PesquisarPorId(_id));
        }

        public void PuxarNome1()
        {
            ClienteDataAccess cn = new ClienteDataAccess();
            //dataGridView1.DataSource = cn.AlugarPorId(_id);
            label4.Text = Convert.ToString(_id);
            label5.Text = _nome;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            MidiaDataAccess md = new MidiaDataAccess();

            dataGridViewAlugar.DataSource = md.PesquisarPorTitulo(textBoxTituloSearch.Text);
        }

        private void buttonAlugar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confimar o aluguel dos titulos", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            MessageBox.Show("Titulo's' adicinado's' com sucesso.");
        }
    }
}

