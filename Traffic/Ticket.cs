namespace Traffic
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void GotoStops_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Stops().Show();
        }

        private void PurchaseTicketButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно закупен билет!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            new Stops().Show();
        }

        private void Ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
