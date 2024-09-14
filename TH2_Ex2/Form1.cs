using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        /**
         * Listen keypress
         */
        private void listenKeyPress(object sender, KeyEventArgs e)
        {
            // Xu li thoat chuong trinh khi nhan phim Alt + H
            if (e.Alt && e.KeyCode == Keys.H)
            {
                this.closeApp();
            }
            // Xu li them moi khi nhan phim Alt + M
            if (e.Alt && e.KeyCode == Keys.M)
            {
                this.clearUp();
            }
        }

        /**
         *  Handle btnThemMoi_Click
         */
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.clearUp();
        }

        // Handle btn close app
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.closeApp();
        }

        /*
         * List Helpper
         */

        // Helpper Close app
        private void closeApp()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Help Clear Up
        private void clearUp()
        {
            txtHoTen.Text = "";
            txtHoTen.Focus();

            txtGiaDuThuyen.Text = "";
            txtTien.Text = "";
        }

    }
}
