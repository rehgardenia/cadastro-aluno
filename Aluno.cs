using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace CadastroAluno
{
    internal class Aluno
    {
        private string? prontuario;
        private string? nome;
        private string? cpf;
        private string? rg;
        private string? email;

        // GET E SET 
        public string Prontuario
        {
            get { return prontuario!; }
            set
            {
                if (!Validacoes.ValidaProntuario(value))
                    throw new Exception("Prontuário Inválido! " + value);
                else
                    prontuario = value;
            }
        }
        public string Nome
        {
            get { return nome!; }
            set
            {
                nome = value;
            }
        }
        public string Cpf
        {
            get { return cpf!; }
            set
            {
                if (!Validacoes.ValidaCPF(value))
                    throw new Exception("Cpf Inválido! " + value);
                else
                    cpf = value;
            }
        }
        public string Rg
        {
            get { return rg!; }
            set
            {
                if (!Validacoes.ValidaRG(value))
                    throw new Exception("Rg Inválido! " + value);
                else
                    rg = value;
            }
        }
        public string Email
        {
            get { return email!; }
            set { email = value; }

        }

        // INSERT - Inclusão do Aluno no Banco de Dados

        public void Incluir()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = new MySqlConnection(Conexao.ConnectionString);
                conexao.Open();
                string query = $"INSERT INTO Alunos(Prontuario, Nome, Email, CPF, RG) VALUES (@Prontuario, @Nome, @Email, @CPF, @RG) ";
                MySqlCommand cmd = new(query, conexao);

                cmd.Parameters.AddWithValue("@Prontuario", prontuario);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@RG", rg);
                cmd.Parameters.AddWithValue("@CPF", cpf);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno incluido com sucessso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch( MySqlException ex)
            {
                throw new Exception("Erro ao inserir dado no MySql: " + ex.Message);
            }

            catch (Exception ex) {

                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }

        }
        public bool Consultar()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = new (Conexao.ConnectionString);
                conexao.Open();

                string query = $"SELECT Prontuario, Nome, Email, CPF, RG FROM Alunos WHERE Prontuario = @Prontuario";
                MySqlCommand cmd = new (query, conexao);
                cmd.Parameters.AddWithValue("@Prontuario", prontuario);
               
                MySqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    return false;
                }
                // Prencher as localizações
                this.nome = dr["Nome"].ToString();
                this.cpf = dr["CPF"].ToString();
                this.rg = dr["RG"].ToString();
                this.email = dr["Email"].ToString();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao consultar no MySql: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no Banco de dados" + ex);
            }
            finally
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }

        }
        public bool Editar()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = new (Conexao.ConnectionString);
                conexao.Open();
                string query = $"UPDATE Alunos SET Prontuario=@Prontuario, Nome=@Nome, Email=@Email, CPF=@CPF, RG=@RG WHERE Prontuario=@Prontuario;";
                MySqlCommand comando = new (query, conexao);
                comando.Parameters.AddWithValue("@Prontuario", prontuario);
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@RG", rg);
                comando.Parameters.AddWithValue("@CPF", cpf);
               
                int linhasAfetadas = comando.ExecuteNonQuery();

                return linhasAfetadas > 0 ? true : false;

            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao atualizar no MySql: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no Banco de dados" + ex);
            }
            finally
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }
        }
        public bool Exclusao()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = new (Conexao.ConnectionString);
                conexao.Open();
                
                string query = $"DELETE FROM Alunos WHERE Prontuario=@Prontuario";
                MySqlCommand comando = new (query, conexao);
                comando.Parameters.AddWithValue("@Prontuario", prontuario);

                int linhasAfetadas = comando.ExecuteNonQuery();

                // Verificando se alguma linha foi excluída
                return linhasAfetadas > 0 ? true : false;
              
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao deletar no MySql: " + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no Banco de dados" + ex);
            }
            finally
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }
        } 

    }
}
