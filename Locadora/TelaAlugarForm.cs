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

        List<Midia> resultados = new List<Midia>();

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
            label4.Text = Convert.ToString(_id);
            label5.Text = _nome;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            MidiaDataAccess md = new MidiaDataAccess();

            dataGridViewAlugar.DataSource = md.PesquisarPorTitulo(textBoxTituloSearch.Text);
            textBoxTituloSearch.Clear();
            textBoxTituloSearch.Focus();            
        }

        private void buttonAlugar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confimar o aluguel dos titulos", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            for (int i = 0; i < dataGridViewAlugar.Rows.Count; i++)
            {
                bool isChecked = (bool)dataGridViewAlugar.Rows[i].Cells[0].Value;
                if (isChecked == true)
                {
                    
                }
            }

            MessageBox.Show("Titulo's' adicinado's' com sucesso.");
            this.Close();
        }        
    }
}

