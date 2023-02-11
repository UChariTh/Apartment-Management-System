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
    public partial class LeaseDetailsForm : Form
    {
        public LeaseDetailsForm()
        {
            InitializeComponent();
        }
        public void createReport3()
        {
            LeaseDetail cr = new LeaseDetail();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyfirstApp.Properties.Settings.MyFirstDBConnectionString"].ToString();

            string sql = "select * from LeaseDetailsView ";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

            adapter.Fill(ds, "LeaseDetailsView");
            DataTable dt = ds.Tables["LeaseDetailsView"];

            cr.SetDataSource(ds.Tables["LeaseDetailsView"]);
            reportViewer3.ReportSource = cr;
            reportViewer3.Refresh();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            createReport3();
        }

        private void LeaseDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LeaseDetailsForm.ActiveForm.Hide();
            AdminReports zxca = new AdminReports();
            zxca.Show();
        }
    }
}
