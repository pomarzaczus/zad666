namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public int kroxy;
        public int czas;
        public int dyd;
        public int szopy;
        public int x;
        public int y;
        public Form1()
        {
            InitializeComponent();
        }

        private void koniec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ustawienia_Click(object sender, EventArgs e)
        {
            Form2 test = new Form2(this);
            test.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form3 test = new Form3(this);
            test.Show();
        }

        private void test_Click(object sender, EventArgs e)
        {
            test.Text = kroxy.ToString() + dyd.ToString();
        }
    }
}
