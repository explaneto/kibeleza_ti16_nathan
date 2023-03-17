using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_menu_principal : Form
    {
        int hora = DateTime.Now.Hour;
        int click_reserva;
        public frm_menu_principal()
        {

            InitializeComponent();
        }

        private void pct_sair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja sair?", "SAIR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                new frm_login().Show();
                Close();
            }
        }

        private void frm_menu_principal_Load(object sender, EventArgs e)
        {
            pnl_menu_principal.Location = new Point(this.Width / 2 - pnl_menu_principal.Width / 2, this.Height / 2 - pnl_menu_principal.Height / 2);

            timer1.Start();

            cmb_status.SelectedIndex = 0;
            variaveis.linha_selecionada = -1;
            carregar_reserva();


            if (hora >= 6 && hora < 12)
            {
                lbl_mensagem.Text = "Bom dia " + variaveis.usuario + "!";
            }
            else if (hora >= 12 && hora < 18)
            {
                lbl_mensagem.Text = "Boa tarde " + variaveis.usuario + "!";
            }
            else
            {
                lbl_mensagem.Text = "Boa noite " + variaveis.usuario + "!";
            }
            if (variaveis.nivel != "ADMINISTRADOR")
            {
                pct_funcionario.Enabled = false;
                pct_empresa.Enabled = false;
            }
            else
            {
                pct_funcionario.Enabled = true;
                pct_empresa.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pct_reserva_Click(object sender, EventArgs e)
        {
            if (click_reserva == 0)
            {
                // pct_reserva.BackColor = Color.FromArgb(152, 56, 93);
                btn_agendar.Visible = true;
                btn_aguardar.Visible = true;
                btn_aprovar.Visible = true;
                btn_cancelar.Visible = true;
                btn_editar.Visible = true;
                btn_finalizar.Visible = true;
                click_reserva = 1;
            }
            else
            {
                esconder_botoes();
            }
        }

        private void esconder_botoes()
        {
            //pct_reserva.BackColor = Color.FromArgb(81, 10, 44);
            btn_agendar.Visible = false;
            btn_aguardar.Visible = false;
            btn_aprovar.Visible = false;
            btn_cancelar.Visible = false;
            btn_editar.Visible = false;
            btn_finalizar.Visible = false;
            click_reserva = 0;
        }

        private void btn_aprovar_Click(object sender, EventArgs e)
        {
            esconder_botoes();

            variaveis.statusReserva = "APROVADA";
            alterar_status();
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = txt_cliente.Text;
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void btn_aguardar_Click(object sender, EventArgs e)
        {
            esconder_botoes();

            variaveis.statusReserva = "APROVADA";
            alterar_status();
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = txt_cliente.Text;
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            esconder_botoes();

            variaveis.statusReserva = "APROVADA";
            alterar_status();
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = txt_cliente.Text;
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            esconder_botoes();

            variaveis.statusReserva = "APROVADA";
            alterar_status();
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = txt_cliente.Text;
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            esconder_botoes();

            variaveis.statusReserva = "APROVADA";
            alterar_status();
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = txt_cliente.Text;
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            esconder_botoes();

            variaveis.statusReserva = "CANCELADA";
            alterar_status();
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = txt_cliente.Text;
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void pct_empresa_Click(object sender, EventArgs e)
        {
            new frm_empresa().Show();
            Hide();
        }

        private void pct_funcionario_Click(object sender, EventArgs e)
        {
            new frm_funcionario().Show();
            Hide();
        }

        private void pct_cliente_Click(object sender, EventArgs e)
        {
            new frm_cliente().Show();
            Hide();
        }

        private void pct_servicos_Click(object sender, EventArgs e)
        {
            new frm_servicos().Show();
            Hide();
        }

        private void pct_relatorio_Click(object sender, EventArgs e)
        {
            new frm_relatorio().Show();
            Hide();
        }

        private void lbl_sobre_Click(object sender, EventArgs e)
        {
            new frm_sobre().Show();
            Hide();
        }

        private void alterar_status()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `reserva` SET `statusReserva`=@status WHERE `idReserva`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@status", variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_reserva);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_reserva.DataSource = dt;

                dgv_reserva.ClearSelection();

                MessageBox.Show("A reserva " + variaveis.cod_reserva + " foi alterada para " + variaveis.statusReserva);

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO AO ALTERAR. \n\n" + erro.Message);
            }
        }

        private void carregar_reserva_status()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `reservadata` WHERE `STATUS` = @status AND `CLIENTE` LIKE '%" + variaveis.nomeCliente + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@status", variaveis.statusReserva);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_reserva.DataSource = dt;
                dgv_reserva.Columns[0].Visible = false;
                dgv_reserva.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar. \n\n" + erro.Message);
            }
        }

        private void carregar_reserva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `reservadata` WHERE `CLIENTE` LIKE '%" + variaveis.nomeCliente + "%'";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@status", variaveis.statusReserva);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_reserva.DataSource = dt;
                dgv_reserva.Columns[0].Visible = false;
                dgv_reserva.ClearSelection();

                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar. \n\n" + erro.Message);
            }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = txt_cliente.Text;   
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {
            variaveis.statusReserva = cmb_status.Text;
            variaveis.nomeCliente = cmb_status.Text;
            if (variaveis.statusReserva == "TODAS")
            {
                carregar_reserva();
            }
            else
            {
                carregar_reserva_status();
            }
        }

        private void dgv_reserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linha_selecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linha_selecionada >= 0)
            {
                variaveis.cod_reserva = Convert.ToInt32(dgv_reserva[0, variaveis.linha_selecionada].Value);
            }
        }

        private void dgv_reserva_ColumnHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_reserva.Sort(dgv_reserva.Columns[1], ListSortDirection.Ascending);
            dgv_reserva.ClearSelection();
        }

    }
}
