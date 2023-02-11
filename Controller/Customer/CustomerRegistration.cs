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

namespace E_Appartments.Controller.Customer
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }
        public void CustomerRegFunction()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CustomerDetails (name,nic,address,username,password) " + "values (@name,@nic,@address,@username,@password)", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have been Registered successfully");
                CustomerRegistration.ActiveForm.Hide();
                CustomerLogin dbbs = new CustomerLogin();
                dbbs.Show();

            }
            catch (Exception )
            {
                MessageBox.Show("Database Error Try again!!!");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name Cannot Be Empty!", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtName, "Please insert your Name!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }

            if (txtNIC.Text == "")
            {
                MessageBox.Show("NIC Cannot Be Empty!", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(txtNIC, "Please insert your NIC/Passport Number!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtNIC, null);
            }

            if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Cannot Be Empty!", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(txtNIC, "Please insert your Address!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtAddress, null);
            }
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username Cannot Be Empty!", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(txtNIC, "Please insert your Username!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtUsername, null);
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password Cannot Be Empty!", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(txtNIC, "Please insert your Password!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtPassword, null);
            }

            CustomerRegFunction();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtName.Clear();
            txtNIC.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerRegistration.ActiveForm.Hide();
            CustomerLogin xczgas = new CustomerLogin();
            xczgas.Show();
        }
    }
}
