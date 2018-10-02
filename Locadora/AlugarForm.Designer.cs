namespace Locadora
{
    partial class AlugarForm
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
            this.grpBoxPesquisaDeCliente = new System.Windows.Forms.GroupBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.radioButtonPorID = new System.Windows.Forms.RadioButton();
            this.radioButtonPorNome = new System.Windows.Forms.RadioButton();
            this.txtBoxPesquisarCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewAlugar = new System.Windows.Forms.DataGridView();
            this.grpBoxPesquisaDeCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlugar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxPesquisaDeCliente
            // 
            this.grpBoxPesquisaDeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxPesquisaDeCliente.Controls.Add(this.buttonPesquisar);
            this.grpBoxPesquisaDeCliente.Controls.Add(this.radioButtonPorID);
            this.grpBoxPesquisaDeCliente.Controls.Add(this.radioButtonPorNome);
            this.grpBoxPesquisaDeCliente.Controls.Add(this.txtBoxPesquisarCliente);
            this.grpBoxPesquisaDeCliente.Location = new System.Drawing.Point(28, 22);
            this.grpBoxPesquisaDeCliente.Name = "grpBoxPesquisaDeCliente";
            this.grpBoxPesquisaDeCliente.Size = new System.Drawing.Size(601, 112);
            this.grpBoxPesquisaDeCliente.TabIndex = 12;
            this.grpBoxPesquisaDeCliente.TabStop = false;
            this.grpBoxPesquisaDeCliente.Text = "Pesquisa de cliente";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(505, 52);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 4;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
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
            this.txtBoxPesquisarCliente.Size = new System.Drawing.Size(441, 20);
            this.txtBoxPesquisarCliente.TabIndex = 1;
            // 
            // dataGridViewAlugar
            // 
            this.dataGridViewAlugar.AllowUserToAddRows = false;
            this.dataGridViewAlugar.AllowUserToDeleteRows = false;
            this.dataGridViewAlugar.AllowUserToOrderColumns = true;
            this.dataGridViewAlugar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlugar.Location = new System.Drawing.Point(31, 151);
            this.dataGridViewAlugar.Name = "dataGridViewAlugar";
            this.dataGridViewAlugar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlugar.Size = new System.Drawing.Size(596, 325);
            this.dataGridViewAlugar.TabIndex = 13;
            this.dataGridViewAlugar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlugar_CellClick);
            this.dataGridViewAlugar.DoubleClick += new System.EventHandler(this.dataGridViewAlugar_DoubleClick);
            // 
            // AlugarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 519);
            this.Controls.Add(this.dataGridViewAlugar);
            this.Controls.Add(this.grpBoxPesquisaDeCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AlugarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alugar";
            this.grpBoxPesquisaDeCliente.ResumeLayout(false);
            this.grpBoxPesquisaDeCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlugar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPesquisaDeCliente;
        private System.Windows.Forms.RadioButton radioButtonPorID;
        private System.Windows.Forms.RadioButton radioButtonPorNome;
        private System.Windows.Forms.TextBox txtBoxPesquisarCliente;
        private System.Windows.Forms.DataGridView dataGridViewAlugar;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}