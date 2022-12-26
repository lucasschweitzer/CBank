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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarSaldo_Click(object sender, EventArgs e)
        {
            string s = Interaction.InputBox("Digite a sua conta: ", "Informe sua conta", " ");
            ctrlConta.mostrarSaldo(s);

        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCreditarSaldo_Click(object sender, EventArgs e)
        {
            TelaOperacao tela = new TelaOperacao();
            tela.Show();
            
        }
    }
}