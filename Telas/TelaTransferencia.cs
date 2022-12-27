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


        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Movimentacao m = new Movimentacao();
            m.Valor = (Convert.ToDouble(txtbValor.Text));
            m.ContaOrigem = txtbOrigem.Text;
            m.ContaDestino = txtbDestino.Text;
            ctrlConta.registraMovimentacao(m);
            ctrlConta.fazerTransferencia(Convert.ToDouble(txtbValor.Text), txtbOrigem.Text, txtbDestino.Text);           
        }
    }
}
