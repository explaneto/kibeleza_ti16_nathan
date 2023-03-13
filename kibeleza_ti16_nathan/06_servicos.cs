using System;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_servicos : Form
    {
        public frm_servicos()
        {
            InitializeComponent();
        }

        private void pct_fechar_Click(object sender, EventArgs e)
        {
            new frm_menu_principal().Show();
            Close();
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            new frm_cad_servico().Show();
            Close();
        }
    }
}

