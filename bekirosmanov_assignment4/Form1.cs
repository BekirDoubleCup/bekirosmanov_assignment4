namespace bekirosmanov_assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            int i, factorial = 1, number;
            number = Convert.ToInt32(number_box.Text);
            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            result_box.Text = ""+ factorial;
        }
    }
}