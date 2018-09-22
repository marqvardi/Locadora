namespace Locadora
{
    partial class PesquisarClienteForm
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
            this.components = new System.ComponentModel.Container();
            this.grpBoxPesquisaDeCliente = new System.Windows.Forms.GroupBox();
            this.buttonDeletarUsuario = new System.Windows.Forms.Button();
            this.radioButtonPorID = new System.Windows.Forms.RadioButton();
            this.radioButtonPorNome = new System.Windows.Forms.RadioButton();
            this.txtBoxPesquisarCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.dataGridViewPesquisarCliente = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBoxPesquisaDeCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxPesquisaDeCliente
            // 
            this.grpBoxPesquisaDeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxPesquisaDeCliente.Controls.Add(this.buttonDeletarUsuario);
            this.grpBoxPesquisaDeCliente.Controls.Add(this.radioButtonPorID);
            this.grpBoxPesquisaDeCliente.Controls.Add(this.radioButtonPorNome);
            this.grpBoxPesquisaDeCliente.Controls.Add(this.txtBoxPesquisarCliente);
            this.grpBoxPesquisaDeCliente.Controls.Add(this.btnPesquisarCliente);
            this.grpBoxPesquisaDeCliente.Location = new System.Drawing.Point(12, 12);
            this.grpBoxPesquisaDeCliente.Name = "grpBoxPesquisaDeCliente";
            this.grpBoxPesquisaDeCliente.Size = new System.Drawing.Size(1093, 112);
            this.grpBoxPesquisaDeCliente.TabIndex = 11;
            this.grpBoxPesquisaDeCliente.TabStop = false;
            this.grpBoxPesquisaDeCliente.Text = "Pesquisa de cliente";
            // 
            // buttonDeletarUsuario
            // 
            this.buttonDeletarUsuario.Location = new System.Drawing.Point(19, 83);
            this.buttonDeletarUsuario.Name = "buttonDeletarUsuario";
            this.buttonDeletarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletarUsuario.TabIndex = 4;
            this.buttonDeletarUsuario.Text = "Apagar";
            this.buttonDeletarUsuario.UseVisualStyleBackColor = true;
            this.buttonDeletarUsuario.Click += new System.EventHandler(this.buttonDeletarUsuario_Click);
            // 
            // radioButtonPorID
            // 
            this.radioButtonPorID.AutoSize = true;
            this.radioButtonPorID.Location = new System.Drawing.Point(110, 19);
            this.radioButtonPorID.Name = "radioButtonPorID";
            this.radioButtonPorID.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPorID.TabIndex = 3;
            this.radioButtonPorID.TabStop = true;
            this.radioButtonPorID.Text = "Por ID";
            this.radioButtonPorID.UseVisualStyleBackColor = true;
            // 
            // radioButtonPorNome
            // 
            this.radioButtonPorNome.AutoSize = true;
            this.radioButtonPorNome.Checked = true;
            this.radioButtonPorNome.Location = new System.Drawing.Point(19, 20);
            this.radioButtonPorNome.Name = "radioButtonPorNome";
            this.radioButtonPorNome.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPorNome.TabIndex = 2;
            this.radioButtonPorNome.TabStop = true;
            this.radioButtonPorNome.Text = "Por nome";
            this.radioButtonPorNome.UseVisualStyleBackColor = true;
            // 
            // txtBoxPesquisarCliente
            // 
            this.txtBoxPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPesquisarCliente.Location = new System.Drawing.Point(19, 52);
            this.txtBoxPesquisarCliente.Name = "txtBoxPesquisarCliente";
            this.txtBoxPesquisarCliente.Size = new System.Drawing.Size(933, 20);
            this.txtBoxPesquisarCliente.TabIndex = 1;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(979, 52);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(95, 23);
            this.btnPesquisarCliente.TabIndex = 0;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // dataGridViewPesquisarCliente
            // 
            this.dataGridViewPesquisarCliente.AllowUserToOrderColumns = true;
            this.dataGridViewPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPesquisarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NomeCol});
            this.dataGridViewPesquisarCliente.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewPesquisarCliente.Name = "dataGridViewPesquisarCliente";
            this.dataGridViewPesquisarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisarCliente.Size = new System.Drawing.Size(1093, 236);
            this.dataGridViewPesquisarCliente.TabIndex = 12;
            this.dataGridViewPesquisarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisarCliente_CellClick);
            this.dataGridViewPesquisarCliente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisarCliente_CellValueChanged);
            // 
            // IdCol
            // 
            this.IdCol.DataPropertyName = "Id";
            this.IdCol.HeaderText = "ID";
            this.IdCol.Name = "IdCol";
            // 
            // NomeCol
            // 
            this.NomeCol.DataPropertyName = "Nome";
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Location = new System.Drawing.Point(12, 384);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.Size = new System.Drawing.Size(1093, 185);
            this.dgvEndereco.TabIndex = 13;
            this.dgvEndereco.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEndereco_CellValueChanged);
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataSource = typeof(Locadora.DataAccess.Entidades.Endereco);
            // 
            // PesquisarClienteForm
            // 
            this.AcceptButton = this.btnPesquisarCliente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 554);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.dataGridViewPesquisarCliente);
            this.Controls.Add(this.grpBoxPesquisaDeCliente);
            this.Name = "PesquisarClienteForm";
            this.ShowIcon = false;
            this.Text = "Pesquisa de Cliente";
            this.grpBoxPesquisaDeCliente.ResumeLayout(false);
            this.grpBoxPesquisaDeCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPesquisaDeCliente;
        private System.Windows.Forms.RadioButton radioButtonPorID;
        private System.Windows.Forms.RadioButton radioButtonPorNome;
        private System.Windows.Forms.TextBox txtBoxPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.DataGridView dataGridViewPesquisarCliente;
     
        private System.Windows.Forms.Button buttonDeletarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.BindingSource enderecoBindingSource;
    }
}