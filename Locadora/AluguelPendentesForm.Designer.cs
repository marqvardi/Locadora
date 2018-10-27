namespace Locadora
{
    partial class AluguelPendentesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPendencia = new System.Windows.Forms.ComboBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dgvAluguel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvItensAlugados = new System.Windows.Forms.DataGridView();
            this.IdMidiaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMidiaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDevolucaoCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.IdClienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPrevisaoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMultaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDescontoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorSubTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntregaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagoCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataHoraCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluguel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensAlugados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.AllowUserToAddRows = false;
            this.dgvPesquisar.AllowUserToDeleteRows = false;
            this.dgvPesquisar.AllowUserToOrderColumns = true;
            this.dgvPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnDataNascimento,
            this.clnAtivo});
            this.dgvPesquisar.Location = new System.Drawing.Point(12, 177);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.ReadOnly = true;
            this.dgvPesquisar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisar.Size = new System.Drawing.Size(1282, 224);
            this.dgvPesquisar.TabIndex = 0;
            this.dgvPesquisar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisar_CellClick);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            this.clnNome.DataPropertyName = "Nome";
            this.clnNome.HeaderText = " Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            // 
            // clnDataNascimento
            // 
            this.clnDataNascimento.DataPropertyName = "DataNascimento";
            this.clnDataNascimento.HeaderText = "Data de Nascimento";
            this.clnDataNascimento.Name = "clnDataNascimento";
            this.clnDataNascimento.ReadOnly = true;
            this.clnDataNascimento.Width = 200;
            // 
            // clnAtivo
            // 
            this.clnAtivo.DataPropertyName = "Ativo";
            this.clnAtivo.HeaderText = "Ativo (S/N)";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResultado.Location = new System.Drawing.Point(19, 65);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(887, 20);
            this.textBoxResultado.TabIndex = 2;
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Checked = true;
            this.radioButtonNome.Location = new System.Drawing.Point(19, 29);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(70, 17);
            this.radioButtonNome.TabIndex = 3;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Por nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(114, 29);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(55, 17);
            this.radioButtonID.TabIndex = 4;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "Por ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxPendencia);
            this.groupBox1.Controls.Add(this.buttonPesquisar);
            this.groupBox1.Controls.Add(this.textBoxResultado);
            this.groupBox1.Controls.Add(this.radioButtonID);
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes:";
            // 
            // comboBoxPendencia
            // 
            this.comboBoxPendencia.FormattingEnabled = true;
            this.comboBoxPendencia.Items.AddRange(new object[] {
            "Atrasado",
            "Em dia"});
            this.comboBoxPendencia.Location = new System.Drawing.Point(785, 99);
            this.comboBoxPendencia.Name = "comboBoxPendencia";
            this.comboBoxPendencia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPendencia.TabIndex = 6;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPesquisar.Location = new System.Drawing.Point(687, 99);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 5;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dgvAluguel
            // 
            this.dgvAluguel.AllowUserToAddRows = false;
            this.dgvAluguel.AllowUserToDeleteRows = false;
            this.dgvAluguel.AllowUserToOrderColumns = true;
            this.dgvAluguel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluguel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.DataHoraCol,
            this.PagoCol,
            this.DataEntregaCol,
            this.StatusCol,
            this.ValorSubTotalCol,
            this.ValorDescontoCol,
            this.ValorMultaCol,
            this.ValorTotalCol,
            this.DataPrevisaoCol,
            this.IdClienteCol});
            this.dgvAluguel.Location = new System.Drawing.Point(12, 430);
            this.dgvAluguel.Name = "dgvAluguel";
            this.dgvAluguel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluguel.Size = new System.Drawing.Size(1282, 221);
            this.dgvAluguel.TabIndex = 6;
            this.dgvAluguel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluguel_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alugueis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Itens alugados:";
            // 
            // dgvItensAlugados
            // 
            this.dgvItensAlugados.AllowUserToAddRows = false;
            this.dgvItensAlugados.AllowUserToDeleteRows = false;
            this.dgvItensAlugados.AllowUserToOrderColumns = true;
            this.dgvItensAlugados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItensAlugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensAlugados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMidiaCol,
            this.NomeMidiaCol,
            this.QtdCol,
            this.StatusDevolucaoCol});
            this.dgvItensAlugados.Location = new System.Drawing.Point(12, 682);
            this.dgvItensAlugados.Name = "dgvItensAlugados";
            this.dgvItensAlugados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensAlugados.Size = new System.Drawing.Size(1282, 161);
            this.dgvItensAlugados.TabIndex = 10;
            // 
            // IdMidiaCol
            // 
            this.IdMidiaCol.DataPropertyName = "Id_Midia";
            this.IdMidiaCol.HeaderText = "ID da Midia";
            this.IdMidiaCol.Name = "IdMidiaCol";
            // 
            // NomeMidiaCol
            // 
            this.NomeMidiaCol.DataPropertyName = "NomeMidia";
            this.NomeMidiaCol.HeaderText = "Nome da Midia";
            this.NomeMidiaCol.Name = "NomeMidiaCol";
            // 
            // QtdCol
            // 
            this.QtdCol.DataPropertyName = "Quantidade";
            this.QtdCol.HeaderText = "Quantidade";
            this.QtdCol.Name = "QtdCol";
            // 
            // StatusDevolucaoCol
            // 
            this.StatusDevolucaoCol.DataPropertyName = "StatusDevolucao";
            this.StatusDevolucaoCol.HeaderText = "Devolver? (S/N)";
            this.StatusDevolucaoCol.Name = "StatusDevolucaoCol";
            this.StatusDevolucaoCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusDevolucaoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdClienteCol
            // 
            this.IdClienteCol.DataPropertyName = "IdCliente";
            this.IdClienteCol.HeaderText = "ID do cliente";
            this.IdClienteCol.Name = "IdClienteCol";
            this.IdClienteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdClienteCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataPrevisaoCol
            // 
            this.DataPrevisaoCol.DataPropertyName = "DataPrevisaoEntrega";
            this.DataPrevisaoCol.HeaderText = "Previsao de entrega";
            this.DataPrevisaoCol.Name = "DataPrevisaoCol";
            this.DataPrevisaoCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataPrevisaoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValorTotalCol
            // 
            this.ValorTotalCol.DataPropertyName = "ValorTotal";
            this.ValorTotalCol.HeaderText = "Valor Total";
            this.ValorTotalCol.Name = "ValorTotalCol";
            this.ValorTotalCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValorTotalCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValorMultaCol
            // 
            this.ValorMultaCol.DataPropertyName = "ValorMulta";
            this.ValorMultaCol.HeaderText = "Valor da multa";
            this.ValorMultaCol.Name = "ValorMultaCol";
            this.ValorMultaCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValorMultaCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValorDescontoCol
            // 
            this.ValorDescontoCol.DataPropertyName = "ValorDesconto";
            this.ValorDescontoCol.HeaderText = "Valor do desconto";
            this.ValorDescontoCol.Name = "ValorDescontoCol";
            this.ValorDescontoCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValorDescontoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValorSubTotalCol
            // 
            this.ValorSubTotalCol.DataPropertyName = "ValorSubTotal";
            this.ValorSubTotalCol.HeaderText = "Valor SubTotal";
            this.ValorSubTotalCol.Name = "ValorSubTotalCol";
            this.ValorSubTotalCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValorSubTotalCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StatusCol
            // 
            this.StatusCol.DataPropertyName = "Status";
            this.StatusCol.HeaderText = "Status";
            this.StatusCol.Name = "StatusCol";
            this.StatusCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataEntregaCol
            // 
            this.DataEntregaCol.DataPropertyName = "DataEntrega";
            this.DataEntregaCol.HeaderText = "Data da Entrega";
            this.DataEntregaCol.Name = "DataEntregaCol";
            this.DataEntregaCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataEntregaCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PagoCol
            // 
            this.PagoCol.DataPropertyName = "Pago";
            this.PagoCol.HeaderText = "Pago";
            this.PagoCol.Name = "PagoCol";
            // 
            // DataHoraCol
            // 
            this.DataHoraCol.DataPropertyName = "DataHora";
            this.DataHoraCol.HeaderText = "Data da locacao";
            this.DataHoraCol.Name = "DataHoraCol";
            // 
            // IdCol
            // 
            this.IdCol.DataPropertyName = "Id";
            this.IdCol.HeaderText = "ID Transacao";
            this.IdCol.Name = "IdCol";
            // 
            // AluguelPendentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 855);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvItensAlugados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAluguel);
            this.Controls.Add(this.dgvPesquisar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AluguelPendentesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel Pendente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluguel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensAlugados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView dgvAluguel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvItensAlugados;
        private System.Windows.Forms.ComboBox comboBoxPendencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataNascimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMidiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMidiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusDevolucaoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntregaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorSubTotalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDescontoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMultaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPrevisaoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClienteCol;
    }
}