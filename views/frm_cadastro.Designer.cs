namespace Agenda_Telefonica
{
    partial class frm_cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro));
            txt_senhadnv = new TextBox();
            txt_senha = new TextBox();
            txt_tel = new TextBox();
            txt_usuario = new TextBox();
            txt_nome = new TextBox();
            lbl_senhadnv = new Label();
            lbl_senha = new Label();
            lbl_tel = new Label();
            lbl_usuario = new Label();
            lbl_nome = new Label();
            btn_cadastro = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_senhadnv
            // 
            txt_senhadnv.Font = new Font("Segoe UI", 14F);
            txt_senhadnv.Location = new Point(212, 352);
            txt_senhadnv.Name = "txt_senhadnv";
            txt_senhadnv.Size = new Size(181, 32);
            txt_senhadnv.TabIndex = 3;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 14F);
            txt_senha.Location = new Point(212, 275);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(181, 32);
            txt_senha.TabIndex = 4;
            // 
            // txt_tel
            // 
            txt_tel.Font = new Font("Segoe UI", 14F);
            txt_tel.Location = new Point(212, 196);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(181, 32);
            txt_tel.TabIndex = 5;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 14F);
            txt_usuario.Location = new Point(212, 118);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(181, 32);
            txt_usuario.TabIndex = 6;
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 14F);
            txt_nome.Location = new Point(212, 42);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(181, 32);
            txt_nome.TabIndex = 7;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // lbl_senhadnv
            // 
            lbl_senhadnv.AutoSize = true;
            lbl_senhadnv.Font = new Font("Segoe UI", 10F);
            lbl_senhadnv.Location = new Point(212, 333);
            lbl_senhadnv.Name = "lbl_senhadnv";
            lbl_senhadnv.Size = new Size(98, 19);
            lbl_senhadnv.TabIndex = 8;
            lbl_senhadnv.Text = "Repita a senha";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 10F);
            lbl_senha.Location = new Point(212, 256);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(46, 19);
            lbl_senha.TabIndex = 9;
            lbl_senha.Text = "Senha";
            // 
            // lbl_tel
            // 
            lbl_tel.AutoSize = true;
            lbl_tel.Font = new Font("Segoe UI", 10F);
            lbl_tel.Location = new Point(211, 177);
            lbl_tel.Name = "lbl_tel";
            lbl_tel.Size = new Size(59, 19);
            lbl_tel.TabIndex = 10;
            lbl_tel.Text = "Telefone";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 10F);
            lbl_usuario.Location = new Point(211, 99);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(56, 19);
            lbl_usuario.TabIndex = 11;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 10F);
            lbl_nome.Location = new Point(211, 23);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(46, 19);
            lbl_nome.TabIndex = 12;
            lbl_nome.Text = "Nome";
            // 
            // btn_cadastro
            // 
            btn_cadastro.BackColor = Color.Khaki;
            btn_cadastro.FlatStyle = FlatStyle.Flat;
            btn_cadastro.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_cadastro.Location = new Point(155, 393);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(135, 48);
            btn_cadastro.TabIndex = 13;
            btn_cadastro.Text = "CADASTRAR";
            btn_cadastro.UseVisualStyleBackColor = false;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(305, 393);
            button2.Name = "button2";
            button2.Size = new Size(135, 48);
            button2.TabIndex = 14;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 151);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // frm_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(606, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(btn_cadastro);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_usuario);
            Controls.Add(lbl_tel);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_senhadnv);
            Controls.Add(txt_nome);
            Controls.Add(txt_usuario);
            Controls.Add(txt_tel);
            Controls.Add(txt_senha);
            Controls.Add(txt_senhadnv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_cadastro";
            Text = "frm_cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_senhadnv;
        private TextBox txt_senha;
        private TextBox txt_tel;
        private TextBox txt_usuario;
        private TextBox txt_nome;
        private Label lbl_senhadnv;
        private Label lbl_senha;
        private Label lbl_tel;
        private Label lbl_usuario;
        private Label lbl_nome;
        private Button btn_cadastro;
        private Button button2;
        private PictureBox pictureBox1;
    }
}