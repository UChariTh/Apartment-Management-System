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
    public partial class ManageTenants : Form
    {
        public ManageTenants()
        {
            InitializeComponent();
        }
        public void EditStatus()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update CustomerDetails set name=@name,nic=@nic,address=@address where cusID=@cusID", con);

            cmd.Prepare();
           
            cmd.Parameters.AddWithValue("@cusID", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
            cmd.Parameters.AddWithValue("@address", txtAdd.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated ");

            }
            catch (Exception )
            {
                MessageBox.Show("Database Error Try again!!!");
            }
        }
        public void deleteAfterTenantsManage()
        {
            txtID.Clear();
            txtName.Clear();
            txtNIC.Clear();
            txtAdd.Clear();
        }

        public void DeleteLeaseReq()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CustomerDetails WHERE cusID=@cusID;", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@cusID", txtID.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Customer has been removed from the system!");
                deleteAfterTenantsManage();

            }
            catch (Exception)
            {
                MessageBox.Show("Database Error Try again!!!");
            }
        }


        private void ManageTenants_Load(object sender, EventArgs e)
        {

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNIC.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

        }
        public void EditTenants()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update CustomerDetails set name=@name,nic=@nic,address=@address where cusID=@cusID", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@cusID",txtID.Text);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@nic",txtNIC.Text);
            cmd.Parameters.AddWithValue("@address",txtAdd.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer has been updated successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show("Database Error Try again!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteLeaseReq();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select cusID,name,nic,address from CustomerDetails; ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ManageTenants.ActiveForm.Hide();
            AdminDashboard hdg = new AdminDashboard();
            hdg.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ManageTenants.ActiveForm.Hide();
            ManageTenants hrret = new ManageTenants();
            hrret.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ManageTenants.ActiveForm.Hide();
            ManageApartments uiui = new ManageApartments();
            uiui.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ManageTenants.ActiveForm.Hide();
            Lease bvbvb = new Lease();
            bvbvb.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EditTenants();
        }
    }
}
