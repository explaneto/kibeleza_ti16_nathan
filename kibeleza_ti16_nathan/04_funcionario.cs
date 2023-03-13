using System;
using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_funcionario : Form
    {
        public frm_funcionario()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            new frm_menu_principal().Show();
            Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            new frm_cad_funcionario().Show();
            Hide();
        }

        private void frm_funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}

