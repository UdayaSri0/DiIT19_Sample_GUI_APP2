using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SampleGUIAPP2
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = new SqlConnection("Data Source=DarkStar;Initial Catalog=ProDiIT19GUI;Integrated Security=True;Encrypt=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter user name and password.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                sqlConnection.Open();

                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    reader.Close();

                    if (role == "Admin")
                    {
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.Show();
                    }
                    else if (role == "User")
                    {
                        frmUsers frmUsers = new frmUsers();
                        frmUsers.Show();
                    }
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
