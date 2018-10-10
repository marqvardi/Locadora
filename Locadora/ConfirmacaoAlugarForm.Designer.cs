namespace Locadora
{
    partial class ConfirmacaoAlugarForm
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
            this.label = new System.Windows.Forms.Label();
            this.labelIDCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValorSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValorDesconto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelValorMulta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvConfirmar = new System.Windows.Forms.DataGridView();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 13);
            this.label.TabIndex = 0;
            this.label.Text = "ID Cliente:";
            // 
            // labelIDCliente
            // 
            this.labelIDCliente.AutoSize = true;
            this.labelIDCliente.Location = new System.Drawing.Point(127, 24);
            this.labelIDCliente.Name = "labelIDCliente";
            this.labelIDCliente.Size = new System.Drawing.Size(35, 13);
            this.labelIDCliente.TabIndex = 1;
            this.labelIDCliente.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor SubTotal";
            // 
            // labelValorSubtotal
            // 
            this.labelValorSubtotal.AutoSize = true;
            this.labelValorSubtotal.Location = new System.Drawing.Point(127, 66);
            this.labelValorSubtotal.Name = "labelValorSubtotal";
            this.labelValorSubtotal.Size = new System.Drawing.Size(35, 13);
            this.labelValorSubtotal.TabIndex = 3;
            this.labelValorSubtotal.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Desconto";
            // 
            // labelValorDesconto
            // 
            this.labelValorDesconto.AutoSize = true;
            this.labelValorDesconto.Location = new System.Drawing.Point(127, 108);
            this.labelValorDesconto.Name = "labelValorDesconto";
            this.labelValorDesconto.Size = new System.Drawing.Size(35, 13);
            this.labelValorDesconto.TabIndex = 5;
            this.labelValorDesconto.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor Multa";
            // 
            // labelValorMulta
            // 
            this.labelValorMulta.AutoSize = true;
            this.labelValorMulta.Location = new System.Drawing.Point(127, 152);
            this.labelValorMulta.Name = "labelValorMulta";
            this.labelValorMulta.Size = new System.Drawing.Size(35, 13);
            this.labelValorMulta.TabIndex = 7;
            this.labelValorMulta.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Valor total";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(127, 190);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(41, 13);
            this.labelValorTotal.TabIndex = 9;
            this.labelValorTotal.Text = "label10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValorTotal);
            this.groupBox1.Controls.Add(this.labelValorMulta);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelValorDesconto);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.labelValorSubtotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelIDCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes:";
            // 
            // dgvConfirmar
            // 
            this.dgvConfirmar.AllowUserToAddRows = false;
            this.dgvConfirmar.AllowUserToDeleteRows = false;
            this.dgvConfirmar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmar.Location = new System.Drawing.Point(12, 253);
            this.dgvConfirmar.Name = "dgvConfirmar";
            this.dgvConfirmar.ReadOnly = true;
            this.dgvConfirmar.Size = new System.Drawing.Size(753, 150);
            this.dgvConfirmar.TabIndex = 11;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(690, 415);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 12;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // ConfirmacaoAlugarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.dgvConfirmar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ConfirmacaoAlugarForm";
            this.ShowIcon = false;
            this.Text = "Confirmacao de aluguel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelIDCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValorSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValorDesconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelValorMulta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvConfirmar;
        private System.Windows.Forms.Button buttonConfirmar;
    }
}