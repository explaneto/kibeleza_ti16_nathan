using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txt_email.Clear();
                txt_senha.Clear();
                txt_email.Focus();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            pnl_login.Location = new Point(this.Width / 2 - pnl_login.Width / 2, this.Height / 2 - pnl_login.Height / 2);
        }

        private void lbl_email_Click(object sender, EventArgs e)
        {
            txt_email.Focus();
        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {
            txt_senha.Focus();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            variaveis.usuario = txt_email.Text;
            variaveis.senha = txt_senha.Text;

            if (variaveis.usuario == "URANO" && variaveis.senha == "1234")
            {
                variaveis.nivel = "ADMINISTRADOR";
                new frm_menu_principal().Show();
                Hide();
            }
            else
            {
                try
                {
                    banco.Conectar();
                    string selecionar = "SELECT `nomeFuncionario`, `emailFuncionario`, `senhaFuncionario`, `nivelFuncionario`, `statusFuncionario` FROM `funcionario` WHERE `emailFuncionario`=@email AND `senhaFuncionario`=@senha AND `statusFuncionario`=@status;";
                    MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                    cmd.Parameters.AddWithValue("@email", variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        variaveis.usuario = reader.GetString(0);
                        variaveis.nivel = reader.GetString(3);
                        new frm_menu_principal().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO");
                        txt_email.Clear();
                        txt_senha.Clear();
                        txt_email.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao selecionar usuário" + ex, "ERRO");
                }
            }
        }
        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_senha.Focus();
            }
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_entrar.Focus();
            }
        }
    }
}