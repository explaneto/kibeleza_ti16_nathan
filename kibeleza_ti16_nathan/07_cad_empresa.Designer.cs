namespace kibeleza_ti16_nathan
{
    partial class frm_cad_empresa
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
            this.mkd_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mkd_data_cad = new System.Windows.Forms.MaskedTextBox();
            this.dgv_fone_empresa = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.lbl_razao = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_data_cad = new System.Windows.Forms.Label();
            this.lbl_carga_horaria = new System.Windows.Forms.Label();
            this.cmb_carga_horaria = new System.Windows.Forms.ComboBox();
            this.lbl_nome_empresa = new System.Windows.Forms.Label();
            this.txt_nome_empresa = new System.Windows.Forms.TextBox();
            this.cmb_documento = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pnl_fone_empresa = new System.Windows.Forms.PictureBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_documento = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_razao = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pct_fechar = new System.Windows.Forms.PictureBox();
            this.pnl_empresa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fone_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_fone_empresa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // mkd_cnpj
            // 
            this.mkd_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_cnpj.Location = new System.Drawing.Point(577, 430);
            this.mkd_cnpj.Name = "mkd_cnpj";
            this.mkd_cnpj.Size = new System.Drawing.Size(302, 31);
            this.mkd_cnpj.TabIndex = 96;
            this.mkd_cnpj.Text = "__.___.___/____-__";
            this.mkd_cnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkd_data_cad
            // 
            this.mkd_data_cad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_data_cad.Location = new System.Drawing.Point(1134, 608);
            this.mkd_data_cad.Name = "mkd_data_cad";
            this.mkd_data_cad.Size = new System.Drawing.Size(159, 31);
            this.mkd_data_cad.TabIndex = 95;
            this.mkd_data_cad.Text = "__/__/____";
            this.mkd_data_cad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_fone_empresa
            // 
            this.dgv_fone_empresa.AllowUserToAddRows = false;
            this.dgv_fone_empresa.AllowUserToDeleteRows = false;
            this.dgv_fone_empresa.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgv_fone_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fone_empresa.Location = new System.Drawing.Point(514, 559);
            this.dgv_fone_empresa.Name = "dgv_fone_empresa";
            this.dgv_fone_empresa.ReadOnly = true;
            this.dgv_fone_empresa.Size = new System.Drawing.Size(524, 192);
            this.dgv_fone_empresa.TabIndex = 84;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(296, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(372, 41);
            this.lbl_titulo.TabIndex = 20;
            this.lbl_titulo.Text = "CADASTRAR EMPRESA";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_limpar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(1079, 757);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(136, 44);
            this.btn_limpar.TabIndex = 83;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_salvar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(1221, 757);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(136, 44);
            this.btn_salvar.TabIndex = 82;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Chocolate;
            this.btn_excluir.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(902, 757);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(136, 44);
            this.btn_excluir.TabIndex = 81;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_alterar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(707, 757);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(136, 44);
            this.btn_alterar.TabIndex = 80;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_cadastrar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(514, 757);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(136, 44);
            this.btn_cadastrar.TabIndex = 71;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_cnpj.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnpj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cnpj.Location = new System.Drawing.Point(585, 388);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(128, 27);
            this.lbl_cnpj.TabIndex = 79;
            this.lbl_cnpj.Text = "CNPJ / CPF";
            // 
            // lbl_razao
            // 
            this.lbl_razao.AutoSize = true;
            this.lbl_razao.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_razao.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_razao.Location = new System.Drawing.Point(912, 388);
            this.lbl_razao.Name = "lbl_razao";
            this.lbl_razao.Size = new System.Drawing.Size(164, 27);
            this.lbl_razao.TabIndex = 78;
            this.lbl_razao.Text = "RAZÃO SOCIAL";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_status.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_status.Location = new System.Drawing.Point(1165, 482);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(90, 27);
            this.lbl_status.TabIndex = 77;
            this.lbl_status.Text = "STATUS";
            // 
            // lbl_data_cad
            // 
            this.lbl_data_cad.AutoSize = true;
            this.lbl_data_cad.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_data_cad.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_cad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_data_cad.Location = new System.Drawing.Point(1111, 578);
            this.lbl_data_cad.Name = "lbl_data_cad";
            this.lbl_data_cad.Size = new System.Drawing.Size(221, 27);
            this.lbl_data_cad.TabIndex = 76;
            this.lbl_data_cad.Text = "DATA DE CADASTRO";
            // 
            // lbl_carga_horaria
            // 
            this.lbl_carga_horaria.AutoSize = true;
            this.lbl_carga_horaria.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_carga_horaria.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carga_horaria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_carga_horaria.Location = new System.Drawing.Point(1128, 658);
            this.lbl_carga_horaria.Name = "lbl_carga_horaria";
            this.lbl_carga_horaria.Size = new System.Drawing.Size(184, 27);
            this.lbl_carga_horaria.TabIndex = 75;
            this.lbl_carga_horaria.Text = "CARGA HORÁRIA";
            // 
            // cmb_carga_horaria
            // 
            this.cmb_carga_horaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_carga_horaria.FormattingEnabled = true;
            this.cmb_carga_horaria.Items.AddRange(new object[] {
            "04:00",
            "06:00",
            "08:00",
            "10:00",
            "12:00"});
            this.cmb_carga_horaria.Location = new System.Drawing.Point(1134, 688);
            this.cmb_carga_horaria.Name = "cmb_carga_horaria";
            this.cmb_carga_horaria.Size = new System.Drawing.Size(159, 33);
            this.cmb_carga_horaria.TabIndex = 74;
            // 
            // lbl_nome_empresa
            // 
            this.lbl_nome_empresa.AutoSize = true;
            this.lbl_nome_empresa.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_nome_empresa.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_empresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nome_empresa.Location = new System.Drawing.Point(585, 296);
            this.lbl_nome_empresa.Name = "lbl_nome_empresa";
            this.lbl_nome_empresa.Size = new System.Drawing.Size(215, 27);
            this.lbl_nome_empresa.TabIndex = 73;
            this.lbl_nome_empresa.Text = "NOME DA EMPRESA";
            // 
            // txt_nome_empresa
            // 
            this.txt_nome_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_empresa.Location = new System.Drawing.Point(577, 338);
            this.txt_nome_empresa.Name = "txt_nome_empresa";
            this.txt_nome_empresa.Size = new System.Drawing.Size(755, 31);
            this.txt_nome_empresa.TabIndex = 72;
            // 
            // cmb_documento
            // 
            this.cmb_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_documento.FormattingEnabled = true;
            this.cmb_documento.Items.AddRange(new object[] {
            "CNPJ",
            "CPF"});
            this.cmb_documento.Location = new System.Drawing.Point(404, 430);
            this.cmb_documento.Name = "cmb_documento";
            this.cmb_documento.Size = new System.Drawing.Size(159, 33);
            this.cmb_documento.TabIndex = 70;
            this.cmb_documento.SelectedIndexChanged += new System.EventHandler(this.cmb_documento_SelectedIndexChanged);
            this.cmb_documento.Click += new System.EventHandler(this.cmb_documento_SelectedIndexChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(404, 522);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(646, 31);
            this.txt_email.TabIndex = 69;
            // 
            // pnl_fone_empresa
            // 
            this.pnl_fone_empresa.Image = global::kibeleza_ti16_nathan.Properties.Resources.telefone;
            this.pnl_fone_empresa.Location = new System.Drawing.Point(404, 559);
            this.pnl_fone_empresa.Name = "pnl_fone_empresa";
            this.pnl_fone_empresa.Size = new System.Drawing.Size(646, 253);
            this.pnl_fone_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_fone_empresa.TabIndex = 68;
            this.pnl_fone_empresa.TabStop = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_email.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_email.Location = new System.Drawing.Point(409, 482);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(81, 27);
            this.lbl_email.TabIndex = 59;
            this.lbl_email.Text = "E-MAIL";
            // 
            // lbl_documento
            // 
            this.lbl_documento.AutoSize = true;
            this.lbl_documento.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_documento.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_documento.Location = new System.Drawing.Point(409, 388);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(146, 27);
            this.lbl_documento.TabIndex = 60;
            this.lbl_documento.Text = "DOCUMENTO";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_codigo.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_codigo.Location = new System.Drawing.Point(409, 296);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(96, 27);
            this.lbl_codigo.TabIndex = 61;
            this.lbl_codigo.Text = "CÓDIGO";
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cmb_status.Location = new System.Drawing.Point(1134, 522);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(159, 33);
            this.cmb_status.TabIndex = 63;
            // 
            // txt_razao
            // 
            this.txt_razao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razao.Location = new System.Drawing.Point(897, 430);
            this.txt_razao.Name = "txt_razao";
            this.txt_razao.Size = new System.Drawing.Size(435, 31);
            this.txt_razao.TabIndex = 62;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(404, 338);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(159, 31);
            this.txt_codigo.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Location = new System.Drawing.Point(404, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 68);
            this.panel1.TabIndex = 64;
            // 
            // pct_fechar
            // 
            this.pct_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.pct_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.pct_fechar.Location = new System.Drawing.Point(1338, 210);
            this.pct_fechar.Name = "pct_fechar";
            this.pct_fechar.Size = new System.Drawing.Size(39, 40);
            this.pct_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_fechar.TabIndex = 67;
            this.pct_fechar.TabStop = false;
            this.pct_fechar.Click += new System.EventHandler(this.pct_fechar_Click);
            // 
            // pnl_empresa
            // 
            this.pnl_empresa.Image = global::kibeleza_ti16_nathan.Properties.Resources.empresa;
            this.pnl_empresa.Location = new System.Drawing.Point(214, 201);
            this.pnl_empresa.Name = "pnl_empresa";
            this.pnl_empresa.Size = new System.Drawing.Size(1173, 621);
            this.pnl_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_empresa.TabIndex = 58;
            this.pnl_empresa.TabStop = false;
            // 
            // frm_cad_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1903, 878);
            this.Controls.Add(this.mkd_cnpj);
            this.Controls.Add(this.mkd_data_cad);
            this.Controls.Add(this.dgv_fone_empresa);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_cnpj);
            this.Controls.Add(this.lbl_razao);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_data_cad);
            this.Controls.Add(this.lbl_carga_horaria);
            this.Controls.Add(this.cmb_carga_horaria);
            this.Controls.Add(this.lbl_nome_empresa);
            this.Controls.Add(this.txt_nome_empresa);
            this.Controls.Add(this.cmb_documento);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pnl_fone_empresa);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_documento);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.txt_razao);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pct_fechar);
            this.Controls.Add(this.pnl_empresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cad_empresa";
            this.Text = "Cadastrar Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cad_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fone_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_fone_empresa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_empresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mkd_cnpj;
        private System.Windows.Forms.MaskedTextBox mkd_data_cad;
        private System.Windows.Forms.DataGridView dgv_fone_empresa;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.Label lbl_razao;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_data_cad;
        private System.Windows.Forms.Label lbl_carga_horaria;
        private System.Windows.Forms.ComboBox cmb_carga_horaria;
        private System.Windows.Forms.Label lbl_nome_empresa;
        private System.Windows.Forms.TextBox txt_nome_empresa;
        private System.Windows.Forms.ComboBox cmb_documento;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pnl_fone_empresa;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_documento;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_razao;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pct_fechar;
        private System.Windows.Forms.PictureBox pnl_empresa;
    }
}