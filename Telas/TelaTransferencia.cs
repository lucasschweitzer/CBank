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
            if (ctrlConta.validaConta(s, p) == true)
            {
                Movimentacao m = new Movimentacao();
                m.Valor = (Convert.ToDouble(txtbValor.Text));
                m.ContaOrigem = txtbOrigem.Text;
                m.ContaDestino = txtbDestino.Text;
                m.Tipo = "Transferência";
                ctrlConta.registraMovimentacao(m);
                ctrlConta.fazerTransferencia(Convert.ToDouble(txtbValor.Text), txtbOrigem.Text, txtbDestino.Text);
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
