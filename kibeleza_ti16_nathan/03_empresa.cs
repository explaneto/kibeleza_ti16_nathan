using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_empresa : Form
    {
        public frm_empresa()
        {
            InitializeComponent();
        }

        private void carregar_empresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresacompleta;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_empresa.DataSource = dt;

                dgv_empresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar todas as listas de empresa. \n \n" + ex);
            }
        }

        private void carregar_empresa_ativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresaativa;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_empresa.DataSource = dt;

                dgv_empresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista da empresa. \n \n" + ex);
            }
        }

        private void carregar_empresa_inativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresainativa;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_empresa.DataSource = dt;

                dgv_empresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista da empresa inativa. \n \n" + ex);
            }
        }

        private void carregar_empresa_nome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM empresacompleta WHERE 'NOME FANTASIA' LIKE '%" + variaveis.nomeEmpresa + "%';";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_empresa.DataSource = dt;

                dgv_empresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a lista da empresa inativa. \n \n" + ex);
            }
        }

        private void excluir_empresa()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `empresa` WHERE `idEmresa`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_empresa.DataSource = dt;
                dgv_empresa.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir empresa \n\n" + erro.Message);
            }
        }
        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_menu_principal().Show();
            Close();
        }

        private void frm_empresa_Load(object sender, EventArgs e)
        {
            pnl_empresa.Location = new Point(this.Width / 2 - pnl_empresa.Width / 2, this.Height / 2 - pnl_empresa.Height / 2);

            variaveis.linha_selecionada = -1;

            carregar_empresa();
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_status.Text == "ATIVA")
            {
                carregar_empresa_ativa();
            }
            else if (cmb_status.Text == "INATIVA")
            {
                carregar_empresa_inativa();
            }
            else
            {
                carregar_empresa();
            }
        }

        private void txt_empresa_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeEmpresa = txt_empresa.Text;

            if (variaveis.nomeEmpresa == "")
            {
                cmb_status.Enabled = true;
                cmb_status.Text = "TODOS";
                carregar_empresa();
            }
            else
            {
                cmb_status.Enabled = false;
                cmb_status.Text = "TODOS";
                carregar_empresa_nome();
            }
        }

        private void dgv_empresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linha_selecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linha_selecionada >= 0)
            {
                variaveis.cod_empresa = Convert.ToInt32(dgv_empresa[0, variaveis.linha_selecionada].Value);
            }

        }

        private void dgv_empresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_empresa.Sort(dgv_empresa.Columns[1], ListSortDirection.Ascending);
            dgv_empresa.ClearSelection();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linha_selecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frm_cad_empresa().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha");
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frm_cad_empresa().Show();
            Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linha_selecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir? ", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    excluir_empresa();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha");
            }
        }

    }
}
