namespace kibeleza_ti16_nathan
{
    partial class frm_funcionario
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
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            this.pct_fechar = new System.Windows.Forms.PictureBox();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnl_funcionario = new System.Windows.Forms.PictureBox();
            this.txt_funcionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_funcionario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToDeleteRows = false;
            this.dgv_funcionario.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Location = new System.Drawing.Point(351, 222);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.ReadOnly = true;
            this.dgv_funcionario.Size = new System.Drawing.Size(927, 462);
            this.dgv_funcionario.TabIndex = 32;
            // 
            // pct_fechar
            // 
            this.pct_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.pct_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.pct_fechar.Location = new System.Drawing.Point(1284, 136);
            this.pct_fechar.Name = "pct_fechar";
            this.pct_fechar.Size = new System.Drawing.Size(39, 40);
            this.pct_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_fechar.TabIndex = 31;
            this.pct_fechar.TabStop = false;
            this.pct_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_agendar
            // 
            this.btn_agendar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_agendar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendar.ForeColor = System.Drawing.Color.White;
            this.btn_agendar.Location = new System.Drawing.Point(351, 690);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(136, 44);
            this.btn_agendar.TabIndex = 28;
            this.btn_agendar.Text = "AGENDAR";
            this.btn_agendar.UseVisualStyleBackColor = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_alterar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(734, 690);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(136, 44);
            this.btn_alterar.TabIndex = 29;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Chocolate;
            this.btn_excluir.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(1143, 690);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(136, 44);
            this.btn_excluir.TabIndex = 30;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox4.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.pictureBox4.Location = new System.Drawing.Point(1284, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pnl_funcionario
            // 
            this.pnl_funcionario.Image = global::kibeleza_ti16_nathan.Properties.Resources.funcionario;
            this.pnl_funcionario.Location = new System.Drawing.Point(161, 124);
            this.pnl_funcionario.Name = "pnl_funcionario";
            this.pnl_funcionario.Size = new System.Drawing.Size(1173, 621);
            this.pnl_funcionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_funcionario.TabIndex = 25;
            this.pnl_funcionario.TabStop = false;
            // 
            // txt_funcionario
            // 
            this.txt_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcionario.Location = new System.Drawing.Point(131, 18);
            this.txt_funcionario.Name = "txt_funcionario";
            this.txt_funcionario.Size = new System.Drawing.Size(494, 31);
            this.txt_funcionario.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "FUNCIONÁRIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(642, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "STATUS";
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmb_status.Location = new System.Drawing.Point(752, 15);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(159, 33);
            this.cmb_status.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_funcionario);
            this.panel1.Location = new System.Drawing.Point(350, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 68);
            this.panel1.TabIndex = 27;
            // 
            // frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1491, 874);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.pct_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_funcionario);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_funcionario";
            this.Text = "Funcionário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_funcionario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.PictureBox pct_fechar;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pnl_funcionario;
        private System.Windows.Forms.TextBox txt_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Panel panel1;
    }
}