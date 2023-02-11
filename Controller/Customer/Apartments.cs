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
    public partial class Apartments : Form
    {
        
        public Apartments()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Apartments_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select BuildingLocation,BuildingID from Buildings", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Buildings", typeof(string));
                dt.Load(reader);
                cmdApart.ValueMember = "BuildingID";
                cmdApart.DisplayMember = "BuildingLocation";
                cmdApart.DataSource = dt;
                con.Close();

            }
            catch (Exception)
            {

            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Description,ClassID from ClassTables", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Class", typeof(string));
                dt.Load(reader);
                cmbType.ValueMember = "ClassID";
                cmbType.DisplayMember = "Description";
                cmbType.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        
               Console.WriteLine(cmdApart.SelectedValue);
               Console.WriteLine(cmbType.SelectedValue);
           
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ap.ApartmentID,b.BuildingLocation,ct.Description,ap.Status FROM Buildings " +"b inner join Apartment ap ON b.BuildingID = ap.BuildingID  inner join ClassTables ct on ct.ClassID = ap.ClassID  " +"where ap.Status = 'Available' AND b.BuildingID =" + cmdApart.GetItemText(cmdApart.SelectedValue) + " AND ct.ClassID = " + cmbType.GetItemText(cmbType.SelectedValue) + "; ", con);

              
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apartments.ActiveForm.Hide();
            ChiefOccupantSignup cheifForm = new ChiefOccupantSignup(this);
            cheifForm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtApartmentID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Apartments.ActiveForm.Hide();
            CustomerLease hjhjh = new CustomerLease();
            hjhjh.Show();
        }
    }
}
