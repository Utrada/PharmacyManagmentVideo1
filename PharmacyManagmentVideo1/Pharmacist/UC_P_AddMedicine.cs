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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PharmacyManagmentVideo1.Pharmacist
{
    public partial class UC_P_AddMedicine : UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;
        SqlConnection con = function.getConnection();

        private CrystalDecisions.CrystalReports.Engine.ReportDocument
        cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        static string Crypath = "";

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text!="" && txtMediName.Text!="" && txtMediNumber.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="")
            {
                String mid = txtMediID.Text;
                String mname = txtMediName.Text;
                String mnumber = txtMediNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String edate = txtExpireDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('"+mid+"','"+mname+"','"+mnumber+"','"+mdate+"','"+edate+"','"+quantity+"','"+perunit+"')";
                fn.setData(query,"Medicine Added to Database.");
            }
            else
            {
                MessageBox.Show("Enter all Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtQuantity.Clear();
            txtMediNumber.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter($"select * from medic", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string xml = @"D:/C#.Net Project/PharmacyManagmentVideo1/PharmacyManagmentVideo1/data2.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"D:/C#.Net Project/PharmacyManagmentVideo1/PharmacyManagmentVideo1/CrystalReport2.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
