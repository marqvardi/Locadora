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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.buttonAdicionarCarrinho = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRemoverCarrinho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJaAlugadoPeloCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlugar
            // 
            this.dataGridViewAlugar.AllowUserToAddRows = false;
            this.dataGridViewAlugar.AllowUserToDeleteRows = false;
            this.dataGridViewAlugar.AllowUserToOrderColumns = true;
            this.dataGridViewAlugar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlugar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAlugar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridViewAlugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlugar.Location = new System.Drawing.Point(35, 153);
            this.dataGridViewAlugar.MultiSelect = false;
            this.dataGridViewAlugar.Name = "dataGridViewAlugar";
            this.dataGridViewAlugar.ReadOnly = true;
            this.dataGridViewAlugar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlugar.Size = new System.Drawing.Size(972, 262);
            this.dataGridViewAlugar.TabIndex = 2;
            this.dataGridViewAlugar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlugar_CellClick);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
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
            this.textBoxTituloSearch.Size = new System.Drawing.Size(838, 20);
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
            this.buttonProcurar.Location = new System.Drawing.Point(932, 104);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(79, 23);
            this.buttonProcurar.TabIndex = 8;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // buttonAlugar
            // 
            this.buttonAlugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAlugar.Location = new System.Drawing.Point(437, 751);
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
            this.dataGridViewJaAlugadoPeloCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJaAlugadoPeloCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJaAlugadoPeloCliente.Location = new System.Drawing.Point(549, 474);
            this.dataGridViewJaAlugadoPeloCliente.Name = "dataGridViewJaAlugadoPeloCliente";
            this.dataGridViewJaAlugadoPeloCliente.Size = new System.Drawing.Size(461, 116);
            this.dataGridViewJaAlugadoPeloCliente.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Itens alugados por esse cliente:";
            // 
            // dataGridViewListaCarrinho
            // 
            this.dataGridViewListaCarrinho.AllowUserToAddRows = false;
            this.dataGridViewListaCarrinho.AllowUserToDeleteRows = false;
            this.dataGridViewListaCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListaCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaCarrinho.Location = new System.Drawing.Point(35, 474);
            this.dataGridViewListaCarrinho.Name = "dataGridViewListaCarrinho";
            this.dataGridViewListaCarrinho.ReadOnly = true;
            this.dataGridViewListaCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaCarrinho.Size = new System.Drawing.Size(474, 257);
            this.dataGridViewListaCarrinho.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lista carrinho";
            // 
            // buttonAdicionarCarrinho
            // 
            this.buttonAdicionarCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarCarrinho.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAdicionarCarrinho.Location = new System.Drawing.Point(881, 432);
            this.buttonAdicionarCarrinho.Name = "buttonAdicionarCarrinho";
            this.buttonAdicionarCarrinho.Size = new System.Drawing.Size(128, 23);
            this.buttonAdicionarCarrinho.TabIndex = 16;
            this.buttonAdicionarCarrinho.Text = "Adicionar no carrinho";
            this.buttonAdicionarCarrinho.UseVisualStyleBackColor = false;
            this.buttonAdicionarCarrinho.Click += new System.EventHandler(this.buttonAdicionarCarrinho_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Itens pendentes para entrega";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 628);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 103);
            this.dataGridView1.TabIndex = 18;
            // 
            // buttonRemoverCarrinho
            // 
            this.buttonRemoverCarrinho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemoverCarrinho.Location = new System.Drawing.Point(35, 751);
            this.buttonRemoverCarrinho.Name = "buttonRemoverCarrinho";
            this.buttonRemoverCarrinho.Size = new System.Drawing.Size(129, 23);
            this.buttonRemoverCarrinho.TabIndex = 19;
            this.buttonRemoverCarrinho.Text = " Remover do carrinho";
            this.buttonRemoverCarrinho.UseVisualStyleBackColor = false;
            this.buttonRemoverCarrinho.Click += new System.EventHandler(this.buttonRemoverCarrinho_Click);
            // 
            // TelaAlugarForm
            // 
            this.AcceptButton = this.buttonProcurar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 786);
            this.Controls.Add(this.buttonRemoverCarrinho);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAdicionarCarrinho);
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
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJaAlugadoPeloCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAlugar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
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
        private System.Windows.Forms.Button buttonAdicionarCarrinho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRemoverCarrinho;
    }
}