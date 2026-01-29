namespace CadastroAluno
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();
                a.Rg = txtRG.Text;
                a.Nome = txtNome.Text;
                a.Cpf = txtCPF.Text;
                a.Email = txtEmail.Text;
                a.Prontuario = txtProntuario.Text;

                a.Incluir();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProntuario.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtEmail.Text = "";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();
                a.Prontuario = txtLocalizar.Text;

                if (a.Consultar())
                {
                    txtProntuario.Text = a.Prontuario;
                    txtNome.Text = a.Nome;
                    txtEmail.Text = a.Email;
                    txtCPF.Text = a.Cpf;
                    txtRG.Text = a.Rg;
                }
                else
                {
                    MessageBox.Show("Prontuário não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();
                a.Prontuario = txtProntuario.Text;
                a.Cpf = txtCPF.Text;
                a.Rg = txtRG.Text;
                a.Email = txtEmail.Text;
                a.Nome = txtNome.Text;

                if (a.Editar())
                {
                    MessageBox.Show("Aluno alterado com sucesso!");
                    txtProntuario.Text = a.Prontuario;
                    txtNome.Text = a.Nome;
                    txtEmail.Text = a.Email;
                    txtCPF.Text = a.Cpf;
                    txtRG.Text = a.Rg;
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o prontuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();
                a.Prontuario = txtLocalizar.Text;

                if (a.Exclusao())
                {
                    MessageBox.Show("Aluno excluído com sucessso!");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno!");
                }
               
            }
            catch(Exception ex){
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
