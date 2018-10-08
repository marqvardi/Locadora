namespace Locadora
{
    partial class ConfirmacaoAluguelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.labelTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID cliente";
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Location = new System.Drawing.Point(107, 41);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(65, 13);
            this.labelIdCliente.TabIndex = 1;
            this.labelIdCliente.Text = "Mostrar aqui";
            // 
            // labelTeste
            // 
            this.labelTeste.AutoSize = true;
            this.labelTeste.Location = new System.Drawing.Point(86, 143);
            this.labelTeste.Name = "labelTeste";
            this.labelTeste.Size = new System.Drawing.Size(35, 13);
            this.labelTeste.TabIndex = 2;
            this.labelTeste.Text = "label2";
            // 
            // ConfirmacaoAluguelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTeste);
            this.Controls.Add(this.labelIdCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ConfirmacaoAluguelForm";
            this.ShowIcon = false;
            this.Text = "Confirmacao de aluguel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.Label labelTeste;
    }
}