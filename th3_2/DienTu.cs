using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using th3_2.Models;

namespace th3_2
{
    public partial class DienTu : Form
    {
        // Variable
        private int diem = 0;
        private BaiTapDienTu model;

        public DienTu(BaiTapDienTu m)
        {
            InitializeComponent();
            init(m);
        }

        // Private init data
        private void init(BaiTapDienTu m)
        {
            this.model = m;
            richTextBox_debai.Text = m.CauHoi;
        }

        // Kiem tra ket qua
        private void button_ok_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                TextBox textBox = this.Controls.Find($"textBox_{i}", true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    if (textBox.Text.ToUpper() == model.DapAnList[i - 1].ToUpper())
                    {
                        changeColor(textBox, true);
                        this.diem++;
                    }
                    else
                    {
                        changeColor(textBox, false);
                    }
                }
            }
            MessageBox.Show($"Ban da tra loi dung {diem} cau", "Ket qua");
        }

        // Helper Xu li doi mau text box khi cau dung hoac sai
        private void changeColor(TextBox tb, bool isCorrect)
        {
            if (isCorrect)
            {
                tb.BackColor = Color.Green;
            }
            else
            {
                tb.BackColor = Color.Red;
            }
        }

        // Hien thi tat ca cau tra loi
        private void button_dapan_Click(object sender, EventArgs e)
        {
            richTextBox_debai.Text = model.DapAn;
            for (int i = 1; i <= 10; i++)
            {
                TextBox textBox = this.Controls.Find($"textBox_{i}", true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    textBox.Text = model.DapAnList[i - 1];
                    textBox.BackColor = Color.Yellow;
                }
            }
        }

        // Xu li dong tab hien tai
        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co chac muon thoat?", "Thoat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Xu li lam lai
        private void button_lamlai_Click(object sender, EventArgs e)
        {
            this.helpLamLai();
        }

        // Helper lam lai 
        private void helpLamLai()
        {
            richTextBox_debai.Text = model.CauHoi;
            this.diem = 0;
            for (int i = 1; i <= 10; i++)
            {
                TextBox textBox = this.Controls.Find($"textBox_{i}", true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    textBox.Text = "";
                    textBox.BackColor = Color.White;
                }
            }
        }
    }
}
