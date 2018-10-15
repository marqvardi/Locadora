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
        private Cliente _cliente;
        private Aluguel _aluguel;

        private List<Midia> _midiasEncontradas;      

        public TelaAlugarForm(Cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            _midiasEncontradas = new List<Midia>();
            _aluguel = new Aluguel(cliente);            
        }

        public void PuxarNome()
        {            
            ClienteDataAccess cn = new ClienteDataAccess();
            label4.Text = Convert.ToString(_cliente.Id);
            label5.Text = _cliente.Nome;
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            MidiaDataAccess md = new MidiaDataAccess();

           _midiasEncontradas = md.PesquisarPorTitulo(textBoxTituloSearch.Text).ToList();
            dataGridViewAlugar.DataSource = _midiasEncontradas;
            textBoxTituloSearch.Clear();
            textBoxTituloSearch.Focus();
        }

        private void buttonAlugar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confimar o aluguel dos titulos", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            ConfirmacaoAlugarForm cf = new ConfirmacaoAlugarForm(_aluguel);
            cf.Show();

            this.Close();
        }

        int rowIndex = 0;

        private void dataGridViewAlugar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void buttonAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0) return;       
            
            if (_midiasEncontradas[rowIndex].QuantidaDisponivel <= 0)
            {
                MessageBox.Show("Estoque nao disponivel", "Alerta", MessageBoxButtons.OK);
                return;
            }
            if (_aluguel.Items
                .Select(itemAluguel => itemAluguel.Midia)
                .Any(midia => midia.Id  == _midiasEncontradas[rowIndex].Id))
            {
                MessageBox.Show("Item ja incluido", "Alerta", MessageBoxButtons.OK);
            }
            else
            {
                //_midiasEncontradas[rowIndex].QuantidadeAlugada =+ 1;                
                _aluguel.Items.Add(new ItemAluguel(_midiasEncontradas[rowIndex]));               
                dataGridViewListaCarrinho.DataSource = null;
                dataGridViewListaCarrinho.DataSource = _aluguel.Items;
            }
        }
       
    }
}

