using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelo
{
    internal class ControlaConta
    {
        private void creditarSaldo(Conta conta, int valor)
        {
            conta.Saldo = conta.Saldo + valor;
        }

        private void debitarSaldo(Conta conta, int valor)
        {
            conta.Saldo = conta.Saldo - valor;
        }

        public double mostrarSaldo(Conta conta)
        {
            return conta.Saldo;
        }
    }
}
