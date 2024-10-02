using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagmentVideo1
{
    public partial class Pharmacist1 : Form
    {
        public Pharmacist1()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uC_P_Dashbord1.Visible = true;
            uC_P_Dashbord1.BringToFront();
        }

        private void Pharmacist1_Load(object sender, EventArgs e)
        {
            uC_P_Dashbord1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void btnMedValidityCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }
    }
}
