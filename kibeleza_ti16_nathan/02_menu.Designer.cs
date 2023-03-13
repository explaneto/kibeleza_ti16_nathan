namespace kibeleza_ti16_nathan
{
    partial class frm_menu_principal
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
            this.components = new System.ComponentModel.Container();
            this.pnl_menu_principal = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.dgv_reserva = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aguardar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_aprovar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pct_funcionario = new System.Windows.Forms.PictureBox();
            this.pct_empresa = new System.Windows.Forms.PictureBox();
            this.pct_servico = new System.Windows.Forms.PictureBox();
            this.pct_relatorio = new System.Windows.Forms.PictureBox();
            this.pct_cliente = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_data = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.pnl_menu_principal.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_servico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_relatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_cliente)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu_principal
            // 
            this.pnl_menu_principal.BackColor = System.Drawing.Color.LightSalmon;
            this.pnl_menu_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_menu_principal.Controls.Add(this.panel5);
            this.pnl_menu_principal.Controls.Add(this.button2);
            this.pnl_menu_principal.Controls.Add(this.button1);
            this.pnl_menu_principal.Controls.Add(this.pct_funcionario);
            this.pnl_menu_principal.Controls.Add(this.pct_empresa);
            this.pnl_menu_principal.Controls.Add(this.pct_servico);
            this.pnl_menu_principal.Controls.Add(this.pct_relatorio);
            this.pnl_menu_principal.Controls.Add(this.pct_cliente);
            this.pnl_menu_principal.Controls.Add(this.panel3);
            this.pnl_menu_principal.Controls.Add(this.panel4);
            this.pnl_menu_principal.Controls.Add(this.panel2);
            this.pnl_menu_principal.Controls.Add(this.pictureBox1);
            this.pnl_menu_principal.Location = new System.Drawing.Point(189, 139);
            this.pnl_menu_principal.Name = "pnl_menu_principal";
            this.pnl_menu_principal.Size = new System.Drawing.Size(1106, 621);
            this.pnl_menu_principal.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Salmon;
            this.panel5.Controls.Add(this.cmb_status);
            this.panel5.Controls.Add(this.dgv_reserva);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btn_cancelar);
            this.panel5.Controls.Add(this.btn_aguardar);
            this.panel5.Controls.Add(this.btn_finalizar);
            this.panel5.Controls.Add(this.btn_editar);
            this.panel5.Controls.Add(this.btn_agendar);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txt_cliente);
            this.panel5.Controls.Add(this.btn_aprovar);
            this.panel5.Location = new System.Drawing.Point(401, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(686, 394);
            this.panel5.TabIndex = 10;
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "TODAS",
            "APROVADA",
            "CANCELADA",
            "AGUARDANDO",
            "FINALIZADA"});
            this.cmb_status.Location = new System.Drawing.Point(548, 15);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 33);
            this.cmb_status.TabIndex = 20;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            // 
            // dgv_reserva
            // 
            this.dgv_reserva.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgv_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reserva.Location = new System.Drawing.Point(15, 103);
            this.dgv_reserva.Name = "dgv_reserva";
            this.dgv_reserva.Size = new System.Drawing.Size(654, 272);
            this.dgv_reserva.TabIndex = 19;
            this.dgv_reserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reserva_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "STATUS";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(123, 57);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 35);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aguardar
            // 
            this.btn_aguardar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_aguardar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aguardar.ForeColor = System.Drawing.Color.White;
            this.btn_aguardar.Location = new System.Drawing.Point(231, 57);
            this.btn_aguardar.Name = "btn_aguardar";
            this.btn_aguardar.Size = new System.Drawing.Size(102, 35);
            this.btn_aguardar.TabIndex = 15;
            this.btn_aguardar.Text = "AGUARDAR";
            this.btn_aguardar.UseVisualStyleBackColor = false;
            this.btn_aguardar.Click += new System.EventHandler(this.btn_aguardar_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_finalizar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.Color.White;
            this.btn_finalizar.Location = new System.Drawing.Point(339, 57);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(102, 35);
            this.btn_finalizar.TabIndex = 14;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_editar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(447, 57);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(102, 35);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_agendar
            // 
            this.btn_agendar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_agendar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendar.ForeColor = System.Drawing.Color.White;
            this.btn_agendar.Location = new System.Drawing.Point(559, 53);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(110, 44);
            this.btn_agendar.TabIndex = 12;
            this.btn_agendar.Text = "AGENDAR";
            this.btn_agendar.UseVisualStyleBackColor = false;
            this.btn_agendar.Click += new System.EventHandler(this.btn_aguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "CLIENTE";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(104, 11);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(337, 31);
            this.txt_cliente.TabIndex = 10;
            this.txt_cliente.TextChanged += new System.EventHandler(this.txt_cliente_TextChanged);
            // 
            // btn_aprovar
            // 
            this.btn_aprovar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_aprovar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aprovar.ForeColor = System.Drawing.Color.White;
            this.btn_aprovar.Location = new System.Drawing.Point(15, 57);
            this.btn_aprovar.Name = "btn_aprovar";
            this.btn_aprovar.Size = new System.Drawing.Size(102, 35);
            this.btn_aprovar.TabIndex = 9;
            this.btn_aprovar.Text = "APROVAR";
            this.btn_aprovar.UseVisualStyleBackColor = false;
            this.btn_aprovar.Click += new System.EventHandler(this.btn_aprovar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(930, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "AJUDA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(930, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "SOBRE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.lbl_sobre_Click);
            // 
            // pct_funcionario
            // 
            this.pct_funcionario.Image = global::kibeleza_ti16_nathan.Properties.Resources.btnFuncionario;
            this.pct_funcionario.Location = new System.Drawing.Point(206, 461);
            this.pct_funcionario.Name = "pct_funcionario";
            this.pct_funcionario.Size = new System.Drawing.Size(155, 139);
            this.pct_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_funcionario.TabIndex = 7;
            this.pct_funcionario.TabStop = false;
            this.pct_funcionario.Click += new System.EventHandler(this.pct_funcionario_Click);
            // 
            // pct_empresa
            // 
            this.pct_empresa.Image = global::kibeleza_ti16_nathan.Properties.Resources.btnEmpresa;
            this.pct_empresa.Location = new System.Drawing.Point(391, 461);
            this.pct_empresa.Name = "pct_empresa";
            this.pct_empresa.Size = new System.Drawing.Size(155, 139);
            this.pct_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_empresa.TabIndex = 6;
            this.pct_empresa.TabStop = false;
            this.pct_empresa.Click += new System.EventHandler(this.pct_empresa_Click);
            // 
            // pct_servico
            // 
            this.pct_servico.Image = global::kibeleza_ti16_nathan.Properties.Resources.btnServico;
            this.pct_servico.Location = new System.Drawing.Point(570, 461);
            this.pct_servico.Name = "pct_servico";
            this.pct_servico.Size = new System.Drawing.Size(155, 139);
            this.pct_servico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_servico.TabIndex = 5;
            this.pct_servico.TabStop = false;
            this.pct_servico.Click += new System.EventHandler(this.pct_servicos_Click);
            // 
            // pct_relatorio
            // 
            this.pct_relatorio.Image = global::kibeleza_ti16_nathan.Properties.Resources.btnRelatorio;
            this.pct_relatorio.Location = new System.Drawing.Point(755, 461);
            this.pct_relatorio.Name = "pct_relatorio";
            this.pct_relatorio.Size = new System.Drawing.Size(155, 139);
            this.pct_relatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_relatorio.TabIndex = 4;
            this.pct_relatorio.TabStop = false;
            this.pct_relatorio.Click += new System.EventHandler(this.pct_relatorio_Click);
            // 
            // pct_cliente
            // 
            this.pct_cliente.Image = global::kibeleza_ti16_nathan.Properties.Resources.btnCliente;
            this.pct_cliente.Location = new System.Drawing.Point(20, 461);
            this.pct_cliente.Name = "pct_cliente";
            this.pct_cliente.Size = new System.Drawing.Size(155, 139);
            this.pct_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_cliente.TabIndex = 3;
            this.pct_cliente.TabStop = false;
            this.pct_cliente.Click += new System.EventHandler(this.pct_cliente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.lbl_mensagem);
            this.panel3.Location = new System.Drawing.Point(20, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 70);
            this.panel3.TabIndex = 2;
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.Location = new System.Drawing.Point(59, 19);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(242, 32);
            this.lbl_mensagem.TabIndex = 2;
            this.lbl_mensagem.Text = "BOM DIA DOUTOR";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.Controls.Add(this.lbl_hora);
            this.panel4.Location = new System.Drawing.Point(20, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 70);
            this.panel4.TabIndex = 2;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(110, 18);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(138, 32);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "00:00:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.lbl_data);
            this.panel2.Location = new System.Drawing.Point(20, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 70);
            this.panel2.TabIndex = 1;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(87, 19);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(182, 32);
            this.lbl_data.TabIndex = 0;
            this.lbl_data.Text = "00/00/0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kibeleza_ti16_nathan.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.btn_fechar.Location = new System.Drawing.Point(1422, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(39, 40);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 115;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.pct_sair_Click);
            // 
            // frm_menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1490, 876);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.pnl_menu_principal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menu_principal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_principal_Load);
            this.pnl_menu_principal.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_servico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_relatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_cliente)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu_principal;
        private System.Windows.Forms.PictureBox pct_funcionario;
        private System.Windows.Forms.PictureBox pct_empresa;
        private System.Windows.Forms.PictureBox pct_servico;
        private System.Windows.Forms.PictureBox pct_relatorio;
        private System.Windows.Forms.PictureBox pct_cliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aguardar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_aprovar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.DataGridView dgv_reserva;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.PictureBox btn_fechar;
    }
}