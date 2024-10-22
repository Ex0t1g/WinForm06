namespace WinForm06
{
    public partial class MenuStart : Form
    {
        public MenuStart()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            FichMenu form = new FichMenu(Location);
            form.Show();
            Hide();
        }
    }
}
