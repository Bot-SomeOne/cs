namespace Ex2_Day250824
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            x1 = new TextBox();
            y1 = new TextBox();
            y2 = new TextBox();
            x2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            r_hesogoc = new TextBox();
            r_khoangcach = new TextBox();
            label6 = new Label();
            btnTinhToan = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(y1);
            groupBox1.Controls.Add(x1);
            groupBox1.Location = new Point(103, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Diem thu nhat";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(y2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(x2);
            groupBox2.Location = new Point(398, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Diem thu hai";
            // 
            // x1
            // 
            x1.Location = new Point(80, 33);
            x1.Name = "x1";
            x1.Size = new Size(100, 23);
            x1.TabIndex = 2;
            x1.TextChanged += textBox1_TextChanged;
            // 
            // y1
            // 
            y1.Location = new Point(80, 71);
            y1.Name = "y1";
            y1.Size = new Size(100, 23);
            y1.TabIndex = 3;
            // 
            // y2
            // 
            y2.Location = new Point(83, 71);
            y2.Name = "y2";
            y2.Size = new Size(100, 23);
            y2.TabIndex = 5;
            // 
            // x2
            // 
            x2.Location = new Point(83, 33);
            x2.Name = "x2";
            x2.Size = new Size(100, 23);
            x2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 4;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 71);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 5;
            label2.Text = "y";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 71);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 7;
            label3.Text = "y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 36);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 6;
            label4.Text = "x";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(r_khoangcach);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(r_hesogoc);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(103, 222);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(495, 123);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 36);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "He so goc";
            label5.Click += label5_Click;
            // 
            // r_hesogoc
            // 
            r_hesogoc.HideSelection = false;
            r_hesogoc.Location = new Point(25, 70);
            r_hesogoc.Name = "r_hesogoc";
            r_hesogoc.ReadOnly = true;
            r_hesogoc.Size = new Size(152, 23);
            r_hesogoc.TabIndex = 6;
            r_hesogoc.TextChanged += textBox1_TextChanged_1;
            // 
            // r_khoangcach
            // 
            r_khoangcach.HideSelection = false;
            r_khoangcach.Location = new Point(284, 70);
            r_khoangcach.Name = "r_khoangcach";
            r_khoangcach.ReadOnly = true;
            r_khoangcach.Size = new Size(152, 23);
            r_khoangcach.TabIndex = 7;
            r_khoangcach.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 36);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 8;
            label6.Text = "Khoang cach";
            // 
            // btnTinhToan
            // 
            btnTinhToan.Location = new Point(296, 382);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(98, 29);
            btnTinhToan.TabIndex = 3;
            btnTinhToan.Text = "Tinh Toan";
            btnTinhToan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(btnTinhToan);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Toa do cac diem";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox x1;
        private TextBox y1;
        private TextBox y2;
        private TextBox x2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox r_hesogoc;
        private TextBox r_khoangcach;
        private Label label6;
        private Button btnTinhToan;
    }
}
