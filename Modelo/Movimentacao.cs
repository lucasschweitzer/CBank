using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelo
{
    internal class Movimentacao
    {
        string contaOrigem;
        string contaDestino;
        string tipo;
        double valor;

        public string ContaOrigem { get => contaOrigem; set => contaOrigem = value; }
        public string ContaDestino { get => contaDestino; set => contaDestino = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
