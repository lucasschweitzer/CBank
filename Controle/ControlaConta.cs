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
        SqlDataReader reader;
        string strSql;

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

        public Boolean cadastraConta(Conta conta)
        {
            int a = 0;
            try
            {
                con = new SqlConnection(banco.strConexao());
                strSql = "INSERT INTO Contas (nome, sobrenome, cpf, telefone, email, saldo, senha) VALUES (@Nome, @Sobrenome, @Cpf, @Telefone, @Email, @Saldo, @Senha)";
                comando = new SqlCommand(strSql, con);
                comando.Parameters.AddWithValue("@Nome", conta.Nome);
                comando.Parameters.AddWithValue("@Sobrenome", conta.Sobrenome);
                comando.Parameters.AddWithValue("@Cpf", conta.Cpf);
                comando.Parameters.AddWithValue("@Telefone", conta.Telefone);
                comando.Parameters.AddWithValue("@Email", conta.Email);
                comando.Parameters.AddWithValue("@Saldo", conta.Saldo);
                comando.Parameters.AddWithValue("@Senha", conta.Senha);
                con.Open();
                a = comando.ExecuteNonQuery();
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

            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean validaConta(string cpf, string senha)
        {
                       
                con = new SqlConnection(banco.strConexao());
                strSql = "SELECT * FROM Contas WHERE cpf = @cpf AND senha = @senha";
                comando = new SqlCommand(strSql, con);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@senha", senha);
                con.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows == true)
                {
                    return true;

                } else
                {
                    return false;
                }
                con.Close();          
        }

        public string validaSenha(string senha)
        {
            //con = new SqlConnection(banco.strConexao());
            //strSql = "SELECT * FROM Contas WHERE cpf = @cpf AND senha = @senha";
            //comando = new SqlCommand(strSql, con);
            //comando.Parameters.AddWithValue("@cpf", cpf);
            //comando.Parameters.AddWithValue("@senha", senha);

            //con.Open();
            //reader = comando.ExecuteReader();
            return senha;
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

        public void fazerTransferencia(Double valor, string contaorigem, string contadestino)
        {
            con = new SqlConnection(banco.strConexao());
            strSql = "UPDATE Contas SET saldo=saldo - @valor WHERE cpf = @contaorigem UPDATE Contas SET saldo=saldo + @valor WHERE cpf = @contadestino";
            comando = new SqlCommand (strSql, con);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("contaorigem", contaorigem);
            comando.Parameters.AddWithValue("contadestino", contadestino);
            con.Open ();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void registraMovimentacao (Movimentacao m)
        {
            con = new SqlConnection(banco.strConexao());
            strSql = "INSERT INTO Movimentacoes (contaorigem, contadestino, valor, tipo) VALUES (@contaorigem, @contadestino, @valor, @tipo)";
            comando = new SqlCommand(strSql, con);
            comando.Parameters.AddWithValue("@contaorigem", m.ContaOrigem);
            comando.Parameters.AddWithValue("@contadestino", m.ContaDestino);
            comando.Parameters.AddWithValue("@valor", m.Valor);
            comando.Parameters.AddWithValue("@tipo", m.Tipo);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void preencheTabela(DataGridView tabela, string cpf)
        {
            try
            {
                tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tabela.AllowUserToAddRows = false;
                tabela.RowHeadersVisible = false;
                tabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                con = new SqlConnection(banco.strConexao());
                strSql = "SELECT m.codigo as 'Código Movimentação', m.tipo as 'Tipo', m.hora as 'Data', m.contaorigem as 'Conta Origem', m.contadestino as 'Conta de Destino', valor as 'Valor 'FROM Movimentacoes m WHERE contaorigem = @cpf";      
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSql, con);
                da.SelectCommand.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                con.Open();
                da.Fill(ds);
                tabela.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public string nome(string cpf)
        {
            con = new SqlConnection(banco.strConexao());
            strSql = "SELECT nome + ' ' + sobrenome FROM Contas WHERE cpf = @cpf";
            comando = new SqlCommand(strSql, con);
            comando.Parameters.AddWithValue("@cpf", cpf);
            con.Open();
            var n = comando.ExecuteScalar();
            string result = n.ToString();
            con.Close();
            return result;
                      
        }
    }
}
