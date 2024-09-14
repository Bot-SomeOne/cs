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
        }

        /**
         * Xu li bam btn thoat
         */
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.closeApp();
        }

        /**
         * List Helpper
         */

        // Init
        private void init()
        {
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
