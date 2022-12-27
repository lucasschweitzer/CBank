namespace Banco.Telas
{
    partial class TelaTransferencia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.txtbOrigem = new System.Windows.Forms.TextBox();
            this.txtbDestino = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conta Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conta Destino";
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(204, 58);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(312, 23);
            this.txtbValor.TabIndex = 3;
            // 
            // txtbOrigem
            // 
            this.txtbOrigem.Location = new System.Drawing.Point(204, 168);
            this.txtbOrigem.Name = "txtbOrigem";
            this.txtbOrigem.Size = new System.Drawing.Size(312, 23);
            this.txtbOrigem.TabIndex = 4;
            // 
            // txtbDestino
            // 
            this.txtbDestino.Location = new System.Drawing.Point(204, 267);
            this.txtbDestino.Name = "txtbDestino";
            this.txtbDestino.Size = new System.Drawing.Size(312, 23);
            this.txtbDestino.TabIndex = 5;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(309, 379);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // TelaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.txtbDestino);
            this.Controls.Add(this.txtbOrigem);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaTransferencia";
            this.Text = "TelaTransferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbValor;
        private TextBox txtbOrigem;
        private TextBox txtbDestino;
        private Button btnTransferir;
    }
}