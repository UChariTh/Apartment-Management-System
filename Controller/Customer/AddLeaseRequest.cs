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
    public partial class AddLeaseRequest : Form
    {
        ChiefOccupantSignup CHS;
        public AddLeaseRequest(ChiefOccupantSignup CHOSignUp)
        {
            InitializeComponent();
            this.CHS = CHOSignUp;
        }
       
        public void AddLeaseRequestFunction()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Lease (chiefOccupantID,refundableAmount,leaseStartDate,leaseExpiryDate,ApartmentID) " + "values (@chiefOccupantID,@refundableAmount,@leaseStartDate,@leaseExpiryDate,@ApartmentID)", con);
            SqlCommand cm = new SqlCommand("update Apartment set Status='Reserved' where ApartmentID=" + txtApID.Text + " ;", con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@chiefOccupantID", cmbChNo.GetItemText(cmbChNo.SelectedValue));
            cmd.Parameters.AddWithValue("@refundableAmount", txtRefundableAmount.Text);
            cmd.Parameters.AddWithValue("@leaseStartDate", date_LeaseStartDate.Text);
            cmd.Parameters.AddWithValue("@leaseExpiryDate", date_LeaseEndDate.Text);
            cmd.Parameters.AddWithValue("@ApartmentID", txtApID.Text);

            try
            {
                cmd.ExecuteNonQuery();
                cm.ExecuteNonQuery();
                MessageBox.Show("You have successfully Reserved your Apartment! Please expect a call from one of our Agents!");
                AddLeaseRequest.ActiveForm.Hide();
                Apartments dbg = new Apartments();
                dbg.Show();
            }
            catch (Exception )
            {
               // Console.WriteLine(e.ToString());
                MessageBox.Show("Database Error Try again!!!");
            }

        }
        private void AddLeaseRequest_Load(object sender, EventArgs e)
        {
           // txtChNum.Text = CHS.cmbCustomer.Text;
            cmbChNo.Text = CHS.cmbCustomer.Text;
            txtApID.Text = CHS.txtAPNum.Text;


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

        private void cmbChNum_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  SqlConnection con = new SqlConnection("Data Source=DESKTOP-49M7KTL;Initial Catalog=EApartments;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerDetails cus inner join ChiefOccupant ch ON cus.cusID = ch.cusID ", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("chiefOccupantID", typeof(string));
            dt.Load(reader);
            cmbChNum.ValueMember = "chiefOccupantID";
            cmbChNum.DisplayMember = "nic";
            cmbChNum.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                cmbChNum.Items.Add(dr["nic"].ToString());
            }
            con.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLeaseRequestFunction();
        }
    }
}
