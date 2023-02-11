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
    public partial class ApartmentDetailsForm : Form
    {
        public ApartmentDetailsForm()
        {
            InitializeComponent();
        }

        public void createReport1()
        {
            ApartmentDetails cr = new ApartmentDetails();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyfirstApp.Properties.Settings.MyFirstDBConnectionString"].ToString();

            string sql = "select * from ApartmentDetails ";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

            adapter.Fill(ds, "ApartmentDetails");
            DataTable dt = ds.Tables["ApartmentDetails"];

            cr.SetDataSource(ds.Tables["ApartmentDetails"]);
            reportViewer1.ReportSource = cr;
            reportViewer1.Refresh();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            createReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApartmentDetails cr = new ApartmentDetails();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyfirstApp.Properties.Settings.MyFirstDBConnectionString"].ToString();

            try
            {
                if (cmb1.SelectedIndex == 0)
                {
                    errorProvider2.SetError(cmb1, null);
                    string sql = "SELECT * FROM ApartmentDetails where Status = 'Available' ";
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                    adapter.Fill(ds, "ApartmentDetails");
                    DataTable dt = ds.Tables["ApartmentDetails"];

                    cr.SetDataSource(ds.Tables["ApartmentDetails"]);
                    reportViewer1.ReportSource = cr;
                    reportViewer1.Refresh();
                }
                else if (cmb1.SelectedIndex == 1)
                 {
                     errorProvider2.SetError(cmb1, null);
                     string sql = "SELECT * FROM ApartmentDetails where Status = 'Unavailable' ";
                     DataSet ds = new DataSet();
                     SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                     adapter.Fill(ds, "Agents");
                     DataTable dt = ds.Tables["Agents"];

                     cr.SetDataSource(ds.Tables["Agents"]);
                     reportViewer1.ReportSource = cr;
                     reportViewer1.Refresh();
                 }
                 else if (cmb1.SelectedIndex == 2)
                 {
                    errorProvider2.SetError(cmb1, null);
                    string sql = "SELECT * FROM ApartmentDetails where Status = 'Reserved' ";
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                    adapter.Fill(ds, "Agents");
                    DataTable dt = ds.Tables["Agents"];

                    cr.SetDataSource(ds.Tables["Agents"]);
                    reportViewer1.ReportSource = cr;
                    reportViewer1.Refresh();
                }
                else if (cmb1.SelectedIndex == 3)
                {
                    errorProvider2.SetError(cmb1, null);
                    string sql = "SELECT * FROM ApartmentDetails where Status = 'Day Extend' ";
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                    adapter.Fill(ds, "Agents");
                    DataTable dt = ds.Tables["Agents"];

                    cr.SetDataSource(ds.Tables["Agents"]);
                    reportViewer1.ReportSource = cr;
                    reportViewer1.Refresh();
                }
                else
                {
                    errorProvider2.SetError(cmb1, "Please select an Apartment Type first");
                    return;
                }
            }
            catch (Exception)
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ApartmentDetailsForm.ActiveForm.Hide();
            AdminReports jhjhj = new AdminReports();
            jhjhj.Show();
        }

        private void ApartmentDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

