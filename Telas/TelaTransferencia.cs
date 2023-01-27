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
    public partial class TelaTransferencia : Form
    {
        public TelaTransferencia()
        {
            InitializeComponent();
        }
        ControlaConta ctrlConta = new ControlaConta();
        string s = SalvaCpf.salvaCpf;
        string p;
        TelaConfirmaSenha tela = new TelaConfirmaSenha();

        private void btnTransferir_Click(object sender, EventArgs e)
        {   
            tela.ShowDialog();    
            p = tela.senha();
            tela.limpaCampo();
            int count = 1;
            if (ctrlConta.validaConta(s, p) == true)
            {
                transfere();
            }
            else
            {
                while(ctrlConta.validaConta(s,p) != true)
                {
                    MessageBox.Show("Senha incorreta! Você tem mais 3 tentativas! Tentativa: " + count + "/3");
                    tela.ShowDialog();
                    p = tela.senha();
                    tela.limpaCampo();
                    count++;
                    if(ctrlConta.validaConta(s, p) == true)
                    {
                        transfere();
                        break;
                    }
                    if(count > 3)
                    {
                        MessageBox.Show("ATENÇÂO: Você digitou sua senha incorretamente 3 vezes, o sistema irá cancelar a sua transferência e fechar.");
                        Application.Exit();
                        break;
                    }
                }
            }
        }

        private void transfere()
        {
            Movimentacao m = new Movimentacao();
            m.Valor = (Convert.ToDouble(txtbValor.Text));
            m.ContaOrigem = txtbOrigem.Text;
            m.ContaDestino = txtbDestino.Text;
            m.Tipo = "Transferência";
            ctrlConta.registraMovimentacao(m);
            ctrlConta.fazerTransferencia(Convert.ToDouble(txtbValor.Text), txtbOrigem.Text, txtbDestino.Text);
            MessageBox.Show("Transferência enviada com sucesso!");
        }
    }
}
