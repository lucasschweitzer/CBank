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
    public partial class TelaConfirmaSenha : Form
    {
        public TelaConfirmaSenha()
        {
            InitializeComponent();
        }
        ControlaConta ctrlConta = new ControlaConta();
        private void TelaConfirmaSenha_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        public string senha()
        {
            return txtbSenha.Text;
        }

        public void limpaCampo()
        {
            txtbSenha.Text = "";
        }
    }
}
