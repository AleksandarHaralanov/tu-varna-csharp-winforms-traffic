using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Traffic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = usernameField.Text;
            string password = passwordField.Text;

            if (ValidateCredentials(usernameOrEmail, password))
            {
                Hide();
                new Stops().Show();
            }
            else
            {
                MessageBox.Show("Невалидно име или парола. Моля, опитайте отново!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool ValidateCredentials(string usernameOrEmail, string password)
        {
            SqlConnectionStringBuilder builder = new()
            {
                DataSource = "(LocalDB)\\MSSQLLocalDB",
                AttachDBFilename = @"C:\Users\aleks\source\repos\Traffic\Traffic\Users.mdf",
                IntegratedSecurity = true
            };

            using SqlConnection connection = new(builder.ConnectionString);
            connection.Open();

            string query = "SELECT Password FROM [Users] WHERE (UserName = @username OR Email = @username)";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@username", usernameOrEmail);

            string hashedPassword = "";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    hashedPassword = reader.GetString(0);
                }
            }

            bool isValid = VerifyPassword(password, hashedPassword);
            return isValid;
        }

        private static bool VerifyPassword(string password, string hashedPassword)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder builder = new();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }

            string hashedInput = builder.ToString();

            return hashedInput.Equals(hashedPassword);
        }

        private void RegisterAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Register().Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}