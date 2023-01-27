using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Controle
{
    internal class ConexaoBanco
    {
        string sqlConStr = "Server=ADM019911\\SQLEXPRESS;Database=BANCO;Trusted_Connection=True;";

        public string strConexao()
        {
            return sqlConStr;
        }
    }
}
