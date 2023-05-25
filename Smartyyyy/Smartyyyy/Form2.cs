using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Smartyyyy
{
    public partial class frmRegister : Form
    {

        
        public frmRegister()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(""); 
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            loadUserData();
            txtusername.Select();
        }

        private void loadUserData()
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmLogin rf = new frmLogin();

            Hide();
            rf.ShowDialog();

          
          
            if (string.IsNullOrEmpty(txtusername.Text))
            {

                MessageBox.Show("Please Enter Username,", caption, btn, ico);
                txtusername.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {

                MessageBox.Show("Please Enter Password,", caption, btn, ico);
                txtPassword.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtComPassword.Text))
            {

                MessageBox.Show("Please Enter Confirming Password,", caption, btn, ico);
                txtComPassword.Select();
                return;
            }
            if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Your Password And Confirmation Password do not match.", caption, btn, ico);
                txtComPassword.SelectAll();
                return;
            }
           

            {
                MessageBox.Show("The Username already exists.Please try another username","Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
txtusername.SelectAll();
                return;

            
            
            }

            DialogResult result;
            result = MessageBox.Show("Do You Want to save the record)", "save data)",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
               
                

            }
        }



        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckbxShowPas.Checked == true)
            {

                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtComPassword.UseSystemPasswordChar = true;
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginOG logs = new LoginOG();
            logs.ShowDialog();
        }
    }

}
    



