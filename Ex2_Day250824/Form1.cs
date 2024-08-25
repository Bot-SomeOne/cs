namespace Ex2_Day250824
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Input_x1.Text = "0";
            Input_x2.Text = "0";
            Input_y1.Text = "0";
            Input_y2.Text = "0";

        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(Input_x1.Text);
            double x2 = Convert.ToDouble(Input_x2.Text);
            double y1 = Convert.ToDouble(Input_y1.Text);
            double y2 = Convert.ToDouble(Input_y2.Text);

            String temp = $"x1: {x1}, y1: {y1}\nx2: {x2}, y2: {y2}";

            MessageBox.Show(temp);
        }
    }
}
