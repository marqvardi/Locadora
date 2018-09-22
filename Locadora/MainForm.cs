using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Locadora
{
    public partial class Formulario : Form
    {

        public Formulario()
        {
            InitializeComponent();           
        }
        
        private NovoClienteForm _novoClienteForm;
        private PesquisarClienteForm _pesquisarClienteForm;       
        private MidiaCadastroForm _midiaDVDForm;
        private ProcurarProdutoForm _procurarProdutoForm;
        private AlugarForm _alugarForm;
        private SetPrecoForm _setPrecoForm;
        
        private void cadastrarNovosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_novoClienteForm == null || _novoClienteForm.IsDisposed)
            {
                _novoClienteForm = new NovoClienteForm
                {
                    MdiParent = this
                };
                //_novoClienteForm.MdiParent = this;
                _novoClienteForm.Show();
            }
            else
            {
                _novoClienteForm.Focus();
            }
                    
        }
        
        private void procurarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_pesquisarClienteForm  == null || _pesquisarClienteForm.IsDisposed)
            {
                _pesquisarClienteForm = new PesquisarClienteForm
                {
                    MdiParent = this
                };
                _pesquisarClienteForm.Show();
            }
            else
            {
                _pesquisarClienteForm.Focus();
            }              

        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_midiaDVDForm == null || _midiaDVDForm.IsDisposed)
            {
                _midiaDVDForm = new MidiaCadastroForm
                {
                    MdiParent = this
                };
                _midiaDVDForm.Show();
            }
            else
            {
                _midiaDVDForm.Focus();
            }
        }

        private void procurarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_procurarProdutoForm == null || _procurarProdutoForm.IsDisposed)
            {
                _procurarProdutoForm = new ProcurarProdutoForm
                {
                    MdiParent = this
                };
                _procurarProdutoForm.Show();
            }
            else
            {
                _procurarProdutoForm.Focus();
            }
        }

        private void alugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_alugarForm == null || _alugarForm.IsDisposed)
            {
                _alugarForm = new AlugarForm
                {
                    MdiParent = this
                };
                _alugarForm.Show();
            }
            else
            {
                _alugarForm.Focus();

            }
        }        

        private void setPrecoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_setPrecoForm == null || _setPrecoForm.IsDisposed)
            {
                _setPrecoForm = new SetPrecoForm
                {
                    MdiParent = this
                };
                _setPrecoForm.Show();
            }
            else
            {
                _setPrecoForm.Focus();
            }
        }


}
}
