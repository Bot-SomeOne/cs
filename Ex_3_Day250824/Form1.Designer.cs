namespace Ex_3_Day250824
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            title = new Label();
            lable_A = new Label();
            ip_a = new TextBox();
            ip_b = new TextBox();
            lable_b = new Label();
            ip_c = new TextBox();
            label_c = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            ip_res = new TextBox();
            label_kq = new Label();
            btn_giaiPT = new Button();
            btn_LamLai = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(173, 33);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(287, 32);
            title.TabIndex = 0;
            title.Text = "Giai Phuong Trinh Bac 2";
            // 
            // lable_A
            // 
            lable_A.AutoSize = true;
            lable_A.ForeColor = Color.Black;
            lable_A.Location = new Point(85, 130);
            lable_A.Name = "lable_A";
            lable_A.Size = new Size(73, 21);
            lable_A.TabIndex = 1;
            lable_A.Text = "Nhap a: ";
            // 
            // ip_a
            // 
            ip_a.Location = new Point(218, 127);
            ip_a.Name = "ip_a";
            ip_a.Size = new Size(314, 29);
            ip_a.TabIndex = 2;
            // 
            // ip_b
            // 
            ip_b.Location = new Point(218, 196);
            ip_b.Name = "ip_b";
            ip_b.Size = new Size(314, 29);
            ip_b.TabIndex = 4;
            // 
            // lable_b
            // 
            lable_b.AutoSize = true;
            lable_b.ForeColor = Color.Black;
            lable_b.Location = new Point(85, 199);
            lable_b.Name = "lable_b";
            lable_b.Size = new Size(74, 21);
            lable_b.TabIndex = 3;
            lable_b.Text = "Nhap b: ";
            // 
            // ip_c
            // 
            ip_c.Location = new Point(218, 273);
            ip_c.Name = "ip_c";
            ip_c.Size = new Size(314, 29);
            ip_c.TabIndex = 6;
            // 
            // label_c
            // 
            label_c.AutoSize = true;
            label_c.ForeColor = Color.Black;
            label_c.Location = new Point(85, 276);
            label_c.Name = "label_c";
            label_c.Size = new Size(72, 21);
            label_c.TabIndex = 5;
            label_c.Text = "Nhap c: ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(490, 75);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 7;
            label1.Text = "y = ax^2 + bx + c";
            // 
            // ip_res
            // 
            ip_res.BackColor = Color.Khaki;
            ip_res.Location = new Point(218, 333);
            ip_res.Multiline = true;
            ip_res.Name = "ip_res";
            ip_res.ReadOnly = true;
            ip_res.Size = new Size(314, 83);
            ip_res.TabIndex = 9;
            // 
            // label_kq
            // 
            label_kq.AutoSize = true;
            label_kq.ForeColor = Color.Black;
            label_kq.Location = new Point(85, 333);
            label_kq.Name = "label_kq";
            label_kq.Size = new Size(76, 21);
            label_kq.TabIndex = 8;
            label_kq.Text = "Ket qua: ";
            // 
            // btn_giaiPT
            // 
            btn_giaiPT.Cursor = Cursors.Hand;
            btn_giaiPT.ForeColor = Color.FromArgb(64, 64, 64);
            btn_giaiPT.Location = new Point(56, 449);
            btn_giaiPT.Name = "btn_giaiPT";
            btn_giaiPT.Size = new Size(164, 34);
            btn_giaiPT.TabIndex = 10;
            btn_giaiPT.Text = "Giai Phuong Trinh";
            btn_giaiPT.UseVisualStyleBackColor = true;
            btn_giaiPT.Click += btn_giaiPT_Click;
            // 
            // btn_LamLai
            // 
            btn_LamLai.Cursor = Cursors.Hand;
            btn_LamLai.ForeColor = Color.FromArgb(64, 64, 64);
            btn_LamLai.Location = new Point(290, 449);
            btn_LamLai.Name = "btn_LamLai";
            btn_LamLai.Size = new Size(102, 34);
            btn_LamLai.TabIndex = 11;
            btn_LamLai.Text = "Lam lai";
            btn_LamLai.UseVisualStyleBackColor = true;
            btn_LamLai.Click += button_LamLai_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Cursor = Cursors.Hand;
            btn_Thoat.ForeColor = Color.FromArgb(64, 64, 64);
            btn_Thoat.Location = new Point(467, 449);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(102, 34);
            btn_Thoat.TabIndex = 12;
            btn_Thoat.Text = "Thoat";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 532);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_LamLai);
            Controls.Add(btn_giaiPT);
            Controls.Add(ip_res);
            Controls.Add(label_kq);
            Controls.Add(label1);
            Controls.Add(ip_c);
            Controls.Add(label_c);
            Controls.Add(ip_b);
            Controls.Add(lable_b);
            Controls.Add(ip_a);
            Controls.Add(lable_A);
            Controls.Add(title);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ForeColor = Color.Red;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Bai tap 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lable_A;
        private TextBox ip_a;
        private TextBox ip_b;
        private Label lable_b;
        private TextBox ip_c;
        private Label label_c;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private TextBox ip_res;
        private Label label_kq;
        private Button btn_giaiPT;
        private Button btn_LamLai;
        private Button btn_Thoat;
    }
}
