using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{

    public partial class frm_cad_empresa : Form
    {
        public frm_cad_empresa()
        {
            InitializeComponent();
        }

        private void carregar_dados_empresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresa` WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_empresa);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeEmpresa = dr.GetString(1);
                    variaveis.cnpjCpfEmpresa = dr.GetString(2);
                    variaveis.razaoSocialEmpresa = dr.GetString(3);
                    variaveis.emailEmpresa = dr.GetString(4);
                    variaveis.statusEmpresa = dr.GetString(5);
                    variaveis.dataCadastroEmpresa = dr.GetDateTime(6);
                    variaveis.horarioAtendEmpresa = DateTime.Parse(dr.GetString(7));

                    txt_codigo.Text = variaveis.cod_empresa.ToString();
                    txt_nome_empresa.Text = variaveis.nomeEmpresa;
                    mkd_cnpj.Text = variaveis.cnpjCpfEmpresa;
                    if (mkd_cnpj.Text.Length > 15)
                    {
                        cmb_documento.Text = "CNPJ";
                    }
                    else
                    {
                        cmb_documento.Text = "CPF";
                    }
                    txt_razao.Text = variaveis.razaoSocialEmpresa;
                    txt_email.Text = variaveis.emailEmpresa;
                    cmb_status.Text = variaveis.statusEmpresa;
                    mkd_data_cad.Text = variaveis.dataCadastroEmpresa.ToString("dd/MM/yyyy");
                    cmb_carga_horaria.Text = variaveis.horarioAtendEmpresa.ToString("HH:mm");
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da empresa. \n\n" + ex);
            }
        }

        private void inserir_empresa()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `empresa`(`idEmpresa`, `nomeFantasiaEmpresa`, `cnpjCpfEmpresa`, `razaoSocialEmpresa`, `emailEmpresa`, `statusEmpresa`, `dataCadEmpresa`, `horarioAtendEmpresa`) VALUES (DEFAULT,@nomeEmpresa,@cnpjCpf,@razaoSocial,@emailEmpresa,@statusEmpresa,@dataCadEmpresa,@horarioEmpresa);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeEmpresa", variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocial", variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@dataCadEmpresa", variaveis.dataCadastroEmpresa.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@horarioEmpresa", variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DA EMPRESA REALIZADO COM SUCESSO!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a empresa \n\n" + ex);
            }
        }

        private void alterar_empresa()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `empresa` SET `nomeFantasiaEmpresa`=@nomeEmpresa, `cnpjCpfEmpresa`=cnpjCpf, `razaoSocialEmpresa`=razaoSocial, `emailEmpresa`=@emailEmpresa, `statusEmpresa`=@statusEmpresa,`horarioAtendEmpresa`=@horarioEmpresa WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeEmpresa", variaveis.nomeEmpresa);
                cmd.Parameters.AddWithValue("@cnpjCpf", variaveis.cnpjCpfEmpresa);
                cmd.Parameters.AddWithValue("@razaoSocial", variaveis.razaoSocialEmpresa);
                cmd.Parameters.AddWithValue("@emailEmpresa", variaveis.emailEmpresa);
                cmd.Parameters.AddWithValue("@statusEmpresa", variaveis.statusEmpresa);
                cmd.Parameters.AddWithValue("@horarioEmpresa", variaveis.horarioAtendEmpresa.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_empresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DA EMPRESA REALIZADO COM SUCESSO!", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a empresa \n\n" + ex);
            }
        }

        private void inserir_fone_empresa()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `foneempresa`(`idFoneEmpresa`,`numeroEmpresa`,`operFoneEmpresa`,`descFoneEmpresa`,`idEmpresa`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codEmpresa);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codEmpresa", variaveis.cod_empresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA CADASTRADO COM SUCESSO!", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o telefone \n\n" + ex);
            }
        }

        private void carregar_ultima_empresa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX(idEmpresa) FROM `" + "empresa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.cod_empresa = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar última empresa \n\n" + ex);
            }
        }

        private void alterar_fone_empresa()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `foneempresa` SET `numeroEmpresa`=@numeroFone,`operFoneEmpresa`=@operFone,`descFoneEmpresa`=@descFone WHERE `idFoneEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneEmpresa);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraEmpresa);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoEmpresa);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_fone_empresa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DA EMPRESA ALTERADO COM SUCESSO!", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o telefone \n\n" + ex);
            }
        }

        private void carregar_telefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM foneempresa WHERE `idEmpresa`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_fone_empresa.DataSource = dt;
                dgv_fone_empresa.Columns[0].Visible = false;
                dgv_fone_empresa.Columns[1].HeaderText = "NÚMERO";
                dgv_fone_empresa.Columns[2].HeaderText = "OPERADORA";
                dgv_fone_empresa.Columns[3].HeaderText = "DESCRIÇÃO";
                dgv_fone_empresa.Columns[4].Visible = false;

                dgv_fone_empresa.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefone \n\n" + ex);
            }
        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_empresa().Show();
            Close();
        }

        private void frm_cad_empresa_Load(object sender, EventArgs e)
        {
            pnl_empresa.Location = new Point(this.Width / 2 - pnl_empresa.Width / 2, this.Height / 2 - pnl_empresa.Height / 2);
            cmb_documento.Text = "CNPJ";

            if (variaveis.funcao == "ALTERAR")
            {
                carregar_dados_empresa();
                lbl_titulo.Text = "ALTERAR EMPRESA";
            }

            if (txt_codigo.Text != "")
            {
                btn_salvar.Enabled = true;
                cmb_documento.Enabled = true;
                mkd_cnpj.Enabled = true;
                txt_razao.Enabled = true;
                txt_email.Enabled = true;
                cmb_status.Enabled = true;
                cmb_carga_horaria.Enabled = true;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome_empresa.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome da empresa");
                txt_nome_empresa.Focus();
            }
            else if (mkd_cnpj.MaskCompleted == false)
            {
                MessageBox.Show("Favor preencher completamente o número do documento");
                mkd_cnpj.Focus();
            }
            else if (txt_razao.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher razão social");
                txt_razao.Focus();
            }
            else if (txt_email.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email");
                txt_email.Focus();
            }
            else if (cmb_status.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmb_status.Focus();
            }
            else if (cmb_carga_horaria.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o horário");
                cmb_carga_horaria.Focus();
            }
            else
            {
                variaveis.nomeEmpresa = txt_nome_empresa.Text;
                variaveis.cnpjCpfEmpresa = mkd_cnpj.Text;
                variaveis.razaoSocialEmpresa = txt_razao.Text;
                variaveis.emailEmpresa = txt_email.Text;
                variaveis.statusEmpresa = cmb_status.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    inserir_empresa();
                    carregar_ultima_empresa();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    alterar_empresa();
                }
                pnl_empresa.Enabled = true;
                btn_salvar.Enabled = true;
                btn_limpar.Enabled = true;
            }
        }


        private void cmb_documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_documento.Text == "CNPJ")
            {
                mkd_cnpj.Mask = "00,000,000/0000-00";
            }
            else if (cmb_documento.Text == "CPF")
            {
                mkd_cnpj.Mask = "000,000,000-00";
            }
        }

        private void dgv_fone_empresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linha_selecionada = -1;
            variaveis.linha_selecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linha_selecionada >= 0)
            {
                variaveis.cod_fone_empresa = Convert.ToInt32(dgv_fone_empresa[0, variaveis.linha_selecionada].Value);
            }
        }

        private void dgv_fone_empresa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_fone_empresa.Sort(dgv_fone_empresa.Columns[1], ListSortDirection.Ascending);
            dgv_fone_empresa.ClearSelection();
        }
    }

}