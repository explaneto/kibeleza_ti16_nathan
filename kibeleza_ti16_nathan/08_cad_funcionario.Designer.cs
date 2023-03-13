namespace kibeleza_ti16_nathan
{
    partial class frm_cad_funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_data_cad = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.dgv_fone_empresa = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_carga_horaria = new System.Windows.Forms.Label();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.cmb_empresa = new System.Windows.Forms.ComboBox();
            this.lbl_nome_funcionario = new System.Windows.Forms.Label();
            this.txt_nome_funcionario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.txt_data_cad = new System.Windows.Forms.TextBox();
            this.pnl_fone = new System.Windows.Forms.PictureBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.cmb_carga = new System.Windows.Forms.ComboBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_titulo_cad_funcionario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pct_fechar = new System.Windows.Forms.PictureBox();
            this.pnl_funcionario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_fone)).BeginInit();
            this.lbl_titulo_cad_funcionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_data_cad
            // 
            this.lbl_data_cad.AutoSize = true;
            this.lbl_data_cad.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_data_cad.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_cad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_data_cad.Location = new System.Drawing.Point(758, 404);
            this.lbl_data_cad.Name = "lbl_data_cad";
            this.lbl_data_cad.Size = new System.Drawing.Size(221, 27);
            this.lbl_data_cad.TabIndex = 102;
            this.lbl_data_cad.Text = "DATA DE CADASTRO";
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmb_status.Location = new System.Drawing.Point(544, 434);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(159, 33);
            this.cmb_status.TabIndex = 101;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(371, 342);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(620, 31);
            this.txt_email.TabIndex = 79;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_limpar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(1046, 679);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(107, 44);
            this.btn_limpar.TabIndex = 100;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_salvar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(1186, 679);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(113, 44);
            this.btn_salvar.TabIndex = 99;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Chocolate;
            this.btn_excluir.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(869, 679);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(136, 44);
            this.btn_excluir.TabIndex = 98;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_alterar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(674, 679);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(136, 44);
            this.btn_alterar.TabIndex = 97;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_cadastrar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(481, 679);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(136, 44);
            this.btn_cadastrar.TabIndex = 87;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // dgv_fone_empresa
            // 
            this.dgv_fone_empresa.BackColor = System.Drawing.Color.Brown;
            this.dgv_fone_empresa.Location = new System.Drawing.Point(481, 493);
            this.dgv_fone_empresa.Name = "dgv_fone_empresa";
            this.dgv_fone_empresa.Size = new System.Drawing.Size(524, 175);
            this.dgv_fone_empresa.TabIndex = 96;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_status.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_status.Location = new System.Drawing.Point(552, 404);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(90, 27);
            this.lbl_status.TabIndex = 95;
            this.lbl_status.Text = "STATUS";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_senha.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_senha.Location = new System.Drawing.Point(1122, 312);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(81, 27);
            this.lbl_senha.TabIndex = 94;
            this.lbl_senha.Text = "SENHA";
            // 
            // lbl_carga_horaria
            // 
            this.lbl_carga_horaria.AutoSize = true;
            this.lbl_carga_horaria.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_carga_horaria.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carga_horaria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_carga_horaria.Location = new System.Drawing.Point(1080, 402);
            this.lbl_carga_horaria.Name = "lbl_carga_horaria";
            this.lbl_carga_horaria.Size = new System.Drawing.Size(184, 27);
            this.lbl_carga_horaria.TabIndex = 93;
            this.lbl_carga_horaria.Text = "CARGA HORÁRIA";
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_empresa.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_empresa.Location = new System.Drawing.Point(1122, 517);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(111, 27);
            this.lbl_empresa.TabIndex = 92;
            this.lbl_empresa.Text = "EMPRESA";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empresa.FormattingEnabled = true;
            this.cmb_empresa.Location = new System.Drawing.Point(1046, 560);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Size = new System.Drawing.Size(253, 33);
            this.cmb_empresa.TabIndex = 91;
            // 
            // lbl_nome_funcionario
            // 
            this.lbl_nome_funcionario.AutoSize = true;
            this.lbl_nome_funcionario.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_nome_funcionario.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_funcionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nome_funcionario.Location = new System.Drawing.Point(552, 218);
            this.lbl_nome_funcionario.Name = "lbl_nome_funcionario";
            this.lbl_nome_funcionario.Size = new System.Drawing.Size(259, 27);
            this.lbl_nome_funcionario.TabIndex = 90;
            this.lbl_nome_funcionario.Text = "NOME DA FUNCIONÁRIO";
            // 
            // txt_nome_funcionario
            // 
            this.txt_nome_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_funcionario.Location = new System.Drawing.Point(544, 260);
            this.txt_nome_funcionario.Name = "txt_nome_funcionario";
            this.txt_nome_funcionario.Size = new System.Drawing.Size(755, 31);
            this.txt_nome_funcionario.TabIndex = 89;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(1046, 342);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(253, 31);
            this.txt_senha.TabIndex = 88;
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "OUTROS"});
            this.cmb_nivel.Location = new System.Drawing.Point(371, 434);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(159, 33);
            this.cmb_nivel.TabIndex = 86;
            // 
            // txt_data_cad
            // 
            this.txt_data_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_cad.Location = new System.Drawing.Point(763, 434);
            this.txt_data_cad.Name = "txt_data_cad";
            this.txt_data_cad.Size = new System.Drawing.Size(228, 31);
            this.txt_data_cad.TabIndex = 85;
            // 
            // pnl_fone
            // 
            this.pnl_fone.Image = global::kibeleza_ti16_nathan.Properties.Resources.telefone;
            this.pnl_fone.Location = new System.Drawing.Point(371, 481);
            this.pnl_fone.Name = "pnl_fone";
            this.pnl_fone.Size = new System.Drawing.Size(646, 253);
            this.pnl_fone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_fone.TabIndex = 84;
            this.pnl_fone.TabStop = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_email.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_email.Location = new System.Drawing.Point(376, 312);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(81, 27);
            this.lbl_email.TabIndex = 76;
            this.lbl_email.Text = "E-MAIL";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_nivel.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nivel.Location = new System.Drawing.Point(376, 404);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(72, 27);
            this.lbl_nivel.TabIndex = 77;
            this.lbl_nivel.Text = "NÍVEL";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_codigo.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_codigo.Location = new System.Drawing.Point(376, 218);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(96, 27);
            this.lbl_codigo.TabIndex = 78;
            this.lbl_codigo.Text = "CÓDIGO";
            // 
            // cmb_carga
            // 
            this.cmb_carga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_carga.FormattingEnabled = true;
            this.cmb_carga.Items.AddRange(new object[] {
            "02:00",
            "04:00",
            "06:00",
            "8:00",
            "10:00"});
            this.cmb_carga.Location = new System.Drawing.Point(1093, 434);
            this.cmb_carga.Name = "cmb_carga";
            this.cmb_carga.Size = new System.Drawing.Size(159, 33);
            this.cmb_carga.TabIndex = 80;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(371, 260);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(159, 31);
            this.txt_codigo.TabIndex = 82;
            // 
            // lbl_titulo_cad_funcionario
            // 
            this.lbl_titulo_cad_funcionario.BackColor = System.Drawing.Color.Brown;
            this.lbl_titulo_cad_funcionario.Controls.Add(this.label1);
            this.lbl_titulo_cad_funcionario.Location = new System.Drawing.Point(371, 132);
            this.lbl_titulo_cad_funcionario.Name = "lbl_titulo_cad_funcionario";
            this.lbl_titulo_cad_funcionario.Size = new System.Drawing.Size(928, 68);
            this.lbl_titulo_cad_funcionario.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(296, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "CADASTRAR FUNCIONÁRIO";
            // 
            // pct_fechar
            // 
            this.pct_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.pct_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.pct_fechar.Location = new System.Drawing.Point(1305, 132);
            this.pct_fechar.Name = "pct_fechar";
            this.pct_fechar.Size = new System.Drawing.Size(39, 40);
            this.pct_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_fechar.TabIndex = 83;
            this.pct_fechar.TabStop = false;
            this.pct_fechar.Click += new System.EventHandler(this.pct_fechar_Click);
            // 
            // pnl_funcionario
            // 
            this.pnl_funcionario.Image = global::kibeleza_ti16_nathan.Properties.Resources.funcionario;
            this.pnl_funcionario.Location = new System.Drawing.Point(181, 123);
            this.pnl_funcionario.Name = "pnl_funcionario";
            this.pnl_funcionario.Size = new System.Drawing.Size(1173, 621);
            this.pnl_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_funcionario.TabIndex = 75;
            this.pnl_funcionario.TabStop = false;
            // 
            // frm_cad_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1534, 866);
            this.Controls.Add(this.lbl_data_cad);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dgv_fone_empresa);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_carga_horaria);
            this.Controls.Add(this.lbl_empresa);
            this.Controls.Add(this.cmb_empresa);
            this.Controls.Add(this.lbl_nome_funcionario);
            this.Controls.Add(this.txt_nome_funcionario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.cmb_nivel);
            this.Controls.Add(this.txt_data_cad);
            this.Controls.Add(this.pnl_fone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.cmb_carga);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_titulo_cad_funcionario);
            this.Controls.Add(this.pct_fechar);
            this.Controls.Add(this.pnl_funcionario);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cad_funcionario";
            this.Text = "Cadastro Funcinario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnl_fone)).EndInit();
            this.lbl_titulo_cad_funcionario.ResumeLayout(false);
            this.lbl_titulo_cad_funcionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_data_cad;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Panel dgv_fone_empresa;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_carga_horaria;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.ComboBox cmb_empresa;
        private System.Windows.Forms.Label lbl_nome_funcionario;
        private System.Windows.Forms.TextBox txt_nome_funcionario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.TextBox txt_data_cad;
        private System.Windows.Forms.PictureBox pnl_fone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.ComboBox cmb_carga;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Panel lbl_titulo_cad_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pct_fechar;
        private System.Windows.Forms.PictureBox pnl_funcionario;
    }
}