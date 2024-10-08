using Agenda_Telefonica;

namespace agenda_telefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void habilitar_botao()
        {
            if (txt_usuario.Text != "" && txt_senha.Text.Length >= 8)
            {
                btn_cadastro.Enabled = true;
            }
            else
            {
                btn_cadastro.Enabled = false;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_cadastro formfrm_Cadastro = new frm_cadastro();
            formfrm_Cadastro.ShowDialog();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            habilitar_botao();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            habilitar_botao();

        }
    }
}
