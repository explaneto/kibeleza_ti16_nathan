using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_reserva : Form
    {
        public frm_reserva()
        {
            InitializeComponent();
        }

        private void frm_menu_principal_Load(object sender, EventArgs e)
        {
            pnl_info_reserva.Location = new Point(this.Width / 2 - pnl_info_reserva.Width / 2, this.Height / 2 - pnl_info_reserva.Height / 2);

            cal_reserva.MinDate = DateTime.Now;
            cal_reserva.MinDate = DateTime.Now.AddDays(31);

            carregar_funcionario();
            carregar_cliente();
            carregar_servico();

            if (variaveis.funcao == "EDITAR") ;
            {
                lbl_titulo.Text = "EDITAR RESERVA";
                carregar_dados_reserva();
                carergar_horario_disponivel();
            }

        }

        private void inserir_reserva()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `reserva`(`ìdReserva`, `obsReserva`, `dataReserva`, `horaReserva`, `statusReserva`, `idFuncionario`, `idCliente`, `idServico`";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@dataReserva", variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horaReserva", variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", variaveis.codServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("RESERVA CADASTRADA COM SUCESSO", "CADASTRO DA RESERVA");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO AO CADASTRAR A RESERVA\n\n" + erro, "erro");
            }
        }

        private void alterar_reserva()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `reserva` SET `obsReserva`=@obs, `dataReserva`=@dataReserva, `horarioReserva`=@horaReserva, `statusReserva`=@status, `idFuncionario`=@codFuncionario, `idCliente`=@codCliente, `idServico`=@codServico WHERE `idReserva`=@codigo";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@obs", variaveis.obsReserva);
                cmd.Parameters.AddWithValue("@dataReserva", variaveis.dataReserva.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horarioReserva", variaveis.horarioReserva.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@status", variaveis.statusReserva);
                cmd.Parameters.AddWithValue("@codFuncionario", variaveis.codFuncionario);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
                cmd.Parameters.AddWithValue("@codServico", variaveis.codServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("RESERVA CADASTRADA COM SUCESSO", "CADASTRO DA RESERVA");
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO AO CADASTRAR A RESERVA\n\n" + erro, "erro");
            }
        }

        private void carregar_dados_reserva()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT `idReserva`, `obsReserva`, `dataReserva`,DATE_FORMAT (`horaReserva`,`%H:i`) `statusReserva`, `idFuncionario`, `idCliente`, `idServico` FROM `reserva` INNER JOIN `funcinario` ON `reserva`.`idFuncionario` = `funcionario`.`idFuncionario` INNER JOIN `cliente` ON `reserva`.`idFuncionario` = `funcionario`.`idFuncionario` INNER JOIN `cliente` ON `reserva`.`idCliente` = `cliente`.`idCliente` INNER JOIN `servico` ON `reserva`.`idServico` = `servico`.`idServico` WHERE `idReserva` = @codigo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_reserva);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.obsReserva = reader.GetString(1);
                    variaveis.dataReserva = reader.GetDateTime(2);
                    variaveis.horarioReserva = DateTime.Parse(reader.GetString(3));
                    variaveis.statusReserva = reader.GetString(4);
                    variaveis.nomeFuncionario = reader.GetString(5);
                    variaveis.nomeCliente = reader.GetString(6);
                    variaveis.nomeServico = reader.GetString(7);

                    txt_codigo.Text = variaveis.cod_reserva.ToString();
                    txt_observacao.Text = variaveis.obsReserva;
                    cal_reserva.SelectionStart = variaveis.dataReserva;
                    cmb_horario.Text = variaveis.horarioReserva.ToString("HH:mm");
                    cmb_status.Text = variaveis.statusReserva;
                    cmb_funcionario.Text = variaveis.nomeFuncionario;
                    cmb_cliente.Text = variaveis.nomeCliente;
                    cmb_servico.Text = variaveis.nomeServico;
                }
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar dados da reserva \n\n" + erro, "ERRO");
            }
        }

        private void carregar_funcionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idFuncinario,nomeFuncionario FROM funcionario ORDER BY nomeFuncionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb_funcionario.DataSource = dt;
                cmb_funcionario.DisplayMember = "nomeFuncionario";
                cmb_funcionario.ValueMember = "idFuncionario";
                cmb_funcionario.SelectedIndex = -1;
                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO \n\n" + ex, "erro");
            }
        }

        private void carregar_cliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idCliente,nomeCliente FROM cliente ORDER BY nomeCliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb_funcionario.DataSource = dt;
                cmb_funcionario.DisplayMember = "nomeCliente";
                cmb_funcionario.ValueMember = "idCliente";
                cmb_funcionario.SelectedIndex = -1;
                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO \n\n" + ex, "erro");
            }
        }

        private void carregar_servico()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT idServico,nomeServico FROM servico ORDER BY nomeServico";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb_funcionario.DataSource = dt;
                cmb_funcionario.DisplayMember = "nomeServico";
                cmb_funcionario.ValueMember = "idServico";
                cmb_funcionario.SelectedIndex = -1;
                banco.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO \n\n" + ex, "erro");
            }
        }

        private void carergar_horario_disponivel()
        {
            try
            {
                banco.Conectar();
                var sql = "SELECT idHorarioReserva, DATE_FORMAT(horarioReserva, '%H:%i') FROM horarioreserva WHERE DATE_FORMAT(horarioReserva, '%H:%i') NOT IN (SELECT DATE_FORMAT(horaReserva, '%H:%i') FROM reserva WHERE idFuncionario = @codFuncionario AND dataReserva = @dataReserva AND NOT idReserva = @codReserva) ORDER BY horarioReserva";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codReserva", variaveis.cod_reserva);
                cmd.Parameters.AddWithValue("@codFuncionario", Convert.ToInt32(cmb_funcionario.SelectedValue));
                cmd.Parameters.AddWithValue("@dataReserva", Convert.ToDateTime(cal_reserva.SelectionStart.ToShortDateString()));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb_horario.DataSource = dt;
                cmb_horario.DisplayMember = "DATE_FORMAT(horarioReserva, '%H:%i')";
                cmb_horario.ValueMember = "idHoarioReserva";
                cmb_horario.SelectedIndex = -1;
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO \n\n" + ex, "erro");
            }


        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_menu_principal().Show();
            Close();
        }

        private void txt_observacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_funcionario.Enabled = true;
                cmb_funcionario.Focus();
            }
        }

        private void cmb_funcionario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            carergar_horario_disponivel();
        }

        private void cmb_funcionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_cliente.Enabled = true;
                carergar_horario_disponivel();
                cmb_cliente.Focus();
            }
        }

        private void cmb_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_cliente.Enabled = true;
                cmb_cliente.Focus();
            }
        }

        private void cmb_servico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_servico.Enabled = true;
                cmb_servico.Focus();
            }
        }

        private void cal_reserva_DateSelected(object sender, DateRangeEventArgs e)
        {
            variaveis.dataReserva = cal_reserva.SelectionStart;
            cmb_horario.Enabled = true;
            cmb_horario.Focus();
            carergar_horario_disponivel();
        }

        private void cmb_horario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_horario.Enabled = true;
                cmb_horario.Focus();
            }
        }

        private void cmb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_status.Enabled = true;
                cmb_status.Focus();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_observacao.Clear();
            cmb_funcionario.SelectedIndex = 1;
            cmb_status.SelectedIndex = 1;
            cmb_funcionario.SelectedIndex = 1;
            cmb_cliente.SelectedIndex = 1;
            cmb_servico.SelectedIndex = 1;

            txt_observacao.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_observacao.Text == String.Empty)
            {
                MessageBox.Show("Favor PREENCHER");
                txt_observacao.Focus();
            }
            else if (cmb_horario.Text == String.Empty)
            {
                MessageBox.Show("Favor PREENCHER");
                cmb_horario.Focus();
            }
            else if (cmb_status.Text == String.Empty)
            {
                MessageBox.Show("Favor PREENCHER");
                cmb_status.Focus();
            }
            else if (cmb_funcionario.Text == String.Empty)
            {
                MessageBox.Show("Favor PREENCHER");
                cmb_funcionario.Focus();
            }
            else if (cmb_cliente.Text == String.Empty)
            {
                MessageBox.Show("Favor PREENCHER");
                cmb_cliente.Focus();
            }
            else if (cmb_servico.Text == String.Empty)
            {
                MessageBox.Show("Favor PREENCHER");
                cmb_servico.Focus();
            }
            else
            {
                variaveis.obsReserva = txt_observacao.Text;
                variaveis.dataReserva = cal_reserva.SelectionStart;
                variaveis.horarioReserva = DateTime.Parse(cmb_horario.Text);
                variaveis.statusReserva = cmb_status.Text;
                variaveis.cod_funcionario = Convert.ToInt32(cmb_funcionario.SelectedValue);
                variaveis.cod_cliente = Convert.ToInt32(cmb_cliente.SelectedValue);
                variaveis.cod_servico = Convert.ToInt32(cmb_servico.SelectedValue);
            }
            if (variaveis.funcao == "AGENDAR")
            {
                inserir_reserva();
            }
            else if (variaveis.funcao == "EDITAR")
            {
                alterar_reserva();
            }
            btn_salvar.Enabled = false;
            btn_limpar.Enabled = false;
        }
    }
}
