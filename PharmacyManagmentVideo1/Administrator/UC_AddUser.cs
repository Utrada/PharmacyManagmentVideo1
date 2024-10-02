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
    public partial class UC_AddUser : UserControl
    {

        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String userRole = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('"+userRole+"','"+name+"','"+dob+"',"+mobile+",'"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Sign Up Successful.");
            }
            catch(Exception)
            {
                MessageBox.Show("Username Allready exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='"+txtUserName.Text+"'";
            DataSet ds = fn.getData(query);
            
            if(ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.ImageLocation = @"C:\Users\91968\Downloads\C# Pharmacy Management System\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\91968\Downloads\C# Pharmacy Management System\no.png";
            }
        }
    }
}
