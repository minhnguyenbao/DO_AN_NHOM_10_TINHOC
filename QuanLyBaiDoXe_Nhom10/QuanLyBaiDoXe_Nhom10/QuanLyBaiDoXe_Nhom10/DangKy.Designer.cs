namespace QuanLyBaiDoXe_Nhom10
{
    partial class DangKy
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
            this.btnDangKi = new System.Windows.Forms.Button();
            this.txt_NhapLaiMK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(333, 290);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(127, 45);
            this.btnDangKi.TabIndex = 16;
            this.btnDangKi.Text = "Đăng ký";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // txt_NhapLaiMK
            // 
            this.txt_NhapLaiMK.Location = new System.Drawing.Point(333, 206);
            this.txt_NhapLaiMK.Name = "txt_NhapLaiMK";
            this.txt_NhapLaiMK.Size = new System.Drawing.Size(279, 26);
            this.txt_NhapLaiMK.TabIndex = 15;
            this.txt_NhapLaiMK.UseSystemPasswordChar = true;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(333, 148);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(279, 26);
            this.txt_MK.TabIndex = 14;
            this.txt_MK.UseSystemPasswordChar = true;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Location = new System.Drawing.Point(333, 94);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(279, 26);
            this.txt_TenTK.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên tài khoản";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.txt_NhapLaiMK);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TenTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.TextBox txt_NhapLaiMK;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}