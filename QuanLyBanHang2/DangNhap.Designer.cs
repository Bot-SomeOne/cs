namespace QuanLyBanHang.Models
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            txtMNV = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            txtMK = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 25);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 139);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            // 
            // txtMNV
            // 
            txtMNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMNV.Location = new Point(280, 136);
            txtMNV.Name = "txtMNV";
            txtMNV.Size = new Size(205, 26);
            txtMNV.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(467, 305);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(156, 49);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(57, 305);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(156, 49);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(280, 186);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '#';
            txtMK.Size = new Size(205, 26);
            txtMK.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(143, 193);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 5;
            label3.Text = "Mật khẩu:";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(txtMK);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMNV);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DangNhap";
            Text = "Login";
            Load += frmLoginHDB_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private TextBox txtMK;
        private Label label3;
    }
}