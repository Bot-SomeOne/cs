using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // init
            helper_get_odia();
        }

        // Xu li chon nhac khi chon tep torng thu muc
        private void get_nhac(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(
                listBox_teptin.SelectedItem.ToString().Split('.')[0] + ".txt",
                FileMode.Open
            );
            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
            String giaitri = streamReader.ReadToEnd(); // doc toan bo file
            
            richTextBox_loi.Text = giaitri;
            window_media.URL = listBox_teptin.SelectedItem.ToString();

            streamReader.Close();
            fileStream.Close();
        }

        // Xu li hien thu danh sach tep tin cua thu muc
        private void get_tep_tin(object sender, EventArgs e)
        {
            listBox_teptin.Items.Clear();
            string[] files = Directory.GetFiles(
                comboBox_odia.Text + comboBox_thumuc.Text
            );
            foreach (string f in files)
            {
                listBox_teptin.Items.Add(f);
            }
        }

        // Xu li hien thu danh sach thu muc cua o dia
        private void get_Thu_Muc(object sender, EventArgs e)
        {
            comboBox_thumuc.Items.Clear();
            DirectoryInfo Directory = new DirectoryInfo(comboBox_odia.Text);
            DirectoryInfo[] directoryInfos = Directory.GetDirectories("*.*");
            FileInfo[] fileInfos = Directory.GetFiles();
            foreach (DirectoryInfo d in directoryInfos)
            {
                comboBox_thumuc.Items.Add(d.Name);
            }
            comboBox_thumuc.SelectedIndex = 0;
        }

        // Helper get o dia
        private void helper_get_odia()
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (DriveInfo d in driveInfos)
            {
                comboBox_odia.Items.Add(d.Name);
            }
            comboBox_odia.SelectedIndex = 0;
        }

    }
}
