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
    public partial class ChiefOccupantSignup : Form
    {
        Apartments AP;
        public ChiefOccupantSignup(Apartments Apart)
        {
            InitializeComponent();
            this.AP = Apart;
        }
        public void AddChiefOccupantDetails()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ChiefOccupant (emergencyContact,NumberOfServants,NumberOfDependants,cusID,ApartmentID) " + "values (@emergencyContact,@NumberOfServants,@NumberOfDependants,@cusID,@ApartmentID)", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@ApartmentID", txtAPNum.Text);
            cmd.Parameters.AddWithValue("@cusID", cmbCustomer.GetItemText(cmbCustomer.SelectedValue));
            cmd.Parameters.AddWithValue("@emergencyContact", txtEmergencyContact.Text);
            cmd.Parameters.AddWithValue("@NumberOfServants", txtNoOfServants.Text);
            cmd.Parameters.AddWithValue("@NumberOfDependants", txtNoOfDependants.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chief Occupant Details has been added successfully");
                ChiefOccupantSignup.ActiveForm.Hide();
                AddLeaseRequest db = new AddLeaseRequest(this);
                db.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("Database Error Try again!!!");
            }

        }
        private void ChiefOccupantSignup_Load(object sender, EventArgs e)
        {
            txtAPNum.Text = AP.txtApartmentID.Text;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select cusID,nic from CustomerDetails", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("cusID", typeof(string));
                dt.Load(reader);
                cmbCustomer.ValueMember = "cusID";
                cmbCustomer.DisplayMember = "nic";
                cmbCustomer.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (string.IsNullOrEmpty(cmbCustomer.Text))
            {
                MessageBox.Show("Customer NIC/Passport Cannot be blank", "Reserve Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(cmbCustomer, "Please insert your NIC/Passport");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbCustomer, null);
            }

           if (string.IsNullOrEmpty(txtEmergencyContact.Text))
            {
                MessageBox.Show("Emergency Contact Cannot be blank", "Reserve Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(cmbCustomer, "Please insert your NIC/Passport");
                return;
            }
            else
            {
                errorProvider2.SetError(txtEmergencyContact, null);
            }
           if (string.IsNullOrEmpty(txtNoOfServants.Text))
            {
                MessageBox.Show("Number of Servants cannot be blank", "Reserve Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider3.SetError(cmbCustomer, "Please insert the number of Servants!");
                return;
            }
            else
            {
                errorProvider3.SetError(txtNoOfServants, null);
            }
            if (string.IsNullOrEmpty(txtNoOfDependants.Text))
            {
                MessageBox.Show("Number of Dependants cannot be blank", "Reserve Apartment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider4.SetError(cmbCustomer, "Please insert the number of Dependants!");
                return;
            }
            else
            {
                errorProvider4.SetError(cmbCustomer, null);
            }
            AddChiefOccupantDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void txtEmergencyContact_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void txtEmergencyContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoOfServants_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoOfDependants_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChiefOccupantSignup.ActiveForm.Hide();
            Apartments zxcg = new Apartments();
            zxcg.Show();
        }
    }
}
