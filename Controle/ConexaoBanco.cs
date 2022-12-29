using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Controle
{
    internal class ConexaoBanco
    {
        string sqlConStr = "Server=Lucas_PC\\SQLEXPRESS;Database=BANCO;Trusted_Connection=True;";

        public string strConexao()
        {
            return sqlConStr;
        }
    }
}
