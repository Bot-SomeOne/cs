namespace th3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_odia = new System.Windows.Forms.ComboBox();
            this.comboBox_thumuc = new System.Windows.Forms.ComboBox();
            this.listBox_teptin = new System.Windows.Forms.ListBox();
            this.window_media = new AxWMPLib.AxWindowsMediaPlayer();
            this.richTextBox_loi = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.window_media)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "O dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thu muc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tep tin";
            // 
            // comboBox_odia
            // 
            this.comboBox_odia.FormattingEnabled = true;
            this.comboBox_odia.Location = new System.Drawing.Point(90, 42);
            this.comboBox_odia.Name = "comboBox_odia";
            this.comboBox_odia.Size = new System.Drawing.Size(182, 21);
            this.comboBox_odia.TabIndex = 3;
            this.comboBox_odia.SelectedIndexChanged += new System.EventHandler(this.get_Thu_Muc);
            // 
            // comboBox_thumuc
            // 
            this.comboBox_thumuc.FormattingEnabled = true;
            this.comboBox_thumuc.Location = new System.Drawing.Point(90, 83);
            this.comboBox_thumuc.Name = "comboBox_thumuc";
            this.comboBox_thumuc.Size = new System.Drawing.Size(182, 21);
            this.comboBox_thumuc.TabIndex = 4;
            this.comboBox_thumuc.SelectedIndexChanged += new System.EventHandler(this.get_tep_tin);
            // 
            // listBox_teptin
            // 
            this.listBox_teptin.FormattingEnabled = true;
            this.listBox_teptin.Location = new System.Drawing.Point(31, 171);
            this.listBox_teptin.Name = "listBox_teptin";
            this.listBox_teptin.Size = new System.Drawing.Size(241, 108);
            this.listBox_teptin.TabIndex = 5;
            this.listBox_teptin.SelectedIndexChanged += new System.EventHandler(this.get_nhac);
            // 
            // window_media
            // 
            this.window_media.Enabled = true;
            this.window_media.Location = new System.Drawing.Point(31, 302);
            this.window_media.Name = "window_media";
            this.window_media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("window_media.OcxState")));
            this.window_media.Size = new System.Drawing.Size(241, 211);
            this.window_media.TabIndex = 6;
            // 
            // richTextBox_loi
            // 
            this.richTextBox_loi.Location = new System.Drawing.Point(278, 39);
            this.richTextBox_loi.Name = "richTextBox_loi";
            this.richTextBox_loi.Size = new System.Drawing.Size(320, 474);
            this.richTextBox_loi.TabIndex = 7;
            this.richTextBox_loi.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 525);
            this.Controls.Add(this.richTextBox_loi);
            this.Controls.Add(this.window_media);
            this.Controls.Add(this.listBox_teptin);
            this.Controls.Add(this.comboBox_thumuc);
            this.Controls.Add(this.comboBox_odia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.window_media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_odia;
        private System.Windows.Forms.ComboBox comboBox_thumuc;
        private System.Windows.Forms.ListBox listBox_teptin;
        private AxWMPLib.AxWindowsMediaPlayer window_media;
        private System.Windows.Forms.RichTextBox richTextBox_loi;
    }
}

