using System;
using System.Drawing;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_cad_funcionario : Form
    {
        public frm_cad_funcionario()
        {
            InitializeComponent();
        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_funcionario().Show();
            Hide();
        }

        private void frm_cad_funcionario_Load(object sender, EventArgs e)
        {
            pnl_funcionario.Location = new Point(this.Width / 2 - pnl_funcionario.Width / 2, this.Height / 2 - pnl_funcionario.Height / 2);
            if (txt_codigo.Text != "")
            {
                pnl_fone.Enabled = true;
                btn_salvar.Enabled = true;
                txt_email.Enabled = true;
                txt_senha.Enabled = true;
                cmb_nivel.Enabled = true;
                cmb_status.Enabled = true;
                cmb_carga.Enabled = true;
                cmb_empresa.Enabled = true;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }
    }

}
