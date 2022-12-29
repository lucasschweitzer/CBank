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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        ControlaConta ctrlConta = new ControlaConta();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.Nome = txtbNome.Text;
            c.Sobrenome = txtbSobrenome.Text;
            c.Cpf = txtbCpf.Text;
            c.Telefone = txtbTelefone.Text;
            c.Email = txtbEmail.Text;
            c.Saldo = 0;
            c.Senha = txtbSenha.Text;
            ctrlConta.cadastraConta(c);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
