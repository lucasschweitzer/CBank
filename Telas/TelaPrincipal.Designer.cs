namespace Banco
{
    partial class telaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarSaldo = new System.Windows.Forms.Button();
            this.btnCreditarSaldo = new System.Windows.Forms.Button();
            this.btnFazerTransferencia = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMostrarSaldo
            // 
            this.btnMostrarSaldo.Location = new System.Drawing.Point(71, 90);
            this.btnMostrarSaldo.Name = "btnMostrarSaldo";
            this.btnMostrarSaldo.Size = new System.Drawing.Size(92, 23);
            this.btnMostrarSaldo.TabIndex = 1;
            this.btnMostrarSaldo.Text = "Mostrar Saldo";
            this.btnMostrarSaldo.UseVisualStyleBackColor = true;
            this.btnMostrarSaldo.Click += new System.EventHandler(this.btnMostrarSaldo_Click);
            // 
            // btnCreditarSaldo
            // 
            this.btnCreditarSaldo.Location = new System.Drawing.Point(71, 137);
            this.btnCreditarSaldo.Name = "btnCreditarSaldo";
            this.btnCreditarSaldo.Size = new System.Drawing.Size(92, 23);
            this.btnCreditarSaldo.TabIndex = 2;
            this.btnCreditarSaldo.Text = "Creditar Saldo";
            this.btnCreditarSaldo.UseVisualStyleBackColor = true;
            this.btnCreditarSaldo.Click += new System.EventHandler(this.btnCreditarSaldo_Click);
            // 
            // btnFazerTransferencia
            // 
            this.btnFazerTransferencia.Location = new System.Drawing.Point(71, 186);
            this.btnFazerTransferencia.Name = "btnFazerTransferencia";
            this.btnFazerTransferencia.Size = new System.Drawing.Size(120, 23);
            this.btnFazerTransferencia.TabIndex = 3;
            this.btnFazerTransferencia.Text = "Fazer Transferência";
            this.btnFazerTransferencia.UseVisualStyleBackColor = true;
            this.btnFazerTransferencia.Click += new System.EventHandler(this.btnFazerTransferencia_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(71, 235);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(177, 23);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "Histórico de Movimentações";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.Location = new System.Drawing.Point(71, 287);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(120, 23);
            this.btnAlterarDados.TabIndex = 5;
            this.btnAlterarDados.Text = "Alterar Dados";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(685, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterarDados);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnFazerTransferencia);
            this.Controls.Add(this.btnCreditarSaldo);
            this.Controls.Add(this.btnMostrarSaldo);
            this.Controls.Add(this.label1);
            this.Name = "telaPrincipal";
            this.Text = "C# BANK";
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMostrarSaldo;
        private Button btnCreditarSaldo;
        private Button btnFazerTransferencia;
        private Button btnHistorico;
        private Button btnAlterarDados;
        private Button btnSair;
    }
}