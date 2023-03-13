using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_cad_cliente : Form
    {
        public frm_cad_cliente()
        {
            InitializeComponent();
        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_cliente().Show();
            Close();
        }

        private void carregar_dados_ciente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `cliente` WHERE `idCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_cliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.nomeCliente = dr.GetString(1);
                    variaveis.emailCliente = dr.GetString(2);
                    variaveis.senhaCliente = dr.GetString(3);
                    variaveis.statusCliente = dr.GetString(4);
                    variaveis.dataCadastroCliente = dr.GetDateTime(5);
                    variaveis.fotoCliente = dr.GetString(6);
                    variaveis.fotoCliente = variaveis.fotoCliente.Remove(0, 8);

                    txt_codigo.Text = variaveis.cod_cliente.ToString();
                    txt_nome.Text = variaveis.nomeCliente;
                    txt_email.Text = variaveis.emailCliente;
                    txt_senha.Text = variaveis.senhaCliente;
                    cmb_status.Text = variaveis.statusCliente;
                    mkd_data_cad.Text = variaveis.dataCadastroCliente.ToString("dd/MM/yyyy");
                    btn_foto.Image = ByteToImage(GetImgToByte(variaveis.enderecoServidorFtp + "cliente/" + variaveis.fotoCliente));
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Cliente \n\n" + ex);
            }
        }

        private void frm_cad_cliente_Load(object sender, EventArgs e)
        {
            pnl_cliente.Location = new Point(this.Width / 2 - pnl_cliente.Width / 2, this.Height / 2 - pnl_cliente.Height / 2);
            variaveis.atFotoCliente = "N";

            if (variaveis.funcao == "ALTERAR")
            {
                carregar_dados_ciente();
                carregar_telefones();
                lbl_titulo.Text = "ALTERAR CLIENTE";
            }

            if (txt_codigo.Text != "")
            {
                pnl_fone_cliente.Enabled = true;
                btn_salvar.Enabled = true;
                txt_email.Enabled = true;
                txt_senha.Enabled = true;
                cmb_status.Enabled = true;
                btn_foto.Enabled = true;
            }
        }

        private bool validar_FTP()
        {
            if (string.IsNullOrEmpty(variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(variaveis.usuarioFtp) || string.IsNullOrEmpty(variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpCliente = new WebClient();
            ftpCliente.Credentials = new NetworkCredential(variaveis.usuarioFtp, variaveis.senhaFtp);
            byte[] imageToByte = ftpCliente.DownloadData(caminhoArquivoFtp);
            return imageToByte;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void inserir_cliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `cliente`(`idCliente`,`nomeCliente`,`emailCliente`,`senhaCliente`,`statusCliente`,`dataCadCliente`,`fotoCliente`) VALUES (DEFAULT,@nomeCliente,@emailCliente,@senhaCliente,@statusCliente,@dataCadCliente,@fotoCliente);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@dataCadCliente", variaveis.dataCadastroCliente.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@fotoCliente", variaveis.fotoCliente);
                cmd.ExecuteNonQuery();

                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO !", "CADASTRO");
                banco.Desconectar();

                if (validar_FTP())
                {
                    if (!string.IsNullOrEmpty(variaveis.fotoCliente))
                    {
                        string urlEnviarArquivo = variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(variaveis.fotoCliente);

                        try
                        {
                            ftp.EnviarArquivoFtp(variaveis.caminhoFotoCliente, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Foto não selecionada ou foto já existente no servidor \n\n" + ex, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Cliente \n\n" + ex);
            }
        }

        private void alterar_cliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `cliente` SET `nomeCliente`=@nomeCliente,`emailCliente`=@emailCliente,`senhaCliente`=@senhaCliente,´statusCliente`=@statusCliente WHERE `idCliente`= @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@emailCliente", variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senhaCliente", variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_cliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO CLIENTE REALIZADO COM SUCESSO !", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Cliente \n\n" + ex);
            }
        }

        private void alterar_foto_cliente()
        {
            banco.Conectar();
            string alterar = "UPDATE `cliente` SET ´fotoCliente`=@fotoCliente WHERE `idCliente`= @codigo;";
            MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
            cmd.Parameters.AddWithValue("@fotoCliente", variaveis.fotoCliente);
            cmd.Parameters.AddWithValue("@codigo", variaveis.cod_cliente);
            cmd.ExecuteNonQuery();
            banco.Desconectar();

            if (validar_FTP())
            {
                if (!string.IsNullOrEmpty(variaveis.fotoCliente))
                {
                    string urlEnviarArquivo = variaveis.enderecoServidorFtp + "cliente/" + Path.GetFileName(variaveis.fotoCliente);
                    try
                    {
                        ftp.EnviarArquivoFtp(variaveis.caminhoFotoCliente, urlEnviarArquivo, variaveis.usuarioFtp, variaveis.senhaFtp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Foto não selecionada ou foto ja existente no servidor \n\n" + ex, "Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void inserir_fone_cliente()
        {
            try
            {
                banco.Conectar();
                string inserir = "INSERT INTO `fonecliente`(`idFoneCliente`,`numeroCliente`,`operFoneCliente`,`descFoneCliente`,`idCliente`) VALUES (DEFAULT,@numeroFone,@operFone,@descFone,@codCliente);";
                MySqlCommand cmd = new MySqlCommand(inserir, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operFoneCliente);
                cmd.Parameters.AddWithValue("@descFone", variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.cod_cliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE CADASTRADO COM SUCESSO !", "CADASTRO");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o Telefone \n\n" + ex);
            }
        }

        private void alterar_fone_cliente()
        {
            try
            {
                banco.Conectar();
                string alterar = "UPDATE `fonecliente` SET `numeroCliente`=@numeroFone,`operFoneCliente`=@operFone,`descFoneCliente`=@descFone WHERE `idFoneCliente`= @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, banco.conexao);
                cmd.Parameters.AddWithValue("@numeroFone", variaveis.numeroFoneCliente);
                cmd.Parameters.AddWithValue("@operFone", variaveis.operadoraCliente);
                cmd.Parameters.AddWithValue("@descCliente", variaveis.descricaoCliente);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_fone_cliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TELEFONE DO CLIENTE ALTERADO COM SUCESSO !", "ALTERAR");
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Telefone \n\n" + ex);
            }
        }

        private void carregar_ultimo_cliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT MAX (idCliente) FROM `cliente`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.cod_cliente = dr.GetInt32(0);
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar ultimo cliente \n\n" + ex);
            }
        }

        private void carregar_telefones()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM fonecliente WHERE `idCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_empresa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_fone_cliente.DataSource = dt;
                dgv_fone_cliente.Columns[0].Visible = false;
                dgv_fone_cliente.Columns[1].HeaderText = "NÚMERO";
                dgv_fone_cliente.Columns[2].HeaderText = "OPERADORA";
                dgv_fone_cliente.Columns[3].HeaderText = "DESCRIÇÃO";
                dgv_fone_cliente.Columns[4].Visible = false;

                dgv_fone_cliente.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar telefones \n\n" + ex);
            }
        }

        private void carregar_fone_cliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `fonecliente` WHERE `idFoneCliente`=@codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", variaveis.cod_fone_cliente);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    variaveis.cod_fone_cliente = dr.GetInt32(0);
                    variaveis.numeroFoneCliente = dr.GetString(1);
                    variaveis.operadoraCliente = dr.GetString(2);
                    variaveis.descricaoCliente = dr.GetString(3);
                    variaveis.cod_cliente = dr.GetInt32(4);
                    txt_codigo.Text = variaveis.cod_fone_cliente.ToString();
                    mkd_fone.Text = variaveis.numeroFoneCliente;
                    cmb_operadora.Text = variaveis.operadoraCliente;
                    txt_descricao.Text = variaveis.descricaoCliente;
                }
                banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do Telefone \n\n" + ex);
            }
        }

        private void excluir_fone_cliente()
        {
            try
            {
                banco.Conectar();
                string excluir = "DELETE FROM `fonecliente` WHERE `idFoneCliente`=@codFone";
                MySqlCommand cmd = new MySqlCommand(excluir, banco.conexao);
                cmd.Parameters.AddWithValue("@codFone", variaveis.cod_fone_cliente);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_fone_cliente.DataSource = dt;
                dgv_fone_cliente.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir o Telefone do Cliente \n\n" + erro.Message);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o nome do cliente");
                txt_nome.Focus();
            }
            else if (txt_email.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher o email");
                txt_email.Focus();
            }
            else if (txt_senha.Text == String.Empty)
            {
                MessageBox.Show("Favor preencher a senha");
                txt_senha.Focus();
            }
            else if (cmb_status.Text == String.Empty)
            {
                MessageBox.Show("Favor selecionar o status");
                cmb_status.Focus();
            }
            else
            {
                variaveis.nomeCliente = txt_nome.Text;
                variaveis.emailCliente = txt_email.Text;
                variaveis.senhaCliente = txt_senha.Text;
                variaveis.statusCliente = cmb_status.Text;

                if (variaveis.funcao == "CADASTRAR")
                {
                    mkd_data_cad.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    variaveis.dataCadastroCliente = DateTime.Parse(mkd_data_cad.Text);
                    inserir_cliente();
                    carregar_ultimo_cliente();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    alterar_cliente();
                    if (variaveis.atFotoCliente == "S")
                    {
                        alterar_foto_cliente();
                    }
                }
                pnl_fone_cliente.Enabled = true;
                btn_salvar.Enabled = true;
                btn_limpar.Enabled = true;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR TELEFONE";
            pnl_fone_cliente.Visible = true;
            pnl_fone_cliente.Location = new Point(this.Width / 2 - pnl_fone_cliente.Width / 2, this.Height / 2 - pnl_fone_cliente.Height / 2);
            pnl_cliente.Enabled = false;
            mkd_fone.Focus();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR TELEFONE";
            pnl_fone_cliente.Visible = true;

            carregar_fone_cliente();


            pnl_fone_cliente.Location = new Point(this.Width / 2 - pnl_fone_cliente.Width / 2, this.Height / 2 - pnl_fone_cliente.Height / 2);
            pnl_cliente.Enabled = false;
            mkd_fone.Focus();
        }

        private void btn_fechar_fone_Click(object sender, EventArgs e)
        {
            pnl_cliente.Enabled = true;
            carregar_telefones();
            pnl_fone_cliente.Visible = true;
            pnl_fone_cliente.Location = new Point(this.Width / 2 - pnl_fone_cliente.Width / 2, this.Height / 2 - pnl_fone_cliente.Height / 2);
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_status.Enabled = true;
                cmb_status.Focus();
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_nome.Enabled = true;
                txt_nome.Focus();
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_email.Enabled = true;
                txt_email.Focus();
            }
        }

        private void cmb_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_foto.Enabled = true;
                btn_foto.Focus();
            }
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd_foto = new OpenFileDialog();
                ofd_foto.Multiselect = false;
                ofd_foto.FileName = "";
                ofd_foto.InitialDirectory = @"C:";
                ofd_foto.Title = "SELECIONAR UMA FOTO";
                ofd_foto.Filter = "JPG ou PNG (* .jpg ou *.png)|*.jpg;*.png";
                ofd_foto.CheckFileExists = true;
                ofd_foto.CheckPathExists = true;
                ofd_foto.RestoreDirectory = true;

                DialogResult dr = ofd_foto.ShowDialog();
                btn_foto.Image = Image.FromFile(ofd_foto.FileName);

                if (ofd_foto.FileName.Substring(ofd_foto.FileName.Length - 8) == "user.png")
                {
                    variaveis.fotoCliente = "cliente/user.png";
                }
                else
                {
                    variaveis.fotoCliente = "cliente/" + Regex.Replace(txt_nome.Text, @"\s", "").ToLower() + ".png";
                }
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        variaveis.atFotoCliente = "S";
                        variaveis.caminhoFotoCliente = ofd_foto.FileName;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show("ERRO DE SEGURANÇA - FALE COM O ADM \n MENSAGEM: " + ex + "\nDetalhe: \n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("VOCÊ NÃO TEM PERMISSÃO. \nDetalhe: " + ex);
                    }
                }
                btn_salvar.Enabled = true;
                btn_salvar.Focus();
            }
            catch
            {
                btn_salvar.Enabled = true;
                btn_salvar.Focus();
            }

        }

        private void mkd_fone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmb_operadora.Enabled = true;
                cmb_operadora.Focus();
            }
        }

        private void cmb_operadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_descricao.Enabled = true;
                txt_descricao.Focus();
            }
        }

        private void txt_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_salvar_fone.Enabled = true;
                btn_salvar_fone.Focus();
            }
        }

        private void btn_salvar_KeyPress(object sender, EventArgs e)
        {
            if (mkd_fone.MaskCompleted == false)
            {
                MessageBox.Show("PREENCHER O FONE");
                mkd_fone.Focus();
            }
            else if (cmb_operadora.Text == "")
            {
                MessageBox.Show("PREENCHER A OPERADORA");
                cmb_operadora.Focus();
            }
            else if (txt_descricao.Text == "")
            {
                MessageBox.Show("PREENCHER O FONE");
                txt_descricao.Focus();
            }
            else
            {
                variaveis.numeroFoneCliente = mkd_fone.Text;
                variaveis.operadoraCliente = cmb_operadora.Text;
                variaveis.descricaoCliente = txt_descricao.Text;

                if (variaveis.funcao == "CADASTRAR FONE")
                {
                    inserir_fone_cliente();
                }
                if (variaveis.funcao == "ALTERAR FONE")
                {
                    alterar_fone_cliente();
                }
            }
            btn_limpar_fone.PerformClick();
        }

        private void dgv_fone_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linha_selecionada = -1;
            variaveis.linha_selecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linha_selecionada >= 0)
            {
                variaveis.cod_fone_cliente = Convert.ToInt32(dgv_fone_cliente[0, variaveis.linha_selecionada].Value);
                txt_codigo_fone.Text = variaveis.cod_fone_cliente.ToString();
            }
        }

        private void dgv_fone_cliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_fone_cliente.Sort(dgv_fone_cliente.Columns[1], ListSortDirection.Ascending);
            dgv_fone_cliente.ClearSelection();
        }

        private void btn_limpar_fone_Click(object sender, EventArgs e)
        {
            mkd_fone.Text = String.Empty;
            cmb_operadora.Text = String.Empty;
            txt_descricao.Text = String.Empty;
            cmb_operadora.Enabled = false;
            txt_descricao.Enabled = false;
            btn_salvar_fone.Enabled = false;
            mkd_fone.Focus();

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
            cmb_status.SelectedIndex = -1;
            mkd_data_cad.Clear();
            btn_foto.Image = Properties.Resources.semimagem;

            txt_nome.Focus();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linha_selecionada >= 0)
            {
                var resultado = MessageBox.Show("DESEJA REALMENTE EXCLUIR?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    excluir_fone_cliente();
                    carregar_telefones();
                }
            }
            else
            {
                MessageBox.Show("PARA EXCLUIR SELECIONE UMA LINHA");
            }
        }

    }
}
