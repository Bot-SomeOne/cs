
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Ex_3_Day250824
{
    public partial class Form1 : Form
    {
        // Var
        private bool check;

        public Form1()
        {
            InitializeComponent();
            this.check = true;
            this.clear();

            // Lang nghe su kien ban phim
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.G)
            {
                this.giaiPt();
            } 
            else if (e.Alt && e.KeyCode == Keys.L)
            {
                this.clear();
            } else if (e.Alt && e.KeyCode == Keys.T)
            {
                this.exitApp();
            }

        }

        private void btn_giaiPT_Click(object sender, EventArgs e)
        {
            this.giaiPt();
        }

        private void button_LamLai_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.exitApp();
        }

        // Help exit
        private void exitApp()
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Help funtion giai pt
        private void giaiPt()
        {
            double a, b, c;

            a = this.getValue(ip_a);
            b = this.getValue(ip_b);
            c = this.getValue(ip_c);

            if (!this.check)
            {
                this.check = true;
                return;
            }
            double dt = b * b - 4 * a * c;

            if (dt < 0)
            {
                ip_res.Text = "PT Vo Nghiem";
            }
            else if (dt == 0)
            {
                ip_res.Text = $"PT co nghiep kep: \n x = {-b / (2 * a)}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                ip_res.Text = $"PT co nghiep 2 nghiem phan biet: \n \tx1 = {x1} \n \tx2 = {x2}";
            }
        }

        // Help function get value
        private double getValue(TextBox t)
        {
            try {
                double res = Double.Parse(t.Text);
                return res;
            } catch (FormatException fe) {
                t.Text = "";
                t.PlaceholderText = "Vui long nhap dung dinh dang";
                check = false;
            }
            return 0;
        }

        // Help function clear value
        private void clear()
        {
            ip_a.Text = "";
            ip_b.Text = "";
            ip_c.Text = "";
            ip_res.Text = "";

            ip_a.Focus();
        }
    }
}
