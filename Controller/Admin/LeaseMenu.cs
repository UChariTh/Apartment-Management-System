using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Appartments.Controller.Admin
{
    public partial class LeaseMenu : Form
    {
        public LeaseMenu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LeaseMenu.ActiveForm.Hide();
            LeaseMenu vcxcz = new LeaseMenu();
            vcxcz.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LeaseMenu.ActiveForm.Hide();
            AdminDashboard dadad = new AdminDashboard();
            dadad.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LeaseMenu.ActiveForm.Hide();
            ManageTenants xzczczc = new ManageTenants();
            xzczczc.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LeaseMenu.ActiveForm.Hide();
            ManageApartments jujuj = new ManageApartments();
            jujuj.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LeaseMenu.ActiveForm.Hide();
            AdminReports xczcz = new AdminReports();
            xczcz.Show();
        }

        private void btnLeaseRequests_Click(object sender, EventArgs e)
        {
            LeaseMenu.ActiveForm.Hide();
            Lease bfbfbf = new Lease();
            bfbfbf.Show();
        }

        private void btnLeaseExtend_Click(object sender, EventArgs e)
        {
            LeaseMenu.ActiveForm.Hide();
            LeaseExtendAccept hfghdg = new LeaseExtendAccept();
            hfghdg.Show();
        }
    }
}
