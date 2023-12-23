namespace QuanLyBaiDoXe_Nhom10
{
    partial class GiaoDienChinh
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDatCho = new System.Windows.Forms.Button();
            this.btnThongTinBD = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnDatCho);
            this.panel1.Controls.Add(this.btnThongTinBD);
            this.panel1.Controls.Add(this.btn_KhachHang);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 787);
            this.panel1.TabIndex = 8;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(0, 387);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(229, 62);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnDatCho
            // 
            this.btnDatCho.Location = new System.Drawing.Point(0, 319);
            this.btnDatCho.Name = "btnDatCho";
            this.btnDatCho.Size = new System.Drawing.Size(229, 62);
            this.btnDatCho.TabIndex = 2;
            this.btnDatCho.Text = "Đặt chỗ";
            this.btnDatCho.UseVisualStyleBackColor = true;
            this.btnDatCho.Click += new System.EventHandler(this.btnDatCho_Click);
            // 
            // btnThongTinBD
            // 
            this.btnThongTinBD.Location = new System.Drawing.Point(0, 251);
            this.btnThongTinBD.Name = "btnThongTinBD";
            this.btnThongTinBD.Size = new System.Drawing.Size(229, 62);
            this.btnThongTinBD.TabIndex = 1;
            this.btnThongTinBD.Text = "Thông tin bãi đỗ";
            this.btnThongTinBD.UseVisualStyleBackColor = true;
            this.btnThongTinBD.Click += new System.EventHandler(this.btnThongTinBD_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.Location = new System.Drawing.Point(0, 183);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(229, 62);
            this.btn_KhachHang.TabIndex = 0;
            this.btn_KhachHang.Text = "Khách hàng";
            this.btn_KhachHang.UseVisualStyleBackColor = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(227, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 787);
            this.panel2.TabIndex = 9;
            // 
            // GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 791);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoDienChinh";
            this.Text = "GiaoDienChinh";
            this.Load += new System.EventHandler(this.GiaoDienChinh_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDatCho;
        private System.Windows.Forms.Button btnThongTinBD;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Panel panel2;
    }
}