namespace atvpoo
{
    public partial class CadAlunos : Form
    {
        public CadAlunos()
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

                MessageBox.Show("Aluno incluido com sucessso!","SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { 
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
    }
}
