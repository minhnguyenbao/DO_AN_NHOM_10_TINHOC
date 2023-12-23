namespace QuanLyBaiDoXe_Nhom10
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.dangKy = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.quenmk = new System.Windows.Forms.Button();
            this.dangnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nếu bạn chưa có tài khoản, vui lòng nhấn";
            // 
            // dangKy
            // 
            this.dangKy.Location = new System.Drawing.Point(527, 382);
            this.dangKy.Name = "dangKy";
            this.dangKy.Size = new System.Drawing.Size(152, 35);
            this.dangKy.TabIndex = 31;
            this.dangKy.Text = "Đăng ký";
            this.dangKy.UseVisualStyleBackColor = true;
            this.dangKy.Click += new System.EventHandler(this.dangKy_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(458, 298);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 34);
            this.exit.TabIndex = 30;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // quenmk
            // 
            this.quenmk.Location = new System.Drawing.Point(423, 255);
            this.quenmk.Name = "quenmk";
            this.quenmk.Size = new System.Drawing.Size(145, 37);
            this.quenmk.TabIndex = 29;
            this.quenmk.Text = "Quên mật khẩu";
            this.quenmk.UseVisualStyleBackColor = true;
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(416, 201);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(158, 48);
            this.dangnhap.TabIndex = 28;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(412, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tài khoản";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(335, 144);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(317, 26);
            this.txtMK.TabIndex = 24;
            this.txtMK.Text = "123456";
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(335, 86);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(317, 26);
            this.txtTK.TabIndex = 23;
            this.txtTK.Text = "dodanhmanh";
            // 
            // Form1
            // 
            this.AcceptButton = this.dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dangKy);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.quenmk);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dangKy;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button quenmk;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
    }
}

