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
            label2 = new Label();
            label1 = new Label();
            Input_y1 = new TextBox();
            Input_x1 = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            Input_y2 = new TextBox();
            label4 = new Label();
            Input_x2 = new TextBox();
            groupBox3 = new GroupBox();
            r_khoangcach = new TextBox();
            label6 = new Label();
            r_hesogoc = new TextBox();
            label5 = new Label();
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
            groupBox1.Controls.Add(Input_y1);
            groupBox1.Controls.Add(Input_x1);
            groupBox1.Location = new Point(103, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Diem thu nhat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 71);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 5;
            label2.Text = "y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 4;
            label1.Text = "x";
            // 
            // Input_y1
            // 
            Input_y1.Location = new Point(80, 71);
            Input_y1.Name = "Input_y1";
            Input_y1.Size = new Size(100, 23);
            Input_y1.TabIndex = 3;
            // 
            // Input_x1
            // 
            Input_x1.Location = new Point(80, 33);
            Input_x1.Name = "Input_x1";
            Input_x1.Size = new Size(100, 23);
            Input_x1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Input_y2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Input_x2);
            groupBox2.Location = new Point(398, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Diem thu hai";
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
            // Input_y2
            // 
            Input_y2.Location = new Point(83, 71);
            Input_y2.Name = "Input_y2";
            Input_y2.Size = new Size(100, 23);
            Input_y2.TabIndex = 5;
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
            // Input_x2
            // 
            Input_x2.Location = new Point(83, 33);
            Input_x2.Name = "Input_x2";
            Input_x2.Size = new Size(100, 23);
            Input_x2.TabIndex = 4;
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
            // r_khoangcach
            // 
            r_khoangcach.HideSelection = false;
            r_khoangcach.Location = new Point(284, 70);
            r_khoangcach.Name = "r_khoangcach";
            r_khoangcach.ReadOnly = true;
            r_khoangcach.Size = new Size(152, 23);
            r_khoangcach.TabIndex = 7;
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
            // r_hesogoc
            // 
            r_hesogoc.HideSelection = false;
            r_hesogoc.Location = new Point(25, 70);
            r_hesogoc.Name = "r_hesogoc";
            r_hesogoc.ReadOnly = true;
            r_hesogoc.Size = new Size(152, 23);
            r_hesogoc.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 36);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "He so goc";
            // 
            // btnTinhToan
            // 
            btnTinhToan.Location = new Point(296, 382);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(98, 29);
            btnTinhToan.TabIndex = 3;
            btnTinhToan.Text = "Tinh Toan";
            btnTinhToan.UseVisualStyleBackColor = true;
            btnTinhToan.Click += btnTinhToan_Click;
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
        private TextBox Input_x1;
        private TextBox Input_y1;
        private TextBox Input_y2;
        private TextBox Input_x2;
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
