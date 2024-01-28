namespace Test_for_Gabrovec
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void igrai_btn_Click(object sender, EventArgs e)
        {

            toplata_staq game1 = new toplata_staq();
            this.Hide();
            game1.ShowDialog();
            this.Close();
        }

        private void pomosht_btn_Click(object sender, EventArgs e)
        {
            osnovanie game3 = new osnovanie();
            this.Hide();
            game3.ShowDialog();
            this.Close();
        }
    }
}