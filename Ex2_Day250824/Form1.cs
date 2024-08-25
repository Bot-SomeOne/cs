using Ex2_Day250824.Help;

namespace Ex2_Day250824
{
    public partial class Form1 : Form
    {
        // Var
        private bool check;
        public Form1()
        {
            InitializeComponent();
            check = true;
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            double x1 = ConvertString(Input_x1);
            double x2 = ConvertString(Input_x2);
            double y1 = ConvertString(Input_y1);
            double y2 = ConvertString(Input_y2);

            if (!this.check)
            {
                this.check = true;
                return;
            }

            //String temp = $"x1: {x1}, y1: {y1}\nx2: {x2}, y2: {y2}";
            //MessageBox.Show(temp);

            r_hesogoc.Text = help.Angle(x1, y1, x2, y2).ToString();
            r_khoangcach.Text = help.Distance(x1, y1, x2, y2).ToString();

        }

        // Help convert
        private double ConvertString(TextBox tb)
        {
            try
            {
                double res = Double.Parse(tb.Text);
                return res;
            }
            catch (FormatException fe)
            {
                tb.Text = "";
                tb.PlaceholderText = "Vui long nhap dung dinh dang";
                tb.Focus();
                this.check = false;
            }
            return 0;
        }
    }
}
