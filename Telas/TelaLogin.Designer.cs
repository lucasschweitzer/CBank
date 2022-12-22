namespace Banco.Telas
{
    partial class TelaLogin
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
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbSobrenome = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbTelefone = new System.Windows.Forms.TextBox();
            this.txtbCpf = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(59, 130);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtbCodigo.TabIndex = 1;
            this.txtbCodigo.TextChanged += new System.EventHandler(this.txtbCodigo_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(73, 182);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sobrenome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "CPF";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(492, 89);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(234, 23);
            this.txtbNome.TabIndex = 8;
            // 
            // txtbSobrenome
            // 
            this.txtbSobrenome.Location = new System.Drawing.Point(492, 135);
            this.txtbSobrenome.Name = "txtbSobrenome";
            this.txtbSobrenome.Size = new System.Drawing.Size(234, 23);
            this.txtbSobrenome.TabIndex = 9;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(492, 183);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(234, 23);
            this.txtbEmail.TabIndex = 10;
            // 
            // txtbTelefone
            // 
            this.txtbTelefone.Location = new System.Drawing.Point(492, 230);
            this.txtbTelefone.Name = "txtbTelefone";
            this.txtbTelefone.Size = new System.Drawing.Size(234, 23);
            this.txtbTelefone.TabIndex = 11;
            // 
            // txtbCpf
            // 
            this.txtbCpf.Location = new System.Drawing.Point(492, 280);
            this.txtbCpf.Name = "txtbCpf";
            this.txtbCpf.Size = new System.Drawing.Size(234, 23);
            this.txtbCpf.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(577, 380);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Saldo";
            // 
            // txtbSaldo
            // 
            this.txtbSaldo.Location = new System.Drawing.Point(492, 328);
            this.txtbSaldo.Name = "txtbSaldo";
            this.txtbSaldo.Size = new System.Drawing.Size(234, 23);
            this.txtbSaldo.TabIndex = 15;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbSaldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtbCpf);
            this.Controls.Add(this.txtbTelefone);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbSobrenome);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.label1);
            this.Name = "TelaLogin";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtbCodigo;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtbNome;
        private TextBox txtbSobrenome;
        private TextBox txtbEmail;
        private TextBox txtbTelefone;
        private TextBox txtbCpf;
        private Button btnCadastrar;
        private Label label7;
        private TextBox txtbSaldo;
    }
}