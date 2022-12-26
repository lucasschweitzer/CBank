namespace Banco.Telas
{
    partial class TelaOperacao
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
            this.txtbCpf = new System.Windows.Forms.TextBox();
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // txtbCpf
            // 
            this.txtbCpf.Location = new System.Drawing.Point(164, 100);
            this.txtbCpf.Name = "txtbCpf";
            this.txtbCpf.Size = new System.Drawing.Size(236, 23);
            this.txtbCpf.TabIndex = 2;
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(164, 227);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(236, 23);
            this.txtbValor.TabIndex = 3;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(228, 342);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 4;
            this.btnTransferir.Text = "Adicionar";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // TelaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.txtbCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaOperacao";
            this.Text = "TelaOperacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbCpf;
        private TextBox txtbValor;
        private Button btnTransferir;
    }
}