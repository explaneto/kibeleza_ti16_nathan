namespace kibeleza_ti16_nathan
{
    partial class frm_cliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.pct_fechar = new System.Windows.Forms.PictureBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.pnl_cliente = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.lbl_cliente);
            this.panel1.Controls.Add(this.txt_cliente);
            this.panel1.Location = new System.Drawing.Point(352, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 68);
            this.panel1.TabIndex = 34;
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
            this.cmb_status.Click += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_status.Location = new System.Drawing.Point(642, 19);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(102, 30);
            this.lbl_status.TabIndex = 22;
            this.lbl_status.Text = "STATUS";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cliente.Location = new System.Drawing.Point(16, 19);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(109, 30);
            this.lbl_cliente.TabIndex = 20;
            this.lbl_cliente.Text = "CLIENTE";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(131, 18);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(494, 31);
            this.txt_cliente.TabIndex = 19;
            this.txt_cliente.Click += new System.EventHandler(this.txt_cliente_TextChanged);
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(352, 225);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.Size = new System.Drawing.Size(928, 464);
            this.dgv_cliente.TabIndex = 39;
            // 
            // pct_fechar
            // 
            this.pct_fechar.BackColor = System.Drawing.Color.MistyRose;
            this.pct_fechar.Image = global::kibeleza_ti16_nathan.Properties.Resources.fechar;
            this.pct_fechar.Location = new System.Drawing.Point(1286, 142);
            this.pct_fechar.Name = "pct_fechar";
            this.pct_fechar.Size = new System.Drawing.Size(39, 40);
            this.pct_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_fechar.TabIndex = 38;
            this.pct_fechar.TabStop = false;
            this.pct_fechar.Click += new System.EventHandler(this.pct_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Chocolate;
            this.btn_excluir.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(1144, 695);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(136, 44);
            this.btn_excluir.TabIndex = 37;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_alterar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(735, 695);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(136, 44);
            this.btn_alterar.TabIndex = 36;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_agendar
            // 
            this.btn_agendar.BackColor = System.Drawing.Color.Chocolate;
            this.btn_agendar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendar.ForeColor = System.Drawing.Color.White;
            this.btn_agendar.Location = new System.Drawing.Point(352, 695);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(136, 44);
            this.btn_agendar.TabIndex = 35;
            this.btn_agendar.Text = "AGENDAR";
            this.btn_agendar.UseVisualStyleBackColor = false;
            this.btn_agendar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // pnl_cliente
            // 
            this.pnl_cliente.Image = global::kibeleza_ti16_nathan.Properties.Resources.cliente;
            this.pnl_cliente.Location = new System.Drawing.Point(161, 133);
            this.pnl_cliente.Name = "pnl_cliente";
            this.pnl_cliente.Size = new System.Drawing.Size(1173, 621);
            this.pnl_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_cliente.TabIndex = 33;
            this.pnl_cliente.TabStop = false;
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kibeleza_ti16_nathan.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1494, 887);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_cliente);
            this.Controls.Add(this.pct_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.pnl_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cliente";
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.PictureBox pct_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.PictureBox pnl_cliente;
    }
}