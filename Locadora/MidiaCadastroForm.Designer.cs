namespace Locadora
{
    partial class MidiaCadastroForm
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
            this.labelDVDTitulo = new System.Windows.Forms.Label();
            this.textBoxCadastroTitulo = new System.Windows.Forms.TextBox();
            this.labelDVDQuantidade = new System.Windows.Forms.Label();
            this.textBoxCadastroQuantidade = new System.Windows.Forms.TextBox();
            this.buttonProdutoCadastrar = new System.Windows.Forms.Button();
            this.comboBoxCadastroCategoria = new System.Windows.Forms.ComboBox();
            this.labelDVDCategoria = new System.Windows.Forms.Label();
            this.labelTipoMidia = new System.Windows.Forms.Label();
            this.comboBoxCadastroMidia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDVDTitulo
            // 
            this.labelDVDTitulo.AutoSize = true;
            this.labelDVDTitulo.Location = new System.Drawing.Point(18, 34);
            this.labelDVDTitulo.Name = "labelDVDTitulo";
            this.labelDVDTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelDVDTitulo.TabIndex = 1;
            this.labelDVDTitulo.Text = "Titulo";
            // 
            // textBoxCadastroTitulo
            // 
            this.textBoxCadastroTitulo.Location = new System.Drawing.Point(96, 27);
            this.textBoxCadastroTitulo.Name = "textBoxCadastroTitulo";
            this.textBoxCadastroTitulo.Size = new System.Drawing.Size(324, 20);
            this.textBoxCadastroTitulo.TabIndex = 3;
            // 
            // labelDVDQuantidade
            // 
            this.labelDVDQuantidade.AutoSize = true;
            this.labelDVDQuantidade.Location = new System.Drawing.Point(18, 124);
            this.labelDVDQuantidade.Name = "labelDVDQuantidade";
            this.labelDVDQuantidade.Size = new System.Drawing.Size(62, 13);
            this.labelDVDQuantidade.TabIndex = 4;
            this.labelDVDQuantidade.Text = "Quantidade";
            // 
            // textBoxCadastroQuantidade
            // 
            this.textBoxCadastroQuantidade.Location = new System.Drawing.Point(96, 121);
            this.textBoxCadastroQuantidade.Name = "textBoxCadastroQuantidade";
            this.textBoxCadastroQuantidade.Size = new System.Drawing.Size(121, 20);
            this.textBoxCadastroQuantidade.TabIndex = 5;
            // 
            // buttonProdutoCadastrar
            // 
            this.buttonProdutoCadastrar.Location = new System.Drawing.Point(189, 163);
            this.buttonProdutoCadastrar.Name = "buttonProdutoCadastrar";
            this.buttonProdutoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonProdutoCadastrar.TabIndex = 6;
            this.buttonProdutoCadastrar.Text = "Cadastrar";
            this.buttonProdutoCadastrar.UseVisualStyleBackColor = true;
            this.buttonProdutoCadastrar.Click += new System.EventHandler(this.buttonProdutoCadastrar_Click);
            // 
            // comboBoxCadastroCategoria
            // 
            this.comboBoxCadastroCategoria.FormattingEnabled = true;
            this.comboBoxCadastroCategoria.Items.AddRange(new object[] {
            "Acao",
            "Comedia",
            "Drama",
            "Suspense",
            "Terror"});
            this.comboBoxCadastroCategoria.Location = new System.Drawing.Point(96, 72);
            this.comboBoxCadastroCategoria.Name = "comboBoxCadastroCategoria";
            this.comboBoxCadastroCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCadastroCategoria.TabIndex = 7;
            // 
            // labelDVDCategoria
            // 
            this.labelDVDCategoria.AutoSize = true;
            this.labelDVDCategoria.Location = new System.Drawing.Point(18, 80);
            this.labelDVDCategoria.Name = "labelDVDCategoria";
            this.labelDVDCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelDVDCategoria.TabIndex = 8;
            this.labelDVDCategoria.Text = "Categoria";
            // 
            // labelTipoMidia
            // 
            this.labelTipoMidia.AutoSize = true;
            this.labelTipoMidia.Location = new System.Drawing.Point(248, 80);
            this.labelTipoMidia.Name = "labelTipoMidia";
            this.labelTipoMidia.Size = new System.Drawing.Size(32, 13);
            this.labelTipoMidia.TabIndex = 9;
            this.labelTipoMidia.Text = "Midia";
            // 
            // comboBoxCadastroMidia
            // 
            this.comboBoxCadastroMidia.FormattingEnabled = true;
            this.comboBoxCadastroMidia.Items.AddRange(new object[] {
            "DVD",
            "VHS"});
            this.comboBoxCadastroMidia.Location = new System.Drawing.Point(299, 72);
            this.comboBoxCadastroMidia.Name = "comboBoxCadastroMidia";
            this.comboBoxCadastroMidia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCadastroMidia.TabIndex = 10;
            // 
            // MidiaCadastroForm
            // 
            this.AcceptButton = this.buttonProdutoCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 208);
            this.Controls.Add(this.comboBoxCadastroMidia);
            this.Controls.Add(this.labelTipoMidia);
            this.Controls.Add(this.labelDVDCategoria);
            this.Controls.Add(this.comboBoxCadastroCategoria);
            this.Controls.Add(this.buttonProdutoCadastrar);
            this.Controls.Add(this.textBoxCadastroQuantidade);
            this.Controls.Add(this.labelDVDQuantidade);
            this.Controls.Add(this.textBoxCadastroTitulo);
            this.Controls.Add(this.labelDVDTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MidiaCadastroForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDVDTitulo;
        private System.Windows.Forms.TextBox textBoxCadastroTitulo;
        private System.Windows.Forms.Label labelDVDQuantidade;
        private System.Windows.Forms.TextBox textBoxCadastroQuantidade;
        private System.Windows.Forms.Button buttonProdutoCadastrar;
        private System.Windows.Forms.ComboBox comboBoxCadastroCategoria;
        private System.Windows.Forms.Label labelDVDCategoria;
        private System.Windows.Forms.Label labelTipoMidia;
        private System.Windows.Forms.ComboBox comboBoxCadastroMidia;
    }
}