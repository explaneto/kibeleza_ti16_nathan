using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{

    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }
        private void carregar_cliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientecompleto`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_cliente.DataSource = dt;
                dgv_cliente.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente \n\n" + erro.Message);
            }
        }

        private void carregar_cliente_ativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_cliente.DataSource = dt;
                dgv_cliente.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente \n\n" + erro.Message);
            }
        }

        private void carregar_cliente_inativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clienteinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_cliente.DataSource = dt;
                dgv_cliente.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente \n\n" + erro.Message);
            }
        }

        private void carregar_cliente_nome()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientecompleto` WHERE `NOME CLIENTE` LIKE `%" + variaveis.nomeCliente + "%´";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_cliente.DataSource = dt;
                dgv_cliente.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o cliente \n\n" + erro.Message);
            }
        }

        private void excluir_cliente()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `cliente` WHERE `idCliente`=@codigo";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_cliente.DataSource = dt;
                dgv_cliente.ClearSelection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o cliente \n\n" + erro.Message);
            }
        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_menu_principal().Show();
            Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frm_cad_cliente().Show();
            Hide();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (variaveis.linha_selecionada >= 0)
            {
                variaveis.funcao = "ALTERAR";
                new frm_cad_cliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linha_selecionada >= 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir o cliente?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    excluir_cliente();
                    carregar_cliente();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha");
            }
        }

        private void dgv_cliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_cliente.Sort(dgv_cliente.Columns[1], ListSortDirection.Ascending);
            dgv_cliente.ClearSelection();
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {
            pnl_cliente.Location = new Point(this.Width / 2 - pnl_cliente.Width / 2, this.Height / 2 - pnl_cliente.Height / 2);
            carregar_cliente();
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_status.Text == "ATIVO")
            {
                carregar_cliente_ativo();
            }
            else if (cmb_status.Text == "INATIVO")
            {
                carregar_cliente_inativo();
            }
            else
            {
                carregar_cliente();
            }
        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_cliente.Text == "")
            {
                cmb_status.Enabled = true;
                carregar_cliente();
            }
            else
            {
                cmb_status.Text = "TODOS";
                cmb_status.Enabled = false;
                variaveis.nomeCliente = txt_cliente.Text;
                carregar_cliente_nome();
            }
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linha_selecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linha_selecionada >= 0)
            {
                variaveis.cod_cliente = Convert.ToInt32(dgv_cliente[0, variaveis.linha_selecionada].Value);
            }
        }
    }
}