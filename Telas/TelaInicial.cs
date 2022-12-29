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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TelaLogin tela = new TelaLogin();
            this.Hide();
            tela.Show();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro();
            tela.Show();
            this.Hide();
        }
    }
}
