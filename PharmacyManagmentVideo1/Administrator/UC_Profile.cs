﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagmentVideo1.Administrator
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { userNameLabel.Text = value; }
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            try {
                query = "select * from users where username='" + userNameLabel.Text + "'";
                ds = fn.getData(query);
                txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
            } 
            catch (Exception) 
            {
                MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String userRole = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String username = userNameLabel.Text;
            String pass = txtPassword.Text;


            query = "update users set userRole='" +userRole + "',name='" + name + "',dob='" + dob + "',mobile=" + mobile + ",email='" + email + "',pass='" + pass + "' where username='"+username+"'";
            fn.setData(query,"Profile Updation Successful.");

        }
    }
}
