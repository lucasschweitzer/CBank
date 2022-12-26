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

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            ctrlConta.creditarSaldo(txtbCpf.Text, Convert.ToDouble(txtbValor.Text));
        }
    }
}
