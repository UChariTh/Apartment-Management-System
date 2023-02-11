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

namespace E_Appartments.Controller.Customer
{
    public partial class CustomerLease : Form
    {
        
        public CustomerLease()
        {
            InitializeComponent();
        }

        private void CustomerLease_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT cus.nic,ch.chiefOccupantID FROM CustomerDetails cus inner join ChiefOccupant ch ON cus.cusID = ch.cusID  ", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("chiefOccupantID", typeof(string));
            dt.Load(reader);
            cmbChNo.ValueMember = "chiefOccupantID";
            cmbChNo.DisplayMember = "nic";
            cmbChNo.DataSource = dt;

            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ap.ApartmentID,le.LeaseID ,b.BuildingLocation,le.leaseStartDate,le.leaseExpiryDate,ap.Status FROM Buildings b inner join Apartment ap ON b.BuildingID = ap.BuildingID inner join ChiefOccupant ch on ch.ApartmentID = ap.ApartmentID inner join Lease le on ap.ApartmentID=le.ApartmentID;  ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch
            {

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtApID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLeaseID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBuildingLoc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                date_LeaseStartDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                date_LeaseEndDate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            CustomerLease.ActiveForm.Hide();
            Apartments db = new Apartments();
            db.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            CustomerLease.ActiveForm.Hide();
            CustomerLease sdaf = new CustomerLease();
            sdaf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into LeaseExtend (ExtendDate,LeaseID) " + "values (@Date,@LeaseID)", con);
            SqlCommand cm = new SqlCommand("update Apartment set Status='Day Extend' where ApartmentID=" + txtApID.Text + " ;", con);


            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Date", date_ExtendDate.Value);
            cmd.Parameters.AddWithValue("@LeaseID", txtLeaseID.Text);

            try
            {
                cmd.ExecuteNonQuery();
                cm.ExecuteNonQuery();
                MessageBox.Show("Sent Time Extend Request");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Database Error Try again!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            CustomerLease.ActiveForm.Hide();
            Apartments zxc = new Apartments();
            zxc.Show();
        }
    }
}
