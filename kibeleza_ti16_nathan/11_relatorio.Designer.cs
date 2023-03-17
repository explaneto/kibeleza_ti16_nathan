namespace kibeleza_ti16_nathan
{
    partial class frm_relatorio
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
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.PictureBox();
            this.rad_telefone = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rad_inativo = new System.Windows.Forms.RadioButton();
            this.rad_ativo = new System.Windows.Forms.RadioButton();
            this.pnl_filtro = new System.Windows.Forms.Panel();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.rad_empresa = new System.Windows.Forms.RadioButton();
            this.rad_funcionario = new System.Windows.Forms.RadioButton();
            this.rad_cliente = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_tabela = new System.Windows.Forms.Label();
            this.pnl_tabela = new System.Windows.Forms.Panel();
            this.pct_relatorio = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.dgv_relatorio = new System.Windows.Forms.DataGridView();
            this.pct_fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atualizar)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnl_filtro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_relatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_salvar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(1224, 681);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(94, 44);
            this.btn_salvar.TabIndex = 65;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_atualizar.Image = global::kibeleza_ti16_nathan.Properties.Resources.atualizar;
            this.btn_atualizar.Location = new System.Drawing.Point(1251, 139);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(39, 40);
            this.btn_atualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_atualizar.TabIndex = 72;
            this.btn_atualizar.TabStop = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // rad_telefone
            // 
            this.rad_telefone.AutoSize = true;
            this.rad_telefone.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_telefone.Location = new System.Drawing.Point(703, 10);
            this.rad_telefone.Name = "rad_telefone";
            this.rad_telefone.Size = new System.Drawing.Size(110, 25);
            this.rad_telefone.TabIndex = 68;
            this.rad_telefone.TabStop = true;
            this.rad_telefone.Text = "TELEFONE";
            this.rad_telefone.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Controls.Add(this.rad_telefone);
            this.panel3.Controls.Add(this.rad_inativo);
            this.panel3.Controls.Add(this.rad_ativo);
            this.panel3.Location = new System.Drawing.Point(350, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 50);
            this.panel3.TabIndex = 70;
            // 
            // rad_inativo
            // 
            this.rad_inativo.AutoSize = true;
            this.rad_inativo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_inativo.Location = new System.Drawing.Point(368, 10);
            this.rad_inativo.Name = "rad_inativo";
            this.rad_inativo.Size = new System.Drawing.Size(93, 25);
            this.rad_inativo.TabIndex = 66;
            this.rad_inativo.TabStop = true;
            this.rad_inativo.Text = "INATIVO";
            this.rad_inativo.UseVisualStyleBackColor = true;
            // 
            // rad_ativo
            // 
            this.rad_ativo.AutoSize = true;
            this.rad_ativo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_ativo.Location = new System.Drawing.Point(0, 10);
            this.rad_ativo.Name = "rad_ativo";
            this.rad_ativo.Size = new System.Drawing.Size(76, 25);
            this.rad_ativo.TabIndex = 67;
            this.rad_ativo.TabStop = true;
            this.rad_ativo.Text = "ATIVO";
            this.rad_ativo.UseVisualStyleBackColor = true;
            // 
            // pnl_filtro
            // 
            this.pnl_filtro.BackColor = System.Drawing.Color.Brown;
            this.pnl_filtro.Controls.Add(this.lbl_filtro);
            this.pnl_filtro.Location = new System.Drawing.Point(350, 259);
            this.pnl_filtro.Name = "pnl_filtro";
            this.pnl_filtro.Size = new System.Drawing.Size(863, 40);
            this.pnl_filtro.TabIndex = 71;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_filtro.Location = new System.Drawing.Point(362, 0);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(115, 36);
            this.lbl_filtro.TabIndex = 22;
            this.lbl_filtro.Text = "FILTRO";
            // 
            // rad_empresa
            // 
            this.rad_empresa.AutoSize = true;
            this.rad_empresa.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_empresa.Location = new System.Drawing.Point(368, 12);
            this.rad_empresa.Name = "rad_empresa";
            this.rad_empresa.Size = new System.Drawing.Size(105, 25);
            this.rad_empresa.TabIndex = 70;
            this.rad_empresa.TabStop = true;
            this.rad_empresa.Text = "EMPRESA";
            this.rad_empresa.UseVisualStyleBackColor = true;
            // 
            // rad_funcionario
            // 
            this.rad_funcionario.AutoSize = true;
            this.rad_funcionario.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_funcionario.Location = new System.Drawing.Point(703, 12);
            this.rad_funcionario.Name = "rad_funcionario";
            this.rad_funcionario.Size = new System.Drawing.Size(140, 25);
            this.rad_funcionario.TabIndex = 69;
            this.rad_funcionario.TabStop = true;
            this.rad_funcionario.Text = "FUNCIONÁRIO";
            this.rad_funcionario.UseVisualStyleBackColor = true;
            // 
            // rad_cliente
            // 
            this.rad_cliente.AutoSize = true;
            this.rad_cliente.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_cliente.Location = new System.Drawing.Point(3, 12);
            this.rad_cliente.Name = "rad_cliente";
            this.rad_cliente.Size = new System.Drawing.Size(96, 25);
            this.rad_cliente.TabIndex = 65;
            this.rad_cliente.TabStop = true;
            this.rad_cliente.Text = "CLIENTE";
            this.rad_cliente.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.rad_empresa);
            this.panel2.Controls.Add(this.rad_funcionario);
            this.panel2.Controls.Add(this.rad_cliente);
            this.panel2.Location = new System.Drawing.Point(350, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 50);
            this.panel2.TabIndex = 69;
            // 
            // lbl_tabela
            // 
            this.lbl_tabela.AutoSize = true;
            this.lbl_tabela.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tabela.Location = new System.Drawing.Point(362, 4);
            this.lbl_tabela.Name = "lbl_tabela";
            this.lbl_tabela.Size = new System.Drawing.Size(119, 36);
            this.lbl_tabela.TabIndex = 21;
            this.lbl_tabela.Text = "TABELA";
            // 
            // pnl_tabela
            // 
            this.pnl_tabela.BackColor = System.Drawing.Color.Brown;
            this.pnl_tabela.Controls.Add(this.lbl_tabela);
            this.pnl_tabela.Location = new System.Drawing.Point(350, 135);
            this.pnl_tabela.Name = "pnl_tabela";
            this.pnl_tabela.Size = new System.Drawing.Size(863, 40);
            this.pnl_tabela.TabIndex = 68;
            // 
            // pct_relatorio
            // 
            this.pct_relatorio.Image = global::kibeleza_ti16_nathan.Properties.Resources.relatorio;
            this.pct_relatorio.Location = new System.Drawing.Point(159, 126);
            this.pct_relatorio.Name = "pct_relatorio";
            this.pct_relatorio.Size = new System.Drawing.Size(1173, 621);
            this.pct_relatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_relatorio.TabIndex = 66;
            this.pct_relatorio.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.btn_fechar.Location = new System.Drawing.Point(1284, 138);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(39, 40);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 67;
            this.btn_fechar.TabStop = false;
            // 
            // dgv_relatorio
            // 
            this.dgv_relatorio.AllowUserToAddRows = false;
            this.dgv_relatorio.AllowUserToDeleteRows = false;
            this.dgv_relatorio.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dgv_relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_relatorio.Location = new System.Drawing.Point(353, 372);
            this.dgv_relatorio.Name = "dgv_relatorio";
            this.dgv_relatorio.ReadOnly = true;
            this.dgv_relatorio.Size = new System.Drawing.Size(860, 353);
            this.dgv_relatorio.TabIndex = 73;
            // 
            // pct_fechar
            // 
            this.pct_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.pct_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.pct_fechar.Location = new System.Drawing.Point(1251, 192);
            this.pct_fechar.Name = "pct_fechar";
            this.pct_fechar.Size = new System.Drawing.Size(39, 40);
            this.pct_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_fechar.TabIndex = 74;
            this.pct_fechar.TabStop = false;
            this.pct_fechar.Click += new System.EventHandler(this.pct_fechar_Click);
            // 
            // frm_relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1490, 873);
            this.Controls.Add(this.pct_fechar);
            this.Controls.Add(this.dgv_relatorio);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_filtro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_tabela);
            this.Controls.Add(this.pct_relatorio);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_relatorio";
            this.Text = "Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btn_atualizar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_filtro.ResumeLayout(false);
            this.pnl_filtro.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_tabela.ResumeLayout(false);
            this.pnl_tabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_relatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.PictureBox btn_atualizar;
        private System.Windows.Forms.RadioButton rad_telefone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rad_inativo;
        private System.Windows.Forms.RadioButton rad_ativo;
        private System.Windows.Forms.Panel pnl_filtro;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.RadioButton rad_empresa;
        private System.Windows.Forms.RadioButton rad_funcionario;
        private System.Windows.Forms.RadioButton rad_cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_tabela;
        private System.Windows.Forms.Panel pnl_tabela;
        private System.Windows.Forms.PictureBox pct_relatorio;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.DataGridView dgv_relatorio;
        private System.Windows.Forms.PictureBox pct_fechar;
    }
}