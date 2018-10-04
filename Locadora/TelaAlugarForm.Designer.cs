namespace Locadora
{
    partial class TelaAlugarForm
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
            this.dataGridViewAlugar = new System.Windows.Forms.DataGridView();
            this.samplesDataSet1 = new Locadora.SamplesDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Locadora.SamplesDataSet1TableAdapters.ClienteTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTituloSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.buttonAlugar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewJaAlugadoPeloCliente = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewListaCarrinho = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJaAlugadoPeloCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlugar
            // 
            this.dataGridViewAlugar.AllowUserToAddRows = false;
            this.dataGridViewAlugar.AllowUserToDeleteRows = false;
            this.dataGridViewAlugar.AllowUserToOrderColumns = true;
            this.dataGridViewAlugar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAlugar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridViewAlugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlugar.Location = new System.Drawing.Point(35, 153);
            this.dataGridViewAlugar.MultiSelect = false;
            this.dataGridViewAlugar.Name = "dataGridViewAlugar";
            this.dataGridViewAlugar.ReadOnly = true;
            this.dataGridViewAlugar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlugar.Size = new System.Drawing.Size(1007, 262);
            this.dataGridViewAlugar.TabIndex = 2;
            // 
            // samplesDataSet1
            // 
            this.samplesDataSet1.DataSetName = "SamplesDataSet1";
            this.samplesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.samplesDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero do usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do usuario";
            // 
            // textBoxTituloSearch
            // 
            this.textBoxTituloSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTituloSearch.Location = new System.Drawing.Point(172, 69);
            this.textBoxTituloSearch.Name = "textBoxTituloSearch";
            this.textBoxTituloSearch.Size = new System.Drawing.Size(861, 20);
            this.textBoxTituloSearch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titulo";
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcurar.Location = new System.Drawing.Point(955, 104);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(79, 23);
            this.buttonProcurar.TabIndex = 8;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // buttonAlugar
            // 
            this.buttonAlugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlugar.Location = new System.Drawing.Point(433, 689);
            this.buttonAlugar.Name = "buttonAlugar";
            this.buttonAlugar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlugar.TabIndex = 9;
            this.buttonAlugar.Text = "Alugar";
            this.buttonAlugar.UseVisualStyleBackColor = true;
            this.buttonAlugar.Click += new System.EventHandler(this.buttonAlugar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // dataGridViewJaAlugadoPeloCliente
            // 
            this.dataGridViewJaAlugadoPeloCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJaAlugadoPeloCliente.Location = new System.Drawing.Point(581, 474);
            this.dataGridViewJaAlugadoPeloCliente.Name = "dataGridViewJaAlugadoPeloCliente";
            this.dataGridViewJaAlugadoPeloCliente.Size = new System.Drawing.Size(461, 195);
            this.dataGridViewJaAlugadoPeloCliente.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Itens alugados por esse cliente:";
            // 
            // dataGridViewListaCarrinho
            // 
            this.dataGridViewListaCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaCarrinho.Location = new System.Drawing.Point(38, 474);
            this.dataGridViewListaCarrinho.Name = "dataGridViewListaCarrinho";
            this.dataGridViewListaCarrinho.Size = new System.Drawing.Size(470, 195);
            this.dataGridViewListaCarrinho.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista carrinho";
            // 
            // TelaAlugarForm
            // 
            this.AcceptButton = this.buttonProcurar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 724);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewListaCarrinho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewJaAlugadoPeloCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAlugar);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTituloSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlugar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TelaAlugarForm";
            this.ShowIcon = false;
            this.Text = "Alugando";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJaAlugadoPeloCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAlugar;
        private SamplesDataSet1 samplesDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SamplesDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTituloSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Button buttonAlugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewJaAlugadoPeloCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewListaCarrinho;
        private System.Windows.Forms.Label label7;
    }
}