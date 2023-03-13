namespace kibeleza_ti16_nathan
{
    partial class frm_reserva
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
            this.lbl_horario = new System.Windows.Forms.Label();
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_servico = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_data_reserva = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_servico = new System.Windows.Forms.ComboBox();
            this.lbl_observacao = new System.Windows.Forms.Label();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.cmb_funcionario = new System.Windows.Forms.ComboBox();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_info_reserva = new System.Windows.Forms.Panel();
            this.cal_reserva = new kibeleza_ti16_nathan.MeuCalendario();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_horario.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_horario.Location = new System.Drawing.Point(1139, 311);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(110, 27);
            this.lbl_horario.TabIndex = 132;
            this.lbl_horario.Text = "HORÁRIO";
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_funcionario.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_funcionario.Location = new System.Drawing.Point(360, 311);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(155, 27);
            this.lbl_funcionario.TabIndex = 131;
            this.lbl_funcionario.Text = "FUNCIONÁRIO";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_cliente.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cliente.Location = new System.Drawing.Point(360, 395);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(97, 27);
            this.lbl_cliente.TabIndex = 130;
            this.lbl_cliente.Text = "CLIENTE";
            // 
            // lbl_servico
            // 
            this.lbl_servico.AutoSize = true;
            this.lbl_servico.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_servico.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_servico.Location = new System.Drawing.Point(360, 469);
            this.lbl_servico.Name = "lbl_servico";
            this.lbl_servico.Size = new System.Drawing.Size(103, 27);
            this.lbl_servico.TabIndex = 129;
            this.lbl_servico.Text = "SERVIÇO";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_status.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_status.Location = new System.Drawing.Point(360, 539);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(90, 27);
            this.lbl_status.TabIndex = 128;
            this.lbl_status.Text = "STATUS";
            // 
            // lbl_data_reserva
            // 
            this.lbl_data_reserva.AutoSize = true;
            this.lbl_data_reserva.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_data_reserva.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_reserva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_data_reserva.Location = new System.Drawing.Point(806, 311);
            this.lbl_data_reserva.Name = "lbl_data_reserva";
            this.lbl_data_reserva.Size = new System.Drawing.Size(204, 27);
            this.lbl_data_reserva.TabIndex = 127;
            this.lbl_data_reserva.Text = "DATA DA RESERVA";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_salvar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(1144, 666);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(136, 44);
            this.btn_salvar.TabIndex = 126;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            // 
            // cmb_horario
            // 
            this.cmb_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Location = new System.Drawing.Point(1135, 341);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(145, 33);
            this.cmb_horario.TabIndex = 125;
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(352, 569);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(416, 33);
            this.cmb_status.TabIndex = 124;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(352, 425);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(416, 33);
            this.cmb_cliente.TabIndex = 123;
            // 
            // cmb_servico
            // 
            this.cmb_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_servico.FormattingEnabled = true;
            this.cmb_servico.Location = new System.Drawing.Point(352, 499);
            this.cmb_servico.Name = "cmb_servico";
            this.cmb_servico.Size = new System.Drawing.Size(416, 33);
            this.cmb_servico.TabIndex = 122;
            // 
            // lbl_observacao
            // 
            this.lbl_observacao.AutoSize = true;
            this.lbl_observacao.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_observacao.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_observacao.Location = new System.Drawing.Point(526, 230);
            this.lbl_observacao.Name = "lbl_observacao";
            this.lbl_observacao.Size = new System.Drawing.Size(153, 27);
            this.lbl_observacao.TabIndex = 121;
            this.lbl_observacao.Text = "OBSERVAÇÃO";
            // 
            // txt_observacao
            // 
            this.txt_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observacao.Location = new System.Drawing.Point(517, 260);
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(763, 31);
            this.txt_observacao.TabIndex = 120;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_limpar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(989, 666);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(136, 44);
            this.btn_limpar.TabIndex = 119;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(352, 260);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(159, 31);
            this.txt_codigo.TabIndex = 118;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_codigo.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_codigo.Location = new System.Drawing.Point(360, 230);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(96, 27);
            this.lbl_codigo.TabIndex = 117;
            this.lbl_codigo.Text = "CÓDIGO";
            // 
            // cmb_funcionario
            // 
            this.cmb_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_funcionario.FormattingEnabled = true;
            this.cmb_funcionario.Location = new System.Drawing.Point(352, 341);
            this.cmb_funcionario.Name = "cmb_funcionario";
            this.cmb_funcionario.Size = new System.Drawing.Size(416, 33);
            this.cmb_funcionario.TabIndex = 116;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.btn_fechar.Location = new System.Drawing.Point(1286, 140);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(39, 40);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 114;
            this.btn_fechar.TabStop = false;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.Brown;
            this.pnl_titulo.Controls.Add(this.lbl_titulo);
            this.pnl_titulo.Location = new System.Drawing.Point(352, 140);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(928, 68);
            this.pnl_titulo.TabIndex = 115;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(273, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(360, 41);
            this.lbl_titulo.TabIndex = 20;
            this.lbl_titulo.Text = "CADASTRAR SERVIÇO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kibeleza_ti16_nathan.Properties.Resources.reserva;
            this.pictureBox1.Location = new System.Drawing.Point(161, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1173, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_info_reserva
            // 
            this.pnl_info_reserva.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_info_reserva.Location = new System.Drawing.Point(344, 298);
            this.pnl_info_reserva.Name = "pnl_info_reserva";
            this.pnl_info_reserva.Size = new System.Drawing.Size(440, 238);
            this.pnl_info_reserva.TabIndex = 134;
            // 
            // cal_reserva
            // 
            this.cal_reserva.Location = new System.Drawing.Point(807, 347);
            this.cal_reserva.Name = "cal_reserva";
            this.cal_reserva.TabIndex = 133;
            // 
            // frm_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1495, 882);
            this.Controls.Add(this.cal_reserva);
            this.Controls.Add(this.lbl_horario);
            this.Controls.Add(this.lbl_funcionario);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.lbl_servico);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_data_reserva);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cmb_horario);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.cmb_servico);
            this.Controls.Add(this.lbl_observacao);
            this.Controls.Add(this.txt_observacao);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.cmb_funcionario);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_info_reserva);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_reserva";
            this.Text = "Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.Label lbl_funcionario;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_servico;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_data_reserva;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cmb_horario;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_servico;
        private System.Windows.Forms.Label lbl_observacao;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.ComboBox cmb_funcionario;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MeuCalendario cal_reserva;
        private System.Windows.Forms.Panel pnl_info_reserva;
    }
}