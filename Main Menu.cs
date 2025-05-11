using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERCURY_SYSTEM
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnYOUMAYADD_Click(object sender, EventArgs e)
        {

        }

        private void btnYOUMAYADDw_Click(object sender, EventArgs e)
        {

        }

        private void btnYOUMAYADD3_Click(object sender, EventArgs e)
        {

        }
        private void btnADDMEDICINE_Click(object sender, EventArgs e)
        {
            frmAddMedicine addForm = new frmAddMedicine(this); // Pass reference to this form
            addForm.Show();
            this.Hide(); // Hide the main menu
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnVIEWMEDICINE_Click(object sender, EventArgs e)
        {
            frmSellMedicine addForm = new frmSellMedicine(this); // Pass reference to this form
            addForm.Show();
            this.Hide(); // Hide the main menu
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSELLMEDICINE_Click(object sender, EventArgs e)
        {
            frmSellMedicine addForm = new frmSellMedicine(this); // Pass reference to this form
            addForm.Show();
            this.Hide(); // Hide the main menu
        }

    }


}
