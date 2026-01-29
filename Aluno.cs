using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


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

        // metodo incluirAluno

        public void Incluir()
        {
            SqlConnection conexao = new SqlConnection();
            try
            {
                conexao.ConnectionString = "Data Source=localhost;Initial Catalog=dbAcademico;Integrated Security=True;";
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Alunos(Prontuario, Nome, Email, CPF, RG) VALUES (@Prontuario, @Nome, @Email, @CPF, @RG) ";
                comando.Parameters.AddWithValue("@Prontuario", prontuario);
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@RG", rg);
                comando.Parameters.AddWithValue("@CPF", cpf);
                conexao.Open();
                comando.ExecuteScalar();

                MessageBox.Show("Aluno incluido com sucessso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) {

                throw new Exception("Erro no Banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }

        }
        public bool Consultar()
        {

            SqlConnection conexao = new SqlConnection();
            try
            {
                conexao.ConnectionString = "Data Source=localhost;Initial Catalog=dbAcademico;Integrated Security=True;";
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT Prontuario, Nome, Email, CPF, RG FROM Alunos WHERE Prontuario = @Prontuario";
                comando.Parameters.AddWithValue("@Prontuario", prontuario);
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (!dr.Read()) {
                    return false;
                }
                // Prencher as localizações
                this.nome = dr["Nome"].ToString();
                this.cpf = dr["CPF"].ToString();
                this.rg = dr["RG"].ToString();
                this.email = dr["Email"].ToString();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no Banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }

        }
        public bool Editar()
        {
            SqlConnection conexao = new SqlConnection();
            try
            {
                conexao.ConnectionString = "Data Source=localhost;Initial Catalog=dbAcademico;Integrated Security=True;";
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"UPDATE Alunos SET Prontuario=@Prontuario, Nome=@Nome, Email=@Email, CPF=@CPF, RG=@RG WHERE Prontuario=@Prontuario;";
                comando.Parameters.AddWithValue("@Prontuario", prontuario);
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@RG", rg);
                comando.Parameters.AddWithValue("@CPF", cpf);
                
                conexao.Open();

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no Banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool Exclusao()
        {
            SqlConnection conexao = new SqlConnection();
            try
            {
                conexao.ConnectionString = "Data Source=localhost;Initial Catalog=dbAcademico;Integrated Security=True;";
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"DELETE FROM Alunos WHERE Prontuario=@prontuario";
                comando.Parameters.AddWithValue("@Prontuario", prontuario);
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                // Verificando se alguma linha foi excluída
                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no Banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }
        } 

    }
}
