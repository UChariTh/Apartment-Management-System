using E_Appartments.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Appartments.Controller.Customer;
using E_Appartments.Controller.Admin;
using E_Appartments.Reports;



namespace E_Appartments
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LeaseExtendAccept ());
        }
    }
}
