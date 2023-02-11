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
    public partial class LeaseExtendAccept : Form
    {
        public LeaseExtendAccept()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT leaseEX.LeaseExtendID,le.LeaseID,ap.ApartmentID,cus.name,cus.nic, cus.address, ch.emergencyContact, ch.NumberOfServants, ap.Status, le.leaseStartDate, le.leaseExpiryDate,leaseEX.ExtendDate FROM CustomerDetails cus inner join ChiefOccupant ch ON cus.cusID = ch.cusID inner join Apartment ap on ch.ApartmentID = ap.ApartmentID inner join Lease le on ch.chiefOccupantID = le.chiefOccupantID inner join LeaseExtend leaseEX on le.LeaseID=leaseEX.LeaseID where ap.Status='Day Extend';", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGVLease.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void dataGVLease_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVLease.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                try
                {
                    txtLeaseExtendID.Text = dataGVLease.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtLeaseID.Text = dataGVLease.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtApartmentID.Text = dataGVLease.Rows[e.RowIndex].Cells[2].Value.ToString();

                    txt_name.Text = dataGVLease.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtnic.Text = dataGVLease.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtadd.Text = dataGVLease.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtnum.Text = dataGVLease.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtStart.Text = dataGVLease.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtEXP.Text = dataGVLease.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtExtendDate.Text = dataGVLease.Rows[e.RowIndex].Cells[11].Value.ToString();
                    cmbStatustxtExtendDay.Text = dataGVLease.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Try again!!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Apartment set Status=@Status where ApartmentID=@ApartmentID", con);
            SqlCommand cm = new SqlCommand("update Lease set leaseExpiryDate=@leaseExpiryDate where LeaseID=@LeaseID", con);


            cmd.Prepare();
            cm.Prepare();
            cmd.Parameters.AddWithValue("@Status", cmbStatustxtExtendDay.GetItemText(cmbStatustxtExtendDay.SelectedItem));
            cmd.Parameters.AddWithValue("@ApartmentID",txtApartmentID.Text);
            cm.Parameters.AddWithValue("@LeaseID",txtLeaseID.Text);
            cm.Parameters.AddWithValue("@leaseExpiryDate",txtExtendDate.Text);

            try
            {
                cmd.ExecuteNonQuery();
                cm.ExecuteNonQuery();
                MessageBox.Show("Accept Extend Request");
                LeaseExtendAccept.ActiveForm.Hide();
                LeaseExtendAccept sdagfa = new LeaseExtendAccept();
                sdagfa.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Database Error Try again!!!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LeaseExtendAccept.ActiveForm.Hide();
            LeaseMenu jhjhj = new LeaseMenu();
            jhjhj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Apartment set Status='Cancel Request' where ApartmentID=@ApartmentID", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@ApartmentID", txtApartmentID.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lease Date Extend Request is cancel");

            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void LeaseExtendAccept_Load(object sender, EventArgs e)
        {

        }

        private void dataGVLease_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
