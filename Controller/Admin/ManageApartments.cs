using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using E_Appartments.Controller.Admin;

namespace E_Appartments.Controller
{
    public partial class ManageApartments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
        public ManageApartments()
        {
            InitializeComponent();
        }
        public void EditApartment()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Apartment set BuildingID=@BuildingID,FullPayment=@FullPayment,Status=@Status,ParkingID=@ParkingID,ClassID=@ClassID where ApartmentID=@ApartmentID", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@BuildingID", cmbBuilding.GetItemText(cmbBuilding.SelectedValue));
            cmd.Parameters.AddWithValue("@ClassID", cmbApartment.GetItemText(cmbApartment.SelectedValue));
            cmd.Parameters.AddWithValue("@ParkingID", cmbParkingSlot.GetItemText(cmbParkingSlot.SelectedValue));
            cmd.Parameters.AddWithValue("@FullPayment", txtFullPrice.Text);
            cmd.Parameters.AddWithValue("@Status", cmbAvailability.GetItemText(cmbAvailability.SelectedItem));
            cmd.Parameters.AddWithValue("@ApartmentID", txtHideApartment.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Apartment details has been updated successfully");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("Database Error Try again!!!");
            }
        }
        public void AddApartment()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Apartment (BuildingID,FullPayment,Status,ParkingID,ClassID) " + "values (@BuildingID,@FullPayment,@Status,@ParkingID,@ClassID)", con);
            SqlCommand cm = new SqlCommand("update Parking set Status='Occupied' where ParkingID=" + cmbParkingSlot.Text + " ;", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@BuildingID", cmbBuilding.GetItemText(cmbBuilding.SelectedValue));
            cmd.Parameters.AddWithValue("@ClassID", cmbApartment.GetItemText(cmbApartment.SelectedValue));
            cmd.Parameters.AddWithValue("@ParkingID", cmbParkingSlot.GetItemText(cmbParkingSlot.SelectedValue));
            cmd.Parameters.AddWithValue("@FullPayment", txtFullPrice.Text);
            cmd.Parameters.AddWithValue("@Status", cmbAvailability.GetItemText(cmbAvailability.SelectedItem));
           
            try
            {
                cmd.ExecuteNonQuery();
                cm.ExecuteNonQuery();
                MessageBox.Show("A new Apartment has been added to the system!", "Insert Apartment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    MessageBox.Show("Apartment has been added successfully");

            }
            catch (Exception e)
            {
               // Console.WriteLine(e.ToString());
                MessageBox.Show("Apartment cannot be added!", "Failed Apartment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ManageApartments.ActiveForm.Hide();
            AdminDashboard xsc = new AdminDashboard();
            xsc.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManageApartments.ActiveForm.Hide();
            LeaseMenu hfr = new LeaseMenu();
            hfr.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select BuildingLocation,BuildingID from Buildings", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Buildings", typeof(string));
                dt.Load(reader);
                cmbBuilding.ValueMember = "BuildingID";
                cmbBuilding.DisplayMember = "BuildingLocation";
                cmbBuilding.DataSource = dt;
                con.Close();

            }
            catch (Exception)
            {

            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select ClassType,ClassID from ClassTables", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Class", typeof(string));
                dt.Load(reader);
                cmbApartment.ValueMember = "ClassID";
                cmbApartment.DisplayMember = "ClassType";
                cmbApartment.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }

        }

        public void get_parking()
        {
            try
            {
                String buildID = cmbBuilding.GetItemText(cmbBuilding.SelectedValue);
                Console.WriteLine(buildID);
                con.Open();
                SqlCommand cmd = new SqlCommand("select ParkingID from Parking where BuildingID=@buildID AND Status='Available'", con);
                cmd.Parameters.AddWithValue("@buildID", buildID);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Class", typeof(string));
                dt.Load(reader);
                cmbParkingSlot.ValueMember = "ParkingID";
                cmbParkingSlot.DisplayMember = "ParkingID";
                cmbParkingSlot.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }

        }
        public void DeleteApartment()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Apartment WHERE ApartmentID=@ApartmentID;", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@ApartmentID", txtHideApartment.Text);

            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("The Apartment has been removed from the system!");

            }
            catch (Exception)
            {
                MessageBox.Show("You cannot delete currently occupied Apartments!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parsedValue;
             if (string.IsNullOrEmpty(cmbBuilding.Text))
             {
                MessageBox.Show("Building Cannot be blank!", "Add a new Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(cmbBuilding, "Please select a building!");
                return;
             }
            else
            {
                errorProvider1.SetError(cmbBuilding, null);
            }

            if (string.IsNullOrEmpty(cmbApartment.Text))
             {
                MessageBox.Show("Apartment Cannot be blank!", "Add a new Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(cmbApartment, "Please select a Apartment!");
                return;
             }
            else
            {
                errorProvider2.SetError(cmbApartment, null);
            }
             if (string.IsNullOrEmpty(cmbParkingSlot.Text))
             {
                MessageBox.Show("Parking Slot cannot be blank!", "Add a new Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider3.SetError(cmbParkingSlot, "Please select a Parking slot!");
                return;
             }
            else
            {
                errorProvider3.SetError(cmbParkingSlot, null);
            }
          if (string.IsNullOrEmpty(txtFullPrice.Text))
            {
                MessageBox.Show("Price Cannot be blank!", "Add a new Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider4.SetError(txtFullPrice, "Please Insert a Price!");
                return;
            }
            else
            {
                errorProvider4.SetError(txtFullPrice, null);
            }
            if (string.IsNullOrEmpty(cmbAvailability.Text))
            {
                MessageBox.Show("Availability Cannot be blank!", "Add a new Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider5.SetError(cmbAvailability, "Please Select the Availability of the Apartment");
                return;
            }
            else
            {
                errorProvider5.SetError(cmbAvailability, null);
            }

            AddApartment();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" SELECT ap.ApartmentID,b.BuildingLocation,pa.ParkingID,ct.ClassType,ap.FullPayment,ap.Status FROM Buildings b inner join Apartment ap ON b.BuildingID = ap.BuildingID inner join ClassTables ct on ct.ClassID = ap.ClassID inner join Parking pa on pa.ParkingID = ap.ParkingID; ", con);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void cmbParkingSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBuilding_SelectedValueChanged(object sender, EventArgs e)
        {
            get_parking(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtHideApartment.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbBuilding.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbApartment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbParkingSlot.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtFullPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbAvailability.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditApartment();
        }

        private void cmbApartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ManageApartments.ActiveForm.Hide();
            ManageTenants zxc = new ManageTenants();
            zxc.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ManageApartments.ActiveForm.Hide();
            ManageApartments zxfa = new ManageApartments();
            zxfa.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ManageApartments.ActiveForm.Hide();
            AdminReports hdg = new AdminReports();
            hdg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteApartment();
        }

        private void txtHideApartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
