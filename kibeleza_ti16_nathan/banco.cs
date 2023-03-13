using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public static class banco
    {
        public static string db = "SERVER=localhost;USER=root;DATABASE=kibelezati16";

        public static MySqlConnection conexao;

        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao iniciar conexão com o banco de dados...", "ERRO AO CONECTAR");
            }
        }

        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao fechar conexão com o banco de dados...", "ERRO AO DESCONECTAR");
            }
        }
    }
}
