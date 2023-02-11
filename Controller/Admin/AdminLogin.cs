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
using System.Xml.Linq;

namespace E_Appartments.Controller
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin invs = new CustomerLogin();
            invs.Show();
        }
        public void adminlogin()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AdminDetails where username = @username and password = @password", con);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@username", txt_AdminUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txt_AdminPassword.Text.Trim());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                if (reader.HasRows)
                {
                    MessageBox.Show("Logged in Successfully!");
                    AdminLogin.ActiveForm.Hide();
                    ManageApartments dbb = new ManageApartments();
                    dbb.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username/Password");
                }
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txt_AdminUsername.Text == "" && txt_AdminPassword.Text == "")
            {
                MessageBox.Show("Username and Password cannot be blanked");
                return;
            }
            else if (txt_AdminUsername.Text == "")
            {
                MessageBox.Show("Username cannot be blanked");
                return;
            }
            else if (txt_AdminPassword.Text == "")
            {
                MessageBox.Show("Password cannot be blanked");
                return;
            }
            adminlogin();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
