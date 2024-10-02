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
    public partial class Administrator1 : Form
    {
        String user = "";

        public Administrator1()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }
        public Administrator1(String username)
        {
            InitializeComponent();
            userLabel.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = true;
            uC_Dashbord1.BringToFront();
        }

        private void Administrator1_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Profile1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }
    }
}
