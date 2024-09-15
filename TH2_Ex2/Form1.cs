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
        // Var
        private List<Tour> TourList;

        //
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
         * Handle btn click them tour
         */
        private void btnThemTour_Click(object sender, EventArgs e)
        {
            this.themTour();
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

        // Handle Show data
        private void showData()
        {
            string data = "";
            foreach (Tour tour in this.TourList)
            {
                data += tour.TenKhachHang + " | ";
                data += tour.ThoiGian + " | ";
                data += tour.GiaThuyen + " | ";
                data += "Do uong " + tour.GiaDoUong + "$ | ";
                data += "Tong " + tour.TongTien + "$";
                data += Environment.NewLine;
            }

            txtData.Text = data;
        }

        // Help Them tua
        private void themTour()
        {
            Tour tour = new Tour();
            tour.TenKhachHang = txtHoTen.Text;
            tour.ThoiGian = radioCaNgay.Text;
            tour.GiaThuyen = double.Parse(txtGiaDuThuyen.Text);
            tour.GiaDoUong = ((DoUong)comboBoxChonDoUong.SelectedItem).Gia;
            tour.TongTien = double.Parse(txtTien.Text);

            if (tour.TenKhachHang == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            this.TourList.Add(tour);
            this.showData();
        }

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
            this.TourList = new List<Tour>();

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


            txtData.ScrollBars = ScrollBars.Both; // Hoặc ScrollBars.Vertical hoặc ScrollBars.Horizontal

            this.KeyPreview = true;

            radioCaNgay.Checked = true;
        }
    }
}
