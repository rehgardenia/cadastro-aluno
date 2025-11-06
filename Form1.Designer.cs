namespace atvpoo
{
    partial class CadAlunos
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
            btnIncluir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProntuario = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtRG = new TextBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnIncluir
            // 
            btnIncluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluir.Location = new Point(340, 274);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(96, 34);
            btnIncluir.TabIndex = 0;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(34, 74);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 2;
            label1.Text = "Prontuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(34, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(34, 162);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(273, 166);
            label4.Name = "label4";
            label4.Size = new Size(30, 19);
            label4.TabIndex = 5;
            label4.Text = "RG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(34, 215);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 6;
            label5.Text = "E-mail";
            // 
            // txtProntuario
            // 
            txtProntuario.Location = new Point(131, 70);
            txtProntuario.Name = "txtProntuario";
            txtProntuario.Size = new Size(305, 23);
            txtProntuario.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(131, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(305, 23);
            txtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(131, 162);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 23);
            txtCPF.TabIndex = 10;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(311, 162);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(125, 23);
            txtRG.TabIndex = 11;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(29, 272);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 34);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // CadAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources._1557788543990_Professores;
            ClientSize = new Size(510, 368);
            Controls.Add(btnLimpar);
            Controls.Add(txtRG);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtProntuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIncluir);
            Name = "CadAlunos";
            Text = "Cadastro de Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIncluir;
        private Button btnLimpar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProntuario;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtRG;
    }
}
