using agenda_telefonica;
using agenda_telefonica.data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class frm_cadastro : Form
    {


        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void habilitar_texto()
        {
            if (txt_nome.Text != "" && txt_usuario.Text != "" && txt_senha.Text != "" && txt_senha.Text.Length >=8 && txt_senhadnv.Text != "") 
            {
                btn_cadastro.Enabled = true;
            }
            else
            {
                btn_cadastro.Enabled = false;
            }
        }

        private void frm_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 formForm1 = new Form1();
            formForm1.ShowDialog();

        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = conexaoDb.CriarConexao();

            //abrindo conexão
            conexao.Open();

            //criando o comando SQL para inserir o usuário
            string sql = $"INSERT INTO tbusuarios(nome, usuario, telefone, senha) values(@nome, @usuario, @telefone, @senha)";

            //criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txt_nome.Text);
            comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);
            comando.Parameters.AddWithValue("@telefone", txt_tel.Text);
            comando.Parameters.AddWithValue("@senha", txt_senha.Text);

            //executando a instrução SQL no banco
            comando.ExecuteNonQuery();

            //fechando a conexão com o banco
            conexao.Close();

            MessageBox.Show("Cadastro efetuado com sucesso");
            this.Close();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
