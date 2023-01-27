using Banco.Controle;
using Banco.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banco.Telas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            
        }
        public string cpf()
        {
            return txtbCodigo.Text;
        }

        ControlaConta ctrlConta = new ControlaConta();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ctrlConta.validaConta(txtbCodigo.Text, txtbSenha.Text) == true)
            {
                SalvaCpf.salvaCpf = txtbCodigo.Text;
                SalvaCpf.salvapass = txtbCodigo.Text;
                telaPrincipal telaP = new telaPrincipal();
                MessageBox.Show("Login efetuado com sucesso! Seja bem-vindo, " + ctrlConta.nome(SalvaCpf.salvaCpf));
                telaP.Show();               
                this.Hide();
            } else
            {
                MessageBox.Show("Erro ao fazer o login, confira se o CPF e senha estão corretos");
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
