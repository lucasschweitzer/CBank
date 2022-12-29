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
    public partial class TelaHistorico : Form
    {
        public TelaHistorico()
        {
            InitializeComponent();
        }

        ControlaConta ctrlConta = new ControlaConta();
        string s = SalvaCpf.salvaCpf;

        private void TelaHistorico_Load(object sender, EventArgs e)
        {
            
            ctrlConta.preencheTabela(tblHistorico, s);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ctrlConta.preencheTabela(tblHistorico, s);
        }

        private void tblHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
