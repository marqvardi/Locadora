﻿using System;
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
    public partial class ConfirmacaoAlugarForm : Form
    {
        public ConfirmacaoAlugarForm(int idCliente, List<int> carrinho)
        {
            InitializeComponent();
        }
    }
}
