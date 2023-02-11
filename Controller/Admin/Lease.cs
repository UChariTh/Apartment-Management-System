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
    public partial class Lease : Form
    {
        public Lease()
        {
            InitializeComponent();
        }

        public void EditStatus()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Apartment set Status=@Status where ApartmentID=@ApartmentID", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Status", cmbStatus.GetItemText(cmbStatus.SelectedItem));
            cmd.Parameters.AddWithValue("@ApartmentID", txtApartmentID.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Apartment Status");
                Lease.ActiveForm.Hide();
                Lease sdagfa = new Lease();
                sdagfa.Show();

            }
            catch (Exception )
            {
                MessageBox.Show("Database Error Try again!!!");
            }
        }

        public void DeleteLeaseReq()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Lease WHERE LeaseID=@LeaseID;", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@LeaseID", txtLeaseID.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lease Deleteed!");

            }
            catch (Exception )
            {
                MessageBox.Show("Database Error Try again!!!");
            }
        }

        private void Lease_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Lease.ActiveForm.Hide();
            ManageTenants dbb = new ManageTenants();
            dbb.Show();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Lease.ActiveForm.Hide();
            ManageTenants dbb = new ManageTenants();
            dbb.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT le.LeaseID,ap.ApartmentID,cus.name, cus.nic, cus.address, ch.emergencyContact, ch.NumberOfDependants, ch.NumberOfServants, ap.Status, le.leaseStartDate, le.leaseExpiryDate FROM CustomerDetails cus inner join ChiefOccupant ch ON cus.cusID = ch.cusID inner join Apartment ap on ch.ApartmentID = ap.ApartmentID inner join Lease le on ch.chiefOccupantID = le.chiefOccupantID; ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGVLease.DataSource = dt;
                con.Close();
            }
            catch (Exception )
            {
               
            }
        }

        private void dataGVLease_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVLease.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtLeaseID.Text = dataGVLease.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtApartmentID.Text = dataGVLease.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_name.Text = dataGVLease.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtnic.Text = dataGVLease.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtadd.Text = dataGVLease.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtnum.Text = dataGVLease.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDep.Text = dataGVLease.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtSev.Text = dataGVLease.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmbStatus.Text = dataGVLease.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditStatus();
        }

        private void Lease_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteLeaseReq();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Lease.ActiveForm.Hide();
            AdminDashboard tet = new AdminDashboard();
            tet.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Lease.ActiveForm.Hide();
            ManageTenants zxc = new ManageTenants();
            zxc.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Lease.ActiveForm.Hide();
            ManageApartments kj = new ManageApartments();
            kj.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Lease.ActiveForm.Hide();
            Lease abc = new Lease();
            abc.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Lease.ActiveForm.Hide();
            AdminReports repl = new AdminReports();
            repl.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Lease.ActiveForm.Hide();
            LeaseMenu juju = new LeaseMenu();
            juju.Show();
        }
    }
}
