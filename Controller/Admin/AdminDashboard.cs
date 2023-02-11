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

namespace E_Appartments.Controller.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        public void Available_Lease()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM CustomerDetails cus inner join ChiefOccupant ch ON cus.cusID = ch.cusID inner join Apartment ap on ch.ApartmentID = ap.ApartmentID inner join Lease le on ch.chiefOccupantID = le.chiefOccupantID;  ", con);

            var Leasecount = cmd.ExecuteScalar();
            lblLease1.Text = Leasecount.ToString();


        }
        public void Available_LeaseExtend()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM CustomerDetails cus inner join ChiefOccupant ch ON cus.cusID = ch.cusID inner join Apartment ap on ch.ApartmentID = ap.ApartmentID inner join Lease le on ch.chiefOccupantID = le.chiefOccupantID inner join LeaseExtend leaseEX on le.LeaseID=leaseEX.LeaseID where ap.Status='Day Extend'; ", con);

            var DayExtendcount = cmd.ExecuteScalar();
            lblDayExtend1.Text = DayExtendcount.ToString();


        }
        public void Total_Customers()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM CustomerDetails ", con);

            var Customers = cmd.ExecuteScalar();
            lblCustomers1.Text = Customers.ToString();
        }
        public void Available_Apartmemnts()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Apartment where Status='Available'", con);

            var Apartments = cmd.ExecuteScalar();
            txtApartments.Text = Apartments.ToString();
        }
        public void Occupied_Apartmemnts()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Apartment where Status='Occupied'", con);

            var occu_Apartments = cmd.ExecuteScalar();
            txtOccupied.Text = occu_Apartments.ToString();
        }
        public void Total_Apartmemnts()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Apartment", con);

            var Total_Apartments = cmd.ExecuteScalar();
            txtTotalApartments.Text = Total_Apartments.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Hide();
            AdminDashboard dash = new AdminDashboard();
            dash.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Hide();
            ManageTenants tet = new ManageTenants();
            tet.Show();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Hide();
            ManageApartments apar = new ManageApartments();
            apar.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Hide();
            LeaseMenu les = new LeaseMenu();
            les.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AdminDashboard.ActiveForm.Hide();
            AdminReports repo = new AdminReports();
            repo.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblLease_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Available_Lease();
            Available_LeaseExtend();
            Total_Customers();
            Available_Apartmemnts();
            Occupied_Apartmemnts();
            Total_Apartmemnts();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
