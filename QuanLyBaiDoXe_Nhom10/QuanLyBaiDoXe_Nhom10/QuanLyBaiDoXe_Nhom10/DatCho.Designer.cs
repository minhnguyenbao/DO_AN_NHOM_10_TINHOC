namespace QuanLyBaiDoXe_Nhom10
{
    partial class DatCho
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
            this.btThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatCho = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatCho = new System.Windows.Forms.DataGridView();
            this.btnChonCho = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaixe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phuongthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydukientra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThanhToan
            // 
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.Location = new System.Drawing.Point(570, 339);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(154, 69);
            this.btThanhToan.TabIndex = 42;
            this.btThanhToan.Text = "THANH TOÁN !!";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(436, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "PHƯƠNG THỨC ĐẶT CHỖ";
            // 
            // btnDatCho
            // 
            this.btnDatCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatCho.Location = new System.Drawing.Point(856, 339);
            this.btnDatCho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDatCho.Name = "btnDatCho";
            this.btnDatCho.Size = new System.Drawing.Size(146, 69);
            this.btnDatCho.TabIndex = 39;
            this.btnDatCho.Text = "ĐẶT CHỖ";
            this.btnDatCho.UseVisualStyleBackColor = true;
            this.btnDatCho.Click += new System.EventHandler(this.btnDatCho_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyBaiDoXe_Nhom10.Properties.Resources.user_icon_149329;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(36, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 174);
            this.panel1.TabIndex = 40;
            // 
            // dgvDatCho
            // 
            this.dgvDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatCho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hovaten,
            this.Column1,
            this.Ngaydat,
            this.Phuongthuc,
            this.Ngaydukientra});
            this.dgvDatCho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatCho.Location = new System.Drawing.Point(0, 455);
            this.dgvDatCho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatCho.Name = "dgvDatCho";
            this.dgvDatCho.RowHeadersWidth = 62;
            this.dgvDatCho.Size = new System.Drawing.Size(1152, 265);
            this.dgvDatCho.TabIndex = 27;
            this.dgvDatCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatCho_CellClick);
            // 
            // btnChonCho
            // 
            this.btnChonCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonCho.Location = new System.Drawing.Point(286, 339);
            this.btnChonCho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonCho.Name = "btnChonCho";
            this.btnChonCho.Size = new System.Drawing.Size(154, 69);
            this.btnChonCho.TabIndex = 38;
            this.btnChonCho.Text = "CHỌN CHỖ";
            this.btnChonCho.UseVisualStyleBackColor = true;
            this.btnChonCho.Click += new System.EventHandler(this.btnChonCho_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "6 Tiếng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Qua Đêm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(9, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Theo Tháng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(194, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "20,000 VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(181, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "100,000 VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(163, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "1,000,000 VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(739, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(343, 175);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BẢNG GIÁ GIỮ XE";
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(420, 209);
            this.txtVitri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(298, 26);
            this.txtVitri.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Vị trí đặt chỗ";
            // 
            // txtLoaixe
            // 
            this.txtLoaixe.Location = new System.Drawing.Point(420, 169);
            this.txtLoaixe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoaixe.Name = "txtLoaixe";
            this.txtLoaixe.Size = new System.Drawing.Size(298, 26);
            this.txtLoaixe.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(260, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Loại Xe";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(420, 129);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(298, 26);
            this.txtMa.TabIndex = 52;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(420, 86);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(298, 26);
            this.txtTenKH.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Họ và tên";
            // 
            // Hovaten
            // 
            this.Hovaten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hovaten.DataPropertyName = "HoTen";
            this.Hovaten.HeaderText = "Họ và tên";
            this.Hovaten.MinimumWidth = 8;
            this.Hovaten.Name = "Hovaten";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Ngaydat
            // 
            this.Ngaydat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaydat.DataPropertyName = "ViTri";
            this.Ngaydat.HeaderText = "Vị trí";
            this.Ngaydat.MinimumWidth = 8;
            this.Ngaydat.Name = "Ngaydat";
            // 
            // Phuongthuc
            // 
            this.Phuongthuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phuongthuc.DataPropertyName = "Loaixe";
            this.Phuongthuc.HeaderText = "Loại xe";
            this.Phuongthuc.MinimumWidth = 8;
            this.Phuongthuc.Name = "Phuongthuc";
            // 
            // Ngaydukientra
            // 
            this.Ngaydukientra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaydukientra.DataPropertyName = "TGDatCho";
            this.Ngaydukientra.HeaderText = "Thời gian đặt chỗ";
            this.Ngaydukientra.MinimumWidth = 8;
            this.Ngaydukientra.Name = "Ngaydukientra";
            // 
            // DatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 720);
            this.Controls.Add(this.txtVitri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoaixe);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDatCho);
            this.Controls.Add(this.btnChonCho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatCho);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatCho";
            this.Text = "DatCho";
            this.Load += new System.EventHandler(this.DatCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatCho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatCho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatCho;
        private System.Windows.Forms.Button btnChonCho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoaixe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phuongthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydukientra;
    }
}