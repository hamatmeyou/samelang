using MySql.Data.MySqlClient;
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
    public partial class frmSellMedicine : Form
    {
        private frmMainMenu frmMainMenuRef;
        private frmMainMenu _frmMainMenuRef;
        public frmSellMedicine(frmMainMenu mainForm)
        {
            InitializeComponent();
            frmMainMenuRef = mainForm;
            this._frmMainMenuRef = mainForm;         }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnterIDCode.Clear();
            txtBrandName.Clear();
            txtGenericName.Clear();
            txtUsedfor.Clear();
            txtEnterQuantity.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            txtEnterCash.Clear();
            txtChange.Clear(); 
        }

        private void frmSellMedicine_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenuRef.Show();
        }

  
            private void btnSave_Click(object sender, EventArgs e)
        {
            string idCode = txtEnterIDCode.Text;
            string brandName = txtBrandName.Text;
            string genericName = txtGenericName.Text;
            string useDesc = txtUsedfor.Text;
            string quantityText = txtEnterQuantity.Text;
            string dateArrived = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string dateExpiry = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            // Validate required fields
            if (string.IsNullOrWhiteSpace(brandName) ||
                string.IsNullOrWhiteSpace(genericName) ||
                string.IsNullOrWhiteSpace(useDesc) ||
                string.IsNullOrWhiteSpace(quantityText))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure numeric input is valid
            if (!int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Please enter a valid number for quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection connection = null;

            try
            {
                Connector connector = new Connector();
                connection = connector.GetConnection();
                connection.Open();

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
                txtEnterIDCode.Clear();
                txtBrandName.Clear();
                txtGenericName.Clear();
                txtUsedfor.Clear();
                txtEnterQuantity.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker1.Value = DateTime.Now;

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

        private void txtEnterIDCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterCash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
