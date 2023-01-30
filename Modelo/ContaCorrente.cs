using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelo
{
    internal class ContaCorrente : Conta
    {
        double taxaDebito = 0.1;
        string tipo = "Conta Corrente";

        public string tipoCC()
        {
            return tipo;
        }

    }
}
