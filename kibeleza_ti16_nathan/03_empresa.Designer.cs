namespace kibeleza_ti16_nathan
{
    partial class frm_empresa
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
            this.pnl_empresa = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.pct_fechar = new System.Windows.Forms.PictureBox();
            this.dgv_empresa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_empresa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_empresa
            // 
            this.pnl_empresa.Image = global::kibeleza_ti16_nathan.Properties.Resources.empresa;
            this.pnl_empresa.Location = new System.Drawing.Point(176, 150);
            this.pnl_empresa.Name = "pnl_empresa";
            this.pnl_empresa.Size = new System.Drawing.Size(1173, 621);
            this.pnl_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_empresa.TabIndex = 0;
            this.pnl_empresa.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_empresa);
            this.panel1.Location = new System.Drawing.Point(367, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 68);
            this.panel1.TabIndex = 3;
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "TODOS",
            "ATIVA",
            "INATIVA"});
            this.cmb_status.Location = new System.Drawing.Point(752, 15);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(159, 33);
            this.cmb_status.TabIndex = 23;
            this.cmb_status.Click += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "EMPRESA";
            // 
            // txt_empresa
            // 
            this.txt_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empresa.Location = new System.Drawing.Point(146, 18);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(479, 31);
            this.txt_empresa.TabIndex = 19;
            this.txt_empresa.Click += new System.EventHandler(this.txt_empresa_TextChanged);
            // 
            // btn_agendar
            // 
            this.btn_agendar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_agendar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendar.ForeColor = System.Drawing.Color.White;
            this.btn_agendar.Location = new System.Drawing.Point(367, 713);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(136, 44);
            this.btn_agendar.TabIndex = 25;
            this.btn_agendar.Text = "AGENDAR";
            this.btn_agendar.UseVisualStyleBackColor = false;
            this.btn_agendar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_alterar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(750, 713);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(136, 44);
            this.btn_alterar.TabIndex = 26;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Chocolate;
            this.btn_excluir.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(1159, 713);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(136, 44);
            this.btn_excluir.TabIndex = 27;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // pct_fechar
            // 
            this.pct_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.pct_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.pct_fechar.Location = new System.Drawing.Point(1301, 159);
            this.pct_fechar.Name = "pct_fechar";
            this.pct_fechar.Size = new System.Drawing.Size(39, 40);
            this.pct_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_fechar.TabIndex = 2;
            this.pct_fechar.TabStop = false;
            this.pct_fechar.Click += new System.EventHandler(this.pct_fechar_Click);
            // 
            // dgv_empresa
            // 
            this.dgv_empresa.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresa.Location = new System.Drawing.Point(367, 233);
            this.dgv_empresa.Name = "dgv_empresa";
            this.dgv_empresa.Size = new System.Drawing.Size(928, 462);
            this.dgv_empresa.TabIndex = 28;
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.dgv_empresa);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pct_fechar);
            this.Controls.Add(this.pnl_empresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_empresa";
            this.Text = "frm_empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_empresa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pnl_empresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.PictureBox pct_fechar;
        private System.Windows.Forms.DataGridView dgv_empresa;
    }
}