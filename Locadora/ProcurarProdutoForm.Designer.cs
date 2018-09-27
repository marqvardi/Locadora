namespace Locadora
{
    partial class ProcurarProdutoForm
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
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.radioButtonProcurarPorTitulo = new System.Windows.Forms.RadioButton();
            this.radioButtonProcurarPorCategoria = new System.Windows.Forms.RadioButton();
            this.textBoxProcurarPorTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxProcurarPorCategoria = new System.Windows.Forms.ComboBox();
            this.samplesDataSet = new Locadora.SamplesDataSet();
            this.dataGridViewProcurarTituloOuCategoria = new System.Windows.Forms.DataGridView();
            this.midiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midiaTableAdapter = new Locadora.SamplesDataSetTableAdapters.MidiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.samplesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcurarTituloOuCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcurar.Location = new System.Drawing.Point(815, 84);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(75, 23);
            this.buttonProcurar.TabIndex = 0;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // radioButtonProcurarPorTitulo
            // 
            this.radioButtonProcurarPorTitulo.AutoSize = true;
            this.radioButtonProcurarPorTitulo.Checked = true;
            this.radioButtonProcurarPorTitulo.Location = new System.Drawing.Point(24, 27);
            this.radioButtonProcurarPorTitulo.Name = "radioButtonProcurarPorTitulo";
            this.radioButtonProcurarPorTitulo.Size = new System.Drawing.Size(108, 17);
            this.radioButtonProcurarPorTitulo.TabIndex = 1;
            this.radioButtonProcurarPorTitulo.TabStop = true;
            this.radioButtonProcurarPorTitulo.Text = "Procurar por titulo";
            this.radioButtonProcurarPorTitulo.UseVisualStyleBackColor = true;
            // 
            // radioButtonProcurarPorCategoria
            // 
            this.radioButtonProcurarPorCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonProcurarPorCategoria.AutoSize = true;
            this.radioButtonProcurarPorCategoria.Location = new System.Drawing.Point(24, 84);
            this.radioButtonProcurarPorCategoria.Name = "radioButtonProcurarPorCategoria";
            this.radioButtonProcurarPorCategoria.Size = new System.Drawing.Size(130, 17);
            this.radioButtonProcurarPorCategoria.TabIndex = 2;
            this.radioButtonProcurarPorCategoria.TabStop = true;
            this.radioButtonProcurarPorCategoria.Text = "Procurar por categoria";
            this.radioButtonProcurarPorCategoria.UseVisualStyleBackColor = true;
            // 
            // textBoxProcurarPorTitulo
            // 
            this.textBoxProcurarPorTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcurarPorTitulo.Location = new System.Drawing.Point(158, 27);
            this.textBoxProcurarPorTitulo.Name = "textBoxProcurarPorTitulo";
            this.textBoxProcurarPorTitulo.Size = new System.Drawing.Size(732, 20);
            this.textBoxProcurarPorTitulo.TabIndex = 3;
            // 
            // comboBoxProcurarPorCategoria
            // 
            this.comboBoxProcurarPorCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProcurarPorCategoria.FormattingEnabled = true;
            this.comboBoxProcurarPorCategoria.Items.AddRange(new object[] {
            "Suspense",
            "Terror",
            "Acao",
            "Comedia",
            "Aventura"});
            this.comboBoxProcurarPorCategoria.Location = new System.Drawing.Point(158, 84);
            this.comboBoxProcurarPorCategoria.Name = "comboBoxProcurarPorCategoria";
            this.comboBoxProcurarPorCategoria.Size = new System.Drawing.Size(591, 21);
            this.comboBoxProcurarPorCategoria.TabIndex = 4;
            // 
            // samplesDataSet
            // 
            this.samplesDataSet.DataSetName = "SamplesDataSet";
            this.samplesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewProcurarTituloOuCategoria
            // 
            this.dataGridViewProcurarTituloOuCategoria.AllowUserToAddRows = false;
            this.dataGridViewProcurarTituloOuCategoria.AllowUserToDeleteRows = false;
            this.dataGridViewProcurarTituloOuCategoria.AllowUserToOrderColumns = true;
            this.dataGridViewProcurarTituloOuCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProcurarTituloOuCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcurarTituloOuCategoria.Location = new System.Drawing.Point(24, 125);
            this.dataGridViewProcurarTituloOuCategoria.MultiSelect = false;
            this.dataGridViewProcurarTituloOuCategoria.Name = "dataGridViewProcurarTituloOuCategoria";
            this.dataGridViewProcurarTituloOuCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcurarTituloOuCategoria.Size = new System.Drawing.Size(866, 263);
            this.dataGridViewProcurarTituloOuCategoria.TabIndex = 5;
            // 
            // midiaBindingSource
            // 
            this.midiaBindingSource.DataMember = "Midia";
            this.midiaBindingSource.DataSource = this.samplesDataSet;
            // 
            // midiaTableAdapter
            // 
            this.midiaTableAdapter.ClearBeforeFill = true;
            // 
            // ProcurarProdutoForm
            // 
            this.AcceptButton = this.buttonProcurar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 400);
            this.Controls.Add(this.dataGridViewProcurarTituloOuCategoria);
            this.Controls.Add(this.comboBoxProcurarPorCategoria);
            this.Controls.Add(this.textBoxProcurarPorTitulo);
            this.Controls.Add(this.radioButtonProcurarPorCategoria);
            this.Controls.Add(this.radioButtonProcurarPorTitulo);
            this.Controls.Add(this.buttonProcurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ProcurarProdutoForm";
            this.ShowIcon = false;
            this.Text = "Procurar por produto";
            this.Load += new System.EventHandler(this.ProcurarProdutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samplesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcurarTituloOuCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.RadioButton radioButtonProcurarPorTitulo;
        private System.Windows.Forms.RadioButton radioButtonProcurarPorCategoria;
        private System.Windows.Forms.TextBox textBoxProcurarPorTitulo;
        private System.Windows.Forms.ComboBox comboBoxProcurarPorCategoria;
        private System.Windows.Forms.DataGridView dataGridViewProcurarTituloOuCategoria;
        private SamplesDataSet samplesDataSet;
        private System.Windows.Forms.BindingSource midiaBindingSource;
        private SamplesDataSetTableAdapters.MidiaTableAdapter midiaTableAdapter;
    }
}