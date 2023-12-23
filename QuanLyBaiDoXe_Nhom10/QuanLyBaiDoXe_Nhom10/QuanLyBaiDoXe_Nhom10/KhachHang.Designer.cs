namespace QuanLyBaiDoXe_Nhom10
{
    partial class KhachHang
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.rNu = new System.Windows.Forms.RadioButton();
            this.rNam = new System.Windows.Forms.RadioButton();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(985, 70);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(122, 56);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // rNu
            // 
            this.rNu.AutoSize = true;
            this.rNu.Location = new System.Drawing.Point(371, 263);
            this.rNu.Name = "rNu";
            this.rNu.Size = new System.Drawing.Size(54, 24);
            this.rNu.TabIndex = 32;
            this.rNu.TabStop = true;
            this.rNu.Text = "Nữ";
            this.rNu.UseVisualStyleBackColor = false;
            // 
            // rNam
            // 
            this.rNam.AutoSize = true;
            this.rNam.Location = new System.Drawing.Point(240, 263);
            this.rNam.Name = "rNam";
            this.rNam.Size = new System.Drawing.Size(67, 24);
            this.rNam.TabIndex = 31;
            this.rNam.Text = "Nam";
            this.rNam.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(985, 254);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(122, 52);
            this.btn_Luu.TabIndex = 33;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(985, 191);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(122, 57);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(985, 132);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(122, 53);
            this.btn_xoa.TabIndex = 29;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvKhachHang.Location = new System.Drawing.Point(62, 338);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.RowTemplate.Height = 28;
            this.dgvKhachHang.Size = new System.Drawing.Size(1117, 180);
            this.dgvKhachHang.TabIndex = 28;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mẫ khách hàng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CCCD";
            this.Column5.HeaderText = "CCCD";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiaChi";
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "LoaiXe";
            this.Column8.HeaderText = "Loại xe";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(229, 199);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(261, 26);
            this.dtNgaySinh.TabIndex = 27;
            this.dtNgaySinh.Value = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(698, 196);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 26);
            this.txtDiaChi.TabIndex = 25;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(698, 139);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(228, 26);
            this.txtSDT.TabIndex = 26;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(698, 80);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(228, 26);
            this.txtCCCD.TabIndex = 24;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(229, 143);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(261, 26);
            this.txtTenKH.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(533, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Loại xe";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Ô tô 4 chỗ",
            "Ô tô 7 chỗ"});
            this.cbLoaiXe.Location = new System.Drawing.Point(698, 257);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(228, 28);
            this.cbLoaiXe.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(229, 84);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(261, 26);
            this.txtMaKH.TabIndex = 22;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 597);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rNu);
            this.Controls.Add(this.rNam);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RadioButton rNu;
        private System.Windows.Forms.RadioButton rNam;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}