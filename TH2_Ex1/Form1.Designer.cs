namespace TH2_Ex1
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
            this.txtTenMonHoc = new System.Windows.Forms.GroupBox();
            this.cbbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongSoTinChi = new System.Windows.Forms.TextBox();
            this.txtDiemTrungBinh = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtTongSoDiem = new System.Windows.Forms.TextBox();
            this.txtDSMH = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Controls.Add(this.cbbTenMonHoc);
            this.txtTenMonHoc.Controls.Add(this.btnThemVaoDS);
            this.txtTenMonHoc.Controls.Add(this.txtDiem);
            this.txtTenMonHoc.Controls.Add(this.txtSoTinChi);
            this.txtTenMonHoc.Controls.Add(this.label3);
            this.txtTenMonHoc.Controls.Add(this.label2);
            this.txtTenMonHoc.Controls.Add(this.label1);
            this.txtTenMonHoc.Location = new System.Drawing.Point(35, 31);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(503, 591);
            this.txtTenMonHoc.TabIndex = 0;
            this.txtTenMonHoc.TabStop = false;
            this.txtTenMonHoc.Text = "Thong tin diem sinh vien";
            // 
            // cbbTenMonHoc
            // 
            this.cbbTenMonHoc.FormattingEnabled = true;
            this.cbbTenMonHoc.Location = new System.Drawing.Point(57, 111);
            this.cbbTenMonHoc.Name = "cbbTenMonHoc";
            this.cbbTenMonHoc.Size = new System.Drawing.Size(397, 27);
            this.cbbTenMonHoc.TabIndex = 5;
            this.cbbTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.handleChonMonHoc);
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(152, 417);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(164, 42);
            this.btnThemVaoDS.TabIndex = 3;
            this.btnThemVaoDS.Text = "Them vao DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(161, 295);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(205, 26);
            this.txtDiem.TabIndex = 2;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diem_KeyPress);
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(161, 211);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(293, 26);
            this.txtSoTinChi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Diem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "So tin chi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten mon hoc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDSMH);
            this.groupBox2.Location = new System.Drawing.Point(544, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach cac mon hoc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tong so tin chi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(855, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tong so diem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(594, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Diem trung binh";
            // 
            // txtTongSoTinChi
            // 
            this.txtTongSoTinChi.Location = new System.Drawing.Point(677, 377);
            this.txtTongSoTinChi.Name = "txtTongSoTinChi";
            this.txtTongSoTinChi.ReadOnly = true;
            this.txtTongSoTinChi.Size = new System.Drawing.Size(100, 26);
            this.txtTongSoTinChi.TabIndex = 3;
            // 
            // txtDiemTrungBinh
            // 
            this.txtDiemTrungBinh.Location = new System.Drawing.Point(723, 471);
            this.txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            this.txtDiemTrungBinh.ReadOnly = true;
            this.txtDiemTrungBinh.Size = new System.Drawing.Size(112, 26);
            this.txtDiemTrungBinh.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(859, 548);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 34);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(677, 548);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 34);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // txtTongSoDiem
            // 
            this.txtTongSoDiem.Location = new System.Drawing.Point(951, 377);
            this.txtTongSoDiem.Name = "txtTongSoDiem";
            this.txtTongSoDiem.ReadOnly = true;
            this.txtTongSoDiem.Size = new System.Drawing.Size(100, 26);
            this.txtTongSoDiem.TabIndex = 3;
            // 
            // txtDSMH
            // 
            this.txtDSMH.Location = new System.Drawing.Point(18, 25);
            this.txtDSMH.Multiline = true;
            this.txtDSMH.Name = "txtDSMH";
            this.txtDSMH.ReadOnly = true;
            this.txtDSMH.Size = new System.Drawing.Size(469, 267);
            this.txtDSMH.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 640);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtDiemTrungBinh);
            this.Controls.Add(this.txtTongSoDiem);
            this.Controls.Add(this.txtTongSoTinChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTenMonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listenKeyPress);
            this.txtTenMonHoc.ResumeLayout(false);
            this.txtTenMonHoc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.TextBox txtTongSoTinChi;
        private System.Windows.Forms.TextBox txtDiemTrungBinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtTongSoDiem;
        private System.Windows.Forms.ComboBox cbbTenMonHoc;
        private System.Windows.Forms.TextBox txtDSMH;
    }
}

