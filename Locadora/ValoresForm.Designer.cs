namespace Locadora
{
    partial class ValoresForm
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
            this.labelValorAluguel = new System.Windows.Forms.Label();
            this.labelValorMulta = new System.Windows.Forms.Label();
            this.textBoxValorAluguel = new System.Windows.Forms.TextBox();
            this.textBoxValorMulta = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxValorAluguel = new System.Windows.Forms.GroupBox();
            this.labelValueAtualAluguel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelValorMultaAtual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxValorDesconto = new System.Windows.Forms.TextBox();
            this.labelValorDesconto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDescontoAtual = new System.Windows.Forms.Label();
            this.groupBoxValorAluguel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelValorAluguel
            // 
            this.labelValorAluguel.AutoSize = true;
            this.labelValorAluguel.Location = new System.Drawing.Point(17, 65);
            this.labelValorAluguel.Name = "labelValorAluguel";
            this.labelValorAluguel.Size = new System.Drawing.Size(84, 13);
            this.labelValorAluguel.TabIndex = 0;
            this.labelValorAluguel.Text = "Valor do Aluguel";
            // 
            // labelValorMulta
            // 
            this.labelValorMulta.AutoSize = true;
            this.labelValorMulta.Location = new System.Drawing.Point(17, 64);
            this.labelValorMulta.Name = "labelValorMulta";
            this.labelValorMulta.Size = new System.Drawing.Size(74, 13);
            this.labelValorMulta.TabIndex = 1;
            this.labelValorMulta.Text = "Valor da multa";
            // 
            // textBoxValorAluguel
            // 
            this.textBoxValorAluguel.Location = new System.Drawing.Point(148, 58);
            this.textBoxValorAluguel.Name = "textBoxValorAluguel";
            this.textBoxValorAluguel.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorAluguel.TabIndex = 2;
            // 
            // textBoxValorMulta
            // 
            this.textBoxValorMulta.Location = new System.Drawing.Point(148, 61);
            this.textBoxValorMulta.Name = "textBoxValorMulta";
            this.textBoxValorMulta.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorMulta.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(300, 370);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor atual do aluguel";
            // 
            // groupBoxValorAluguel
            // 
            this.groupBoxValorAluguel.Controls.Add(this.labelValueAtualAluguel);
            this.groupBoxValorAluguel.Controls.Add(this.label1);
            this.groupBoxValorAluguel.Controls.Add(this.textBoxValorAluguel);
            this.groupBoxValorAluguel.Controls.Add(this.labelValorAluguel);
            this.groupBoxValorAluguel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxValorAluguel.Name = "groupBoxValorAluguel";
            this.groupBoxValorAluguel.Size = new System.Drawing.Size(363, 101);
            this.groupBoxValorAluguel.TabIndex = 7;
            this.groupBoxValorAluguel.TabStop = false;
            this.groupBoxValorAluguel.Text = "Aluguel";
            // 
            // labelValueAtualAluguel
            // 
            this.labelValueAtualAluguel.AutoSize = true;
            this.labelValueAtualAluguel.Location = new System.Drawing.Point(148, 27);
            this.labelValueAtualAluguel.Name = "labelValueAtualAluguel";
            this.labelValueAtualAluguel.Size = new System.Drawing.Size(35, 13);
            this.labelValueAtualAluguel.TabIndex = 6;
            this.labelValueAtualAluguel.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValorMultaAtual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelValorMulta);
            this.groupBox1.Controls.Add(this.textBoxValorMulta);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multa";
            // 
            // labelValorMultaAtual
            // 
            this.labelValorMultaAtual.AutoSize = true;
            this.labelValorMultaAtual.Location = new System.Drawing.Point(145, 29);
            this.labelValorMultaAtual.Name = "labelValorMultaAtual";
            this.labelValorMultaAtual.Size = new System.Drawing.Size(35, 13);
            this.labelValorMultaAtual.TabIndex = 5;
            this.labelValorMultaAtual.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Multa atual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxValorDesconto);
            this.groupBox2.Controls.Add(this.labelValorDesconto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelDescontoAtual);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desconto";
            // 
            // textBoxValorDesconto
            // 
            this.textBoxValorDesconto.Location = new System.Drawing.Point(148, 64);
            this.textBoxValorDesconto.Name = "textBoxValorDesconto";
            this.textBoxValorDesconto.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorDesconto.TabIndex = 3;
            // 
            // labelValorDesconto
            // 
            this.labelValorDesconto.AutoSize = true;
            this.labelValorDesconto.Location = new System.Drawing.Point(148, 30);
            this.labelValorDesconto.Name = "labelValorDesconto";
            this.labelValorDesconto.Size = new System.Drawing.Size(35, 13);
            this.labelValorDesconto.TabIndex = 2;
            this.labelValorDesconto.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor do desconto";
            // 
            // labelDescontoAtual
            // 
            this.labelDescontoAtual.AutoSize = true;
            this.labelDescontoAtual.Location = new System.Drawing.Point(17, 30);
            this.labelDescontoAtual.Name = "labelDescontoAtual";
            this.labelDescontoAtual.Size = new System.Drawing.Size(80, 13);
            this.labelDescontoAtual.TabIndex = 0;
            this.labelDescontoAtual.Text = "Desconto Atual";
            // 
            // ValoresForm
            // 
            this.AcceptButton = this.buttonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.groupBoxValorAluguel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ValoresForm";
            this.ShowIcon = false;
            this.Text = "Cadastrar Valores";
            this.groupBoxValorAluguel.ResumeLayout(false);
            this.groupBoxValorAluguel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelValorAluguel;
        private System.Windows.Forms.Label labelValorMulta;
        private System.Windows.Forms.TextBox textBoxValorAluguel;
        private System.Windows.Forms.TextBox textBoxValorMulta;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxValorAluguel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValorMultaAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelValueAtualAluguel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxValorDesconto;
        private System.Windows.Forms.Label labelValorDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDescontoAtual;
    }
}