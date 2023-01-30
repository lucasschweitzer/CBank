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
            if (rbtnCorrente.Checked)
            {
                ContaCorrente c = new ContaCorrente();
                c.Nome = txtbNome.Text;
                c.Sobrenome = txtbSobrenome.Text;
                c.Cpf = txtbCpf.Text;
                c.Telefone = txtbTelefone.Text;
                c.Email = txtbEmail.Text;
                c.Saldo = 0;
                c.Senha = txtbSenha.Text;
                c.Tipo = c.tipoCC();
                if (ctrlConta.cadastraConta(c) == true)
                {
                    MessageBox.Show("Conta Corrente cadastrada com sucesso!");
                    limpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar, confira os campos novamente!");
                }
            } else
            {
                ContaPoupanca c = new ContaPoupanca();
                c.Nome = txtbNome.Text;
                c.Sobrenome = txtbSobrenome.Text;
                c.Cpf = txtbCpf.Text;
                c.Telefone = txtbTelefone.Text;
                c.Email = txtbEmail.Text;
                c.Saldo = 0;
                c.Senha = txtbSenha.Text;
                c.Tipo = c.tipoCP();
                if (ctrlConta.cadastraConta(c) == true)
                {
                    MessageBox.Show("Conta Poupança cadastrada com sucesso!");
                    limpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar, confira os campos novamente!");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void limpaCampos()
        {
            txtbNome.Text = "";
            txtbSobrenome.Text = "";
            txtbCpf.Text = "";
            txtbTelefone.Text = "";
            txtbEmail.Text = "";
            txtbSenha.Text = "";
            rbtnCorrente.Checked = false;
            rbtnPoupanca.Checked = false;
        }
    }
}
