using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Banco.Controle;
using System.Windows.Forms;

namespace Banco.Modelo
{
    internal class ControlaConta
    {
        ConexaoBanco banco = new ConexaoBanco();
        SqlCommand comando;
        SqlDataAdapter da;
        SqlConnection con;
        string strSql;
        Conta c;

        private void creditarSaldo(Conta conta, int valor)
        {
            conta.Saldo = conta.Saldo + valor;
        }

        private void debitarSaldo(Conta conta, int valor)
        {
            conta.Saldo = conta.Saldo - valor;
        }

        public void mostrarSaldo(string codigo)
        {
            con = new SqlConnection(banco.strConexao());
            strSql = "SELECT Saldo FROM Contas WHERE cpf = @Cpf";
            comando = new SqlCommand(strSql, con);
            comando.Parameters.AddWithValue("@Cpf", codigo);
            con.Open();
            var result = comando.ExecuteScalar();
            con.Close();
            String s = result.ToString();
            MessageBox.Show("O seu saldo atual é: R$"+s+".");
        }

        public void cadastraConta(Conta conta)
        {
            try
            {
                con = new SqlConnection(banco.strConexao());
                strSql = "INSERT INTO Contas (nome, sobrenome, cpf, telefone, email, saldo) VALUES (@Nome, @Sobrenome, @Cpf, @Telefone, @Email, @Saldo)";
                comando = new SqlCommand(strSql, con);
                comando.Parameters.AddWithValue("@Nome", conta.Nome);
                comando.Parameters.AddWithValue("@Sobrenome", conta.Sobrenome);
                comando.Parameters.AddWithValue("@Cpf", conta.Cpf);
                comando.Parameters.AddWithValue("@Telefone", conta.Telefone);
                comando.Parameters.AddWithValue("@Email", conta.Email);
                comando.Parameters.AddWithValue("@Saldo", conta.Saldo);
                con.Open();
                comando.ExecuteNonQuery();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                comando.Clone();
                comando = null;
            }
        }

        public Boolean validaConta(string cpf)
        {
                con = new SqlConnection(banco.strConexao());
                strSql = "SELECT * FROM Contas WHERE cpf = '@cpf'";
                comando = new SqlCommand(strSql, con);
                comando.Parameters.AddWithValue("cpf", cpf);
                con.Open();
                int r = comando.ExecuteNonQuery();
                if (r >= 0)
                {
                    return true;

            } else
                {
                    return false;

            }
            con.Close();

        }

        private void Print(string v)
        {
            throw new NotImplementedException();
        }

        public void creditarSaldo(string cpf, double valor)
        {
            try
            {
                con = new SqlConnection(banco.strConexao());
                strSql = "UPDATE Contas SET saldo=saldo + @valor WHERE cpf = @cpf";
                comando = new SqlCommand(strSql, con);
                comando.Parameters.AddWithValue("@valor", valor);
                comando.Parameters.AddWithValue("@cpf", cpf);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                comando.Clone();
                comando = null;
            }
        }
    }
}
