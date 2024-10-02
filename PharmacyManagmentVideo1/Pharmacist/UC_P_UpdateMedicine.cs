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
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text!="")
            {
                query = "select * from medic where mid = '"+txtMediID.Text+"'";
                ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count!=0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMediNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID : " + txtMediID.Text + "exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMediNo.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();
            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMediName.Text;
            String mnumber = txtMediNo.Text;
            String mdate = txtMDate.Text;
            String edate = txtEDate.Text;
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medic set mname='"+mname+"', mnumber='"+mnumber+"',mDate='"+mdate+"',eDate='"+edate+"',quantity="+totalQuantity+",perUnit="+unitprice+" where mid='"+txtMediID.Text+"'";
            fn.setData(query,"Medicine Details Updated.");
        }
    }
}
