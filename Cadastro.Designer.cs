namespace CadastroAluno
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnLimpar = new Button();
            txtProntuario = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtRG = new TextBox();
            label4 = new Label();
            txtCPF = new TextBox();
            label5 = new Label();
            btnIncluir = new Button();
            btnLocalizar = new Button();
            txtLocalizar = new TextBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 97);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Prontuario";
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = Color.FromArgb(0, 64, 64);
            btnLimpar.Location = new Point(502, 285);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(103, 32);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtProntuario
            // 
            txtProntuario.Location = new Point(139, 115);
            txtProntuario.Name = "txtProntuario";
            txtProntuario.Size = new Size(338, 23);
            txtProntuario.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(139, 166);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(338, 23);
            txtNome.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 148);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 23);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 205);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "E-mail";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(139, 291);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(158, 23);
            txtRG.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 273);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 7;
            label4.Text = "RG";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(312, 291);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(165, 23);
            txtCPF.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 273);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 9;
            label5.Text = "CPF";
            // 
            // btnIncluir
            // 
            btnIncluir.ForeColor = Color.FromArgb(0, 64, 64);
            btnIncluir.Location = new Point(502, 109);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(103, 32);
            btnIncluir.TabIndex = 11;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.ForeColor = Color.FromArgb(0, 64, 64);
            btnLocalizar.Location = new Point(502, 55);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(103, 23);
            btnLocalizar.TabIndex = 13;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(139, 55);
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(338, 23);
            txtLocalizar.TabIndex = 14;
            // 
            // btnExcluir
            // 
            btnExcluir.ForeColor = Color.FromArgb(0, 64, 64);
            btnExcluir.Location = new Point(502, 232);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(103, 32);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = Color.FromArgb(0, 64, 64);
            btnEditar.Location = new Point(502, 166);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 32);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.aluno_com_limite_de_graduacao;
            pictureBox1.Location = new Point(24, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(674, 378);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(txtLocalizar);
            Controls.Add(btnLocalizar);
            Controls.Add(pictureBox1);
            Controls.Add(btnIncluir);
            Controls.Add(txtCPF);
            Controls.Add(label5);
            Controls.Add(txtRG);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtProntuario);
            Controls.Add(btnLimpar);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLimpar;
        private TextBox txtProntuario;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtRG;
        private Label label4;
        private TextBox txtCPF;
        private Label label5;
        private Button btnIncluir;
        private Button btnLocalizar;
        private TextBox txtLocalizar;
        private Button btnExcluir;
        private Button btnEditar;
        private PictureBox pictureBox1;
    }
}
