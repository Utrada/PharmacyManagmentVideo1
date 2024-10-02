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
  
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;


        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex == 0)
            {
                DateTime dateTime = DateTime.Today;
                query = "select * from medic where eDate >= '" + dateTime.ToString("dd-MM-yyyy") + "'";
                setDataGridView(query, "Valid Medicines.", Color.Black);
            }
            else if(txtCheck.SelectedIndex == 1)
            {
                DateTime dateTime = DateTime.Today;
                query = "select * from medic where eDate <= '" + dateTime.ToString("dd-MM-yyyy") + "'";
                setDataGridView(query, "Expired Medicine.", Color.Red);
            }
            else if(txtCheck.SelectedIndex == 2)
            {
                DateTime dateTime = DateTime.Today;
                query = "select * from medic";
                setDataGridView(query, "", Color.Black);
            }
        }

        private void setDataGridView(String query,String labelName,Color col)
        {
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            dataGridView1.DataSource = ds.Tables[0];
            setLabel.Text = labelName;
            setLabel.ForeColor = col;
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }
    }
}
