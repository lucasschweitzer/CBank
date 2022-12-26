using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Modelo
{
    public class Conta
    {
        int codigo;
        string nome;
        string sobrenome;
        string email;
        string telefone;
        string cpf;
        Double saldo;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
    }
