using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERCURY_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            Connector myConnector = new Connector(); // Use your Connector class
            MySqlConnection connection = myConnector.GetConnection();

            try
            {
                connection.Open();
                // IMPORTANT: Use parameters to prevent SQL injection
                string sql = "SELECT COUNT(*) FROM admin WHERE Username = @Username AND Password = @Password";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", enteredUsername);
                    cmd.Parameters.AddWithValue("@Password", enteredPassword);
                    long count = (long)cmd.ExecuteScalar(); // Use long for MySQL COUNT(*)
                    if (count > 0)
                    {
                        frmMainMenu frmMainMenuForm = new frmMainMenu();
                        this.Hide();
                        frmMainMenuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
