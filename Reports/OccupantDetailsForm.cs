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
    public partial class OccupantDetailsForm : Form
    {
        public OccupantDetailsForm()
        {
            InitializeComponent();
        }
        public void createReport4()
        {
            ChiefOccupantDetail cr = new ChiefOccupantDetail();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyfirstApp.Properties.Settings.MyFirstDBConnectionString"].ToString();

            string sql = "select * from Chief_OccupantDetailsView ";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

            adapter.Fill(ds, "Chief_OccupantDetailsView");
            DataTable dt = ds.Tables["Chief_OccupantDetailsView"];

            cr.SetDataSource(ds.Tables["Chief_OccupantDetailsView"]);
            reportViewer4.ReportSource = cr;
            reportViewer4.Refresh();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            createReport4();
        }

        private void OccupantDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            OccupantDetailsForm.ActiveForm.Hide();
            AdminReports yhyh = new AdminReports();
            yhyh.Show();
        }
    }
}
