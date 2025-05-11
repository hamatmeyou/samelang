using MySql.Data.MySqlClient;
using Mysqlx.Notice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MERCURY_SYSTEM
{
    public partial class frmAddMedicine : Form
    {
        private frmMainMenu frmMainMenuRef; // Declare a field to hold a reference to the main menu form
        private Connector connector = new Connector(); // Instantiate the Connector class

        public frmAddMedicine(frmMainMenu frmMainMenu) // Accept a reference to the main menu form in the constructor
        {
            InitializeComponent();
            frmMainMenuRef = frmMainMenu; // Assign the passed reference to the field
 

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ThisIsFo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenuRef.Show(); // Show the main menu form when back is clicked
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idCode = txtEnteridcode.Text;
            string brandName = txtBrandName.Text;
            string genericName = txtGenericName.Text;
            string useDesc = txtUserfor.Text;
            string quantity = txtQuantity.Text;
            string dateArrived = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dateExpiry = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            // Basic validation for required fields
            if (string.IsNullOrWhiteSpace(brandName) ||
                string.IsNullOrWhiteSpace(genericName) ||
                string.IsNullOrWhiteSpace(useDesc) ||
                string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection connection = null; // Initialize connection outside the try block

            try
            {
                Connector connector = new Connector();
                connection = connector.GetConnection();
                connection.Open(); // **Crucially, open the connection here!**

                string query = "INSERT INTO medicine " +
                               "(Brand_Name, Generic_Name, Description, Quantity, Date_Arrived, Date_Expiry) " +
                               "VALUES (@Brand_Name, @Generic_Name, @Description, @Quantity, @Date_Arrived, @Date_Expiry)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Brand_Name", brandName);
                    command.Parameters.AddWithValue("@Generic_Name", genericName);
                    command.Parameters.AddWithValue("@Description", useDesc);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Date_Arrived", dateArrived);
                    command.Parameters.AddWithValue("@Date_Expiry", dateExpiry);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields
                txtEnteridcode.Clear();
                txtBrandName.Clear();
                txtGenericName.Clear();
                txtUserfor.Clear();
                txtQuantity.Clear();

                this.Hide();
                frmMainMenuRef.Show(); // Show main menu after saving
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed even if an error occurs
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnteridcode.Clear();
            txtBrandName.Clear();
            txtGenericName.Clear();
            txtUserfor.Clear();
            txtQuantity.Clear();
        }

        private void txtUserfor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEnteridcode_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}