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
        TelaConfirmaSenha tela = new TelaConfirmaSenha();
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            tela.ShowDialog();
            p = tela.senha();
            tela.limpaCampo();

            if (ctrlConta.validaConta(s, p) == true)
            {
                ctrlConta.creditarSaldo(s, Convert.ToDouble(txtbValor.Text));
                Movimentacao m = new Movimentacao();
                m.Valor = Convert.ToDouble(txtbValor.Text);
                m.ContaOrigem = s;
                m.ContaDestino = s;
                m.Tipo = "Depósito";
                ctrlConta.registraMovimentacao(m);
                MessageBox.Show("sucesso");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telaPrincipal tela = new telaPrincipal();
            tela.Show();
            this.Hide();

        }
    }
}
