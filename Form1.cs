namespace Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt1_Click(object sender, EventArgs e)
        {
            try
            {
                if (text1.Text == "" || text1.Text == String.Empty || text2.Text == "" || text2.Text == String.Empty)
                {
                    outcome.Text = "U Idiots Enter Your Number!!!";
                }
                else
                {
                    int num = 0;
                    num = Convert.ToInt32(text1.Text) + Convert.ToInt32(text2.Text);
                    outcome.Text = num.ToString();
                }
            }catch (Exception ex)
            {
                outcome.Text = "Enter Only Numbers dude";
            }
        }
    }
}
