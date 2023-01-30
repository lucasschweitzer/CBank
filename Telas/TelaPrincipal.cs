using Banco.Controle;
using Banco.Modelo;
using Banco.Telas;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace Banco
{
    public partial class telaPrincipal : Form
    {
        public  telaPrincipal()
        {
            InitializeComponent();
            
        }
        ControlaConta ctrlConta = new ControlaConta();
        TelaLogin tela = new TelaLogin();
        string s = SalvaCpf.salvaCpf;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarSaldo_Click(object sender, EventArgs e)
        {
            
            ctrlConta.mostrarSaldo(s);

        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCreditarSaldo_Click(object sender, EventArgs e)
        {
            TelaOperacao tela = new TelaOperacao();
            tela.Show();
            this.Hide();
            
        }

        private void btnFazerTransferencia_Click(object sender, EventArgs e)
        {
            TelaTransferencia tela = new TelaTransferencia();
            tela.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            TelaHistorico tela = new TelaHistorico();
            tela.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCodConta_Click(object sender, EventArgs e)
        {
            ctrlConta.codigoConta(s);
        }
    }
}