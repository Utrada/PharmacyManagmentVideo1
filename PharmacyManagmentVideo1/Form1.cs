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
    public partial class Form1 : Form
    {

        function fn = new function();
        String query, query1;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            query = "select * from users";
            ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count!=0)
            {
                if(txtUsername.Text=="admin" && txtPassword.Text=="admin")
                {
                    Administrator1 admin = new Administrator1(txtUsername.Text);
                    admin.Show();
                    this.Hide();
                } else {
                    query1 = "select * from users where username='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'";
                    ds = fn.getData(query1);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        String role = ds.Tables[0].Rows[0][1].ToString();
                        if (role == "Administrator")
                        {
                            Administrator1 admin = new Administrator1();
                            admin.Show();
                            this.Hide();
                        }
                        else if (role == "Pharmacist")
                        {
                            Pharmacist1 pharm = new Pharmacist1();
                            pharm.Show();
                            this.Hide();
                        }
                    } else
                    {
                        MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /*if(txtUsername.Text=="admin" && txtPassword.Text=="admin")
            {
                Administrator1 am = new Administrator1();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
