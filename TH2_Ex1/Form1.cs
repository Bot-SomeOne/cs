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
using TH2_Ex1.Models;

namespace TH2_Ex1
{
    public partial class Form1 : Form
    {
        // Var
        private List<MonHoc> lstMonHoc;
        private List<MonHoc> lstData;
        //
        public Form1()
        {
            InitializeComponent();
            this.init();
            this.KeyPreview = true;
        }

        private void listenKeyPress(object sender, KeyEventArgs e)
        {
            // Xu li thoat chuong trinh khi nhan phim Alt + H
            if (e.Alt && e.KeyCode == Keys.H)
            {
                this.closeApp();
            }
            // Xu li them mon hoc khi nhan phim Alt + D
            if (e.Alt && e.KeyCode == Keys.D)
            {
                this.helpAddData();
            }
            // Xu li tinh khi nhan phim Alt + T
            if (e.Alt && e.KeyCode == Keys.T)
            {
                this.helpTinh();
            }
        }

        /**
         * Xu li bam btn thoat
         */
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.closeApp();
        }

        /**
         * Chon diem phu hop voi mon hoc
         */
        private void handleChonMonHoc(object sender, EventArgs e)
        {
            MonHoc selectedMonHoc = (MonHoc)cbbTenMonHoc.SelectedItem;
            if (selectedMonHoc == null) {
                return;
            }
            txtSoTinChi.Text = selectedMonHoc.SoTinChi.ToString();
        }

        /**
         * Xu li nhap diem
         */
        private void diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số, không phải phím điều khiển (như backspace) và không phải là dấu .
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                (e.KeyChar != '.' || ((TextBox)sender).Text.Contains("."))) // Cho phép duy nhất 1 dấu .
            {
                e.Handled = true; // Ngăn không cho ký tự không hợp lệ được nhập vào
            }
        }

        /**
         * Handle click add to list MonHoc
         */
        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            this.helpAddData();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            helpTinh();
        }

        /**
         * List Helpper
         */

        /**
         * Help Tinh
         */
        private void helpTinh()
        {
            if (this.lstData.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tongSoTinChi = 0;
            double tongDiem = 0;
            double diemTB = 0;

            foreach (MonHoc monHoc in this.lstData)
            {
                tongSoTinChi += monHoc.SoTinChi;
                tongDiem += monHoc.Diem;
            }

            diemTB = tongDiem / this.lstData.Count;

            txtTongSoTinChi.Text = tongSoTinChi.ToString();
            txtTongSoDiem.Text = tongDiem.ToString();
            txtDiemTrungBinh.Text = diemTB.ToString();
        }

        /**
         * Help add data
         */
        private void helpAddData()
        {
            MonHoc selectedMonHoc = (MonHoc)cbbTenMonHoc.SelectedItem;
            if (selectedMonHoc == null || txtDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm cho môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double diem = double.Parse(txtDiem.Text);
            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            selectedMonHoc.Diem = diem;
            this.lstData.Add(new MonHoc
            {
                TenMonHoc = selectedMonHoc.TenMonHoc,
                SoTinChi = selectedMonHoc.SoTinChi,
                Diem = selectedMonHoc.Diem
            });
            this.HandleShowData();
        }

        /**
         * Handle show data
         */
        private void HandleShowData()
        {
            string data = "";
            foreach (MonHoc monHoc in this.lstData)
            {
                data += monHoc.TenMonHoc + " " + monHoc.SoTinChi + " - " + monHoc.Diem + Environment.NewLine;
            }
            txtDSMH.Text = data;
        }

        // Init
        private void init()
        {   
            txtDSMH.ScrollBars = ScrollBars.Both; // Hoặc ScrollBars.Vertical hoặc ScrollBars.Horizontal

            this.lstData = new List<MonHoc>();
            this.lstMonHoc = new List<MonHoc>
            {
                new MonHoc{
                    TenMonHoc = "Tin hoc dai cuong",
                    SoTinChi = 2
                },
                new MonHoc{
                    TenMonHoc = "Giai tich F1",
                    SoTinChi = 3
                },
                new MonHoc{
                    TenMonHoc = "Tieng Anh A0",
                    SoTinChi = 3
                },
                new MonHoc{
                    TenMonHoc = "Triet hoc Mac - Lenin",
                    SoTinChi = 2
                },
                new MonHoc{
                    TenMonHoc = "Vat ly F1",
                    SoTinChi = 3
                }

            };
            cbbTenMonHoc.DataSource = this.lstMonHoc;
            cbbTenMonHoc.DisplayMember = "TenMonHoc"; // Property to display in the ComboBox
            cbbTenMonHoc.ValueMember = "SoTinChi";    // Underlying value (optional)
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

    }
}
