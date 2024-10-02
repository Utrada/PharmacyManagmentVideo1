using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagmentVideo1.Pharmacist
{
    public partial class UC_P_Dashbord : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;

        public UC_P_Dashbord()
        {
            InitializeComponent();
        }

        private void UC_P_Dashbord_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart()
        {
            DateTime dateTime = DateTime.Today;
            query = "select count(mname) from medic where eDate >= '" + dateTime.ToString("dd-MM-yyyy") + "'";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", count);

            query= "select count(mname) from medic where eDate >= '" + dateTime.ToString("dd-MM-yyyy") + "'";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicines"].Points.Clear();
            chart1.Series["Expired Medicines"].Points.Clear();
            loadChart();
        }
    }
}
