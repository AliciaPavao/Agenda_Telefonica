using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_telefonica.data
{
    internal class conexaoDb
    {
        static public MySqlConnetion CriarConexao()
        {
            string stringConexao = "Server=localhost;Database=lista_telefonica;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }
}
