using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Traffic
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string email = emailField.Text;
            string password = passwordField.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                if (CreateAccount(username, email, password))
                {
                    MessageBox.Show("Акаунта беше създаден успешно!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Неуспешно създаване на акаунт. Моля опитайте отново!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Моля, попълнете всички полета!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool CreateAccount(string username, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aleks\\source\\repos\\Traffic\\Traffic\\Users.mdf;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [Users] (UserName, Email, Password) VALUES (@username, @email, @password)";

                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < hashBytes.Length; i++)
                        {
                            builder.Append(hashBytes[i].ToString("x2"));
                        }

                        string hashedPassword = builder.ToString();

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Възникна грешка: " + ex.Message);
                    return false;
                }
            }
        }

        private void ClearFields()
        {
            usernameField.Clear();
            emailField.Clear();
            passwordField.Clear();
        }

        private void GotoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}