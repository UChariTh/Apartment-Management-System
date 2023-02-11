using E_Appartments.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Appartments.Controller.Customer;
using System.Data.SqlClient;

namespace E_Appartments
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }
        public void CustomerLoginFunction()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from CustomerDetails where username = @username and password = @password", con);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@username", txtLoginUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txtLoginPassword.Text.Trim());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                if (reader.HasRows)
                {
                    MessageBox.Show("You have been Logged in Successfully!");
                    CustomerLogin.ActiveForm.Hide();
                    Apartments dbb = new Apartments();
                    dbb.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username/Password");
                }
            }
        }
        private void UI_Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtLoginUsername.Text == "")
            {
                MessageBox.Show("Username Cannot Be Empty!", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtLoginUsername, "Please insert your Username!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtLoginUsername, null);
            }
            if (txtLoginPassword.Text == "")
            {
                MessageBox.Show("Password Cannot Be Empty!", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(txtLoginPassword, "Please insert your Password!");
                return;
            }
            else
            {
                errorProvider2.SetError(txtLoginPassword, null);
            }
            
            CustomerLoginFunction();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegistration zxczgad = new CustomerRegistration();
            zxczgad.Show();
        }
    }
}
