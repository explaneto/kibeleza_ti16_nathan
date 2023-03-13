using System.Windows.Forms;

namespace kibeleza_ti16_nathan
{
    public partial class frm_cad_servico : Form
    {
        public frm_cad_servico()
        {
            InitializeComponent();
        }

        private void pct_fechar_Click(object sender, System.EventArgs e)
        {
            new frm_menu_principal().Show();
            Close();
        }
    }
}
