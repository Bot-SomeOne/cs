using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using TH2_Ex2.Models;

namespace TH2_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.init();
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
         * Handle click radio button
         */
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                txtGiaDuThuyen.Text = radioButton.Tag.ToString();
                this.tinhTien();
            }
        }

        /**
         * Handle change selected combobox
         */
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.tinhTien();
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

        // Helper Tinh Tien
        private void tinhTien()
        {
            int soLuong = (int)comboBoxSoLuong.SelectedItem;
            DoUong doUong = (DoUong)comboBoxChonDoUong.SelectedItem;
            int giaDuThuyen = int.Parse(txtGiaDuThuyen.Text);
            double tien = giaDuThuyen + doUong.Gia * soLuong;
            txtTien.Text = tien.ToString();
        }

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

            comboBoxChonDoUong.SelectedIndex = 0;
            comboBoxSoLuong.SelectedIndex = 0;

            radioCaNgay.Checked = true;

            this.tinhTien();
        }

        // Help Init
        private void init()
        {
            List<int> listSoLuong = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            comboBoxSoLuong.DataSource = listSoLuong;

            List<DoUong> listDoUong = new List<DoUong>
            {
                new DoUong { TenDoUong = "CoCa cola", Gia = 0.5 },
                new DoUong { TenDoUong = "Pepsi", Gia = 0.8 },
                new DoUong { TenDoUong = "Seven up", Gia = 1.0 },
            };
            comboBoxChonDoUong.DataSource = listDoUong;
            comboBoxChonDoUong.DisplayMember = "TenDoUong";

            this.KeyPreview = true;

            radioCaNgay.Checked = true;
        }
    }
}
