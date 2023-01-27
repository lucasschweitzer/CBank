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
    public partial class TelaOperacao : Form
    {
        public TelaOperacao()
        {
            InitializeComponent();
        }

        ControlaConta ctrlConta = new ControlaConta();
        string s = SalvaCpf.salvaCpf;
        string p;

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            TelaConfirmaSenha tela = new TelaConfirmaSenha();
            tela.ShowDialog();
            p = tela.senha();
            tela.limpaCampo();
            int count = 1;
            if (ctrlConta.validaConta(s, p) == true)
            {
                credita();
            }
            else
            {
                while (ctrlConta.validaConta(s, p) != true)
                {
                    MessageBox.Show("Senha incorreta, você tem mais 3 tentativas! " + "Tentativa " + count + "/3");
                    tela.ShowDialog();
                    p = tela.senha();
                    tela.limpaCampo();
                    if (ctrlConta.validaConta(s, p) == true)
                    {
                        credita();
                        break;
                    }
                    count++;
                    if (count > 3)
                    {
                        MessageBox.Show("Você digitou sua senha incorretamente 3 vezes, o sistema irá cancelar sua transação e encerrar!");
                        Application.Exit();
                        break;
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telaPrincipal tela = new telaPrincipal();
            tela.Show();
            this.Hide();

        }

        private void credita()
        {
            ctrlConta.creditarSaldo(s, Convert.ToDouble(txtbValor.Text));
            Movimentacao m = new Movimentacao();
            m.Valor = Convert.ToDouble(txtbValor.Text);
            m.ContaOrigem = s;
            m.ContaDestino = s;
            m.Tipo = "Depósito";
            ctrlConta.registraMovimentacao(m);
            MessageBox.Show("Valor creditado com sucesso!");
        }
    }
}
