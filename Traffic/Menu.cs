namespace Traffic
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void PurchaseTicketButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ticket().Show();
        }

        private void PurchaseSubscriptionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Subscription().Show();
        }

        private void GotоStops_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Stops().Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
