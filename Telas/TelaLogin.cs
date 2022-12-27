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
        Conta c;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ctrlConta.validaConta(txtbCodigo.Text) == true)
            {
                SalvaCpf.salvaCpf = txtbCodigo.Text;
                telaPrincipal telaP = new telaPrincipal();
                telaP.Show();
            } else
            {
                MessageBox.Show("erro");
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Nome = txtbNome.Text;
            c.Sobrenome= txtbSobrenome.Text;
            c.Cpf = txtbCpf.Text;
            c.Telefone = txtbTelefone.Text;
            c.Email = txtbEmail.Text;
            c.Saldo = Convert.ToDouble(txtbSaldo.Text);
            ctrlConta.cadastraConta(c);


        }
    }
}
