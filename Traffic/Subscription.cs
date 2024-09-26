namespace Traffic
{
    public partial class Subscription : Form
    {
        public Subscription()
        {
            InitializeComponent();
        }

        private void PurchaseSubscriptionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно закупен абонамент!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            new Stops().Show();
        }

        private void GotoStops_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Stops().Show();
        }

        private void Subscription_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
