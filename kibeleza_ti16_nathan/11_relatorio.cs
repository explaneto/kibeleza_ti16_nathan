using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_relatorio : Form
    {
        public frm_relatorio()
        {
            InitializeComponent();
        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_menu_principal().Show();
            Close();
        }

        private void carregar_cliente_telefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientetelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection(); 
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
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
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void carregar_cliente_inativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `clientetelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void carregar_empresa_telefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresatelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void carregar_empresa_ativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresaativa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void carregar_empresa_inativa()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `empresainativa`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void carregar_funcionario_telefone()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionariotelefone`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void carregar_funcionario_ativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void carregar_funcionario_inativo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM `funcionarioinativo`";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_relatorio.DataSource = dt;
                dgv_relatorio.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO \n\n" + erro.Message);
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (rad_ativo.Checked == true && rad_ativo.Checked == true)
            {
                carregar_cliente_ativo();
                variaveis.relatorio = "Cliente Ativo";
            }
            else if (rad_cliente.Checked == true && rad_inativo.Checked == true)
            {
                carregar_cliente_inativo();
                variaveis.relatorio = "Cliente inativo";
            }
            else if (rad_cliente.Checked == true && rad_telefone.Checked == true)
            {
                carregar_cliente_telefone();
                variaveis.relatorio = "Cliente telefone";
            }
            else if (rad_empresa.Checked == true && rad_ativo.Checked == true)
            {
                carregar_empresa_ativa();
                variaveis.relatorio = "empresa Ativo";
            }
            else if (rad_empresa.Checked == true && rad_inativo.Checked == true)
            {
                carregar_empresa_inativa();
                variaveis.relatorio = "empresa inativo";
            }
            else if (rad_empresa.Checked == true && rad_telefone.Checked == true)
            {
                carregar_empresa_telefone();
                variaveis.relatorio = "empresa telefone";
            }
            else if (rad_funcionario.Checked == true && rad_ativo.Checked == true)
            {
                carregar_funcionario_ativo();
                variaveis.relatorio = "funcionario Ativo";
            }
            else if (rad_funcionario.Checked == true && rad_inativo.Checked == true)
            {
                carregar_funcionario_inativo();
                variaveis.relatorio = "funcionario inativo";
            }
            else if (rad_funcionario.Checked == true && rad_ativo.Checked == true)
            {
                carregar_funcionario_telefone();
                variaveis.relatorio = "funcionario telefone";
            }
            else
            {
                MessageBox.Show("SELECIONE UMA LINHA");
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (dgv_relatorio.Rows.Count > 0)
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "PDF (*.pdf)|*.pdf";
                salvar.InitialDirectory = @"C:\xampp\htdocs\kibelezati16\admin";
                salvar.FileName = variaveis.relatorio + ".pdf";
                bool fileError = false;
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(salvar.FileName))
                    {
                        try
                        {
                            File.Delete(salvar.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("ERRO AO GRAVAR DADOS" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv_relatorio.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgv_relatorio.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv_relatorio.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(salvar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph titulo = new Paragraph();
                                titulo.Add("RELATORIO " + variaveis.relatorio + "\n\n");
                                pdfDoc.Add(titulo);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("DADOS EXPORTADOS COM SUCESSO", "INFO");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Erro :" + ex.Message);
                        }

                        
                    }
                }
            }
            else
            {
                MessageBox.Show("ERRO NA EXPORTAÇÃO");
            }
        }
    }
}
