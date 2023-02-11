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
using System.Configuration;
using E_Appartments.Controller.Admin;

namespace E_Appartments.Reports
{
    public partial class CustomerDetailsForm : Form
    {
        public CustomerDetailsForm()
        {
            InitializeComponent();
        }
        public void createReport2()
        {
            CustomerDetail cr = new CustomerDetail();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyfirstApp.Properties.Settings.MyFirstDBConnectionString"].ToString();

            string sql = "select * from CustomerDetailsView ";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

            adapter.Fill(ds, "CustomerDetailsView");
            DataTable dt = ds.Tables["CustomerDetailsView"];

            cr.SetDataSource(ds.Tables["CustomerDetailsView"]);
            crystalReportViewer2.ReportSource = cr;
            crystalReportViewer2.Refresh();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            createReport2();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomerDetailsForm.ActiveForm.Hide();
            AdminReports jhjhj = new AdminReports();
            jhjhj.Show();
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
