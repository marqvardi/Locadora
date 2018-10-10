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
        private List<int> _CarrinhoId_Midia;
        private List<string> _CarrinhoNomeFilme;

        private List<ItemAluguel> ListaItemAluguel = new List<ItemAluguel>();

        Aluguel al = new Aluguel();

        public ConfirmacaoAlugarForm(int idCliente, List<int> carrinhoId_Midia, List<string> carrinhoNomeFilme)
        {
            InitializeComponent();
            al.Id_cliente = idCliente;
            labelIDCliente.Text = Convert.ToString(al.Id_cliente);
            labelValorSubtotal.Text = "0";
            labelValorDesconto.Text = "0";
            labelValorMulta.Text = "0";
            labelValorTotal.Text = "0";

            _CarrinhoId_Midia = carrinhoId_Midia;
            _CarrinhoNomeFilme = carrinhoNomeFilme;

            DataTable dt = new DataTable();
            dt.Columns.Add("IdMidia");
            dt.Columns.Add("Nome do filme");         

            for (int i = 0; i < _CarrinhoId_Midia.Count; i++)
            {
                dt.Rows.Add(_CarrinhoId_Midia[i], _CarrinhoNomeFilme[i]);
            }

            dgvConfirmar.DataSource = dt;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            al.DataHora = DateTime.Now;
            al.ValorSubTotal = 0;
            al.ValorMulta = 0;
            al.ValorDesconto = 0;
            //al.ValorTotal = 0;
            al.Pago = false;
            al.DataPrevisaoEntrega = DateTime.Now.AddDays(1);
            //al.Status = ??

            AlugarDataAccess inserirAluguel = new AlugarDataAccess();
            inserirAluguel.InserirAluguel(al, _CarrinhoId_Midia);
        }
    }
}
