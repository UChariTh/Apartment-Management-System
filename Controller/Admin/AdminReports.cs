using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Appartments.Controller;
using E_Appartments.Reports;

namespace E_Appartments.Controller.Admin
{
    public partial class AdminReports : Form
    {
        public AdminReports()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            AdminDashboard dash = new AdminDashboard();
            dash.Show();
        }

        private void lbTenants_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            ManageTenants tdas = new ManageTenants();
            tdas.Show();
        }

        private void lbApartments_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            ManageApartments mapart = new ManageApartments();
            mapart.Show();
        }

        private void lbLease_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            LeaseMenu llp = new LeaseMenu();
            llp.Show();
        }

        private void lbReports_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            AdminReports repl = new AdminReports();
            repl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            OccupantDetailsForm zcz = new OccupantDetailsForm();
            zcz.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            ApartmentDetailsForm nhf = new ApartmentDetailsForm();
            nhf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            CustomerDetailsForm kjkjk = new CustomerDetailsForm();
            kjkjk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminReports.ActiveForm.Hide();
            LeaseDetailsForm vbvb = new LeaseDetailsForm();
            vbvb.Show();
        }
    }
}
