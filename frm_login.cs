namespace agenda_telefonica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_cadastro = new Button();
            lbl_login = new Label();
            txt_usuario = new TextBox();
            lbl_senha = new Label();
            label3 = new Label();
            btn_entrar = new Button();
            txt_senha = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_cadastro
            // 
            btn_cadastro.BackColor = Color.Khaki;
            btn_cadastro.FlatStyle = FlatStyle.Flat;
            btn_cadastro.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_cadastro.Location = new Point(178, 333);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(192, 39);
            btn_cadastro.TabIndex = 0;
            btn_cadastro.Text = "CADASTRE-SE";
            btn_cadastro.UseVisualStyleBackColor = false;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 10F);
            lbl_login.Location = new Point(177, 101);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(56, 19);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "Usuario";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 14F);
            txt_usuario.Location = new Point(178, 118);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(192, 32);
            txt_usuario.TabIndex = 2;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 10F);
            lbl_senha.Location = new Point(179, 177);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(46, 19);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha";
            lbl_senha.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(178, 318);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 4;
            label3.Text = "Não tem um cadastro? Cadastre-se";
            label3.Click += label3_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.Khaki;
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_entrar.Location = new Point(178, 249);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(192, 39);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "ENTRAR";
            btn_entrar.UseVisualStyleBackColor = false;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txt_senha.Location = new Point(178, 194);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(192, 32);
            txt_senha.TabIndex = 6;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.TextChanged += txt_senha_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(414, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 320);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 305);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 150);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(588, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_senha);
            Controls.Add(btn_entrar);
            Controls.Add(label3);
            Controls.Add(lbl_senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_login);
            Controls.Add(btn_cadastro);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastro;
        private Label lbl_login;
        private TextBox txt_usuario;
        private Label lbl_senha;
        private Label label3;
        private Button btn_entrar;
        private TextBox txt_senha;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
