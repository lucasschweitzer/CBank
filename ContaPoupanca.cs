using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelo
{
    internal class ContaPoupanca : Conta
    {
        double taxaDebito = 0.5;
        double taxaCredito = 0.1;
    }
}
