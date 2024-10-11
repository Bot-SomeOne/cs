using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th3_2
{
    public partial class Form_Bai_Tap_Tieng_Anh : Form
    {
        public Form_Bai_Tap_Tieng_Anh()
        {
            InitializeComponent();
        }

        // Chuyen sang form bai tap dien tu 1
        private void baiDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DienTu dienTu = new DienTu(DataTemp.BaiTapDienTu1);
            dienTu.Text = "Bai Tap Dien Tu 1";
            dienTu.Show();
        }

        // Chuyen sang form bai tap dien tu 2
        private void baiDienTu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DienTu dienTu = new DienTu(DataTemp.BaiTapDienTu2);
            dienTu.Text = "Bai Tap Dien Tu 2";
            dienTu.Show();
        }

        // Chuyen sang form bai tap dien tu 3
        private void baiDienTu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DienTu dienTu = new DienTu(DataTemp.BaiTapDienTu3);
            dienTu.Text = "Bai Tap Dien Tu 3";
            dienTu.Show();
        }

        // Chuyen sang form bai tap dien tu 4
        private void baiDienTu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DienTu dienTu = new DienTu(DataTemp.BaiTapDienTu4);
            dienTu.Text = "Bai Tap Dien Tu 4";
            dienTu.Show();
        }

        // Chuyen sang form bai tap dien tu 5
        private void baiDienTu5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DienTu dienTu = new DienTu(DataTemp.BaiTapDienTu5);
            dienTu.Text = "Bai Tap Dien Tu 5";
            dienTu.Show();
        }

        // Xu li thoat
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co chac muon thoat?", "Thoat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
