namespace Locadora
{
    partial class Formulario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarParametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.midiaToolStripMenuItem,
            this.administrativoToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovosClientesToolStripMenuItem,
            this.procurarClientesToolStripMenuItem});
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // cadastrarNovosClientesToolStripMenuItem
            // 
            this.cadastrarNovosClientesToolStripMenuItem.Name = "cadastrarNovosClientesToolStripMenuItem";
            this.cadastrarNovosClientesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cadastrarNovosClientesToolStripMenuItem.Text = "Cadastrar novos clientes";
            this.cadastrarNovosClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovosClientesToolStripMenuItem_Click);
            // 
            // procurarClientesToolStripMenuItem
            // 
            this.procurarClientesToolStripMenuItem.Name = "procurarClientesToolStripMenuItem";
            this.procurarClientesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.procurarClientesToolStripMenuItem.Text = "Procurar clientes";
            this.procurarClientesToolStripMenuItem.Click += new System.EventHandler(this.procurarClientesToolStripMenuItem_Click);
            // 
            // midiaToolStripMenuItem
            // 
            this.midiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem,
            this.procurarProdutoToolStripMenuItem});
            this.midiaToolStripMenuItem.Name = "midiaToolStripMenuItem";
            this.midiaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.midiaToolStripMenuItem.Text = "Midia";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // procurarProdutoToolStripMenuItem
            // 
            this.procurarProdutoToolStripMenuItem.Name = "procurarProdutoToolStripMenuItem";
            this.procurarProdutoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.procurarProdutoToolStripMenuItem.Text = "Procurar produto";
            this.procurarProdutoToolStripMenuItem.Click += new System.EventHandler(this.procurarProdutoToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alugarToolStripMenuItem});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // alugarToolStripMenuItem
            // 
            this.alugarToolStripMenuItem.Name = "alugarToolStripMenuItem";
            this.alugarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alugarToolStripMenuItem.Text = "Alugar";
            this.alugarToolStripMenuItem.Click += new System.EventHandler(this.alugarToolStripMenuItem_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarParametrosToolStripMenuItem,
            this.caixaToolStripMenuItem});
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // cadastrarParametrosToolStripMenuItem
            // 
            this.cadastrarParametrosToolStripMenuItem.Name = "cadastrarParametrosToolStripMenuItem";
            this.cadastrarParametrosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastrarParametrosToolStripMenuItem.Text = "Cadastrar parametros";
            this.cadastrarParametrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarParametrosToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            this.caixaToolStripMenuItem.Click += new System.EventHandler(this.caixaToolStripMenuItem_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Formulario";
            this.ShowIcon = false;
            this.Text = "Locadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem midiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarParametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
    }
}

