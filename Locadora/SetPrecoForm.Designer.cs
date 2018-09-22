namespace Locadora
{
    partial class SetPrecoForm
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
            this.buttonSetPreco = new System.Windows.Forms.Button();
            this.labelSetPreco = new System.Windows.Forms.Label();
            this.textBoxSetPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSetPreco
            // 
            this.buttonSetPreco.Location = new System.Drawing.Point(144, 63);
            this.buttonSetPreco.Name = "buttonSetPreco";
            this.buttonSetPreco.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPreco.TabIndex = 0;
            this.buttonSetPreco.Text = "Salvar";
            this.buttonSetPreco.UseVisualStyleBackColor = true;
            this.buttonSetPreco.Click += new System.EventHandler(this.buttonSetPreco_Click);
            // 
            // labelSetPreco
            // 
            this.labelSetPreco.AutoSize = true;
            this.labelSetPreco.Location = new System.Drawing.Point(14, 25);
            this.labelSetPreco.Name = "labelSetPreco";
            this.labelSetPreco.Size = new System.Drawing.Size(83, 13);
            this.labelSetPreco.TabIndex = 1;
            this.labelSetPreco.Text = "Valor do aluguel";
            // 
            // textBoxSetPreco
            // 
            this.textBoxSetPreco.Location = new System.Drawing.Point(119, 22);
            this.textBoxSetPreco.Name = "textBoxSetPreco";
            this.textBoxSetPreco.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetPreco.TabIndex = 2;
            // 
            // SetPrecoForm
            // 
            this.AcceptButton = this.buttonSetPreco;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 119);
            this.Controls.Add(this.textBoxSetPreco);
            this.Controls.Add(this.labelSetPreco);
            this.Controls.Add(this.buttonSetPreco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetPrecoForm";
            this.ShowIcon = false;
            this.Text = "Configuracao de preco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetPreco;
        private System.Windows.Forms.Label labelSetPreco;
        private System.Windows.Forms.TextBox textBoxSetPreco;
    }
}