using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smartyyyy;
using System.Data.SqlClient;

namespace Smartyyyy
{
    public partial class LoginOG : Form
    {
        public LoginOG()
        {
            InitializeComponent();
        }
       
        
           
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();

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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = txtusername.Text;
            user_password = txtPassword.Text;

            try
            {

                string querry = "SELECT * FROM LOGIN_new WHERE username='" + "'" +txtusername.Text + "' " + txtPassword.Text + "'";


                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {

                    username = txtusername.Text;
                    user_password = txtPassword.Text;



                    Main_Fofm form2 = new Main_Fofm();
                    form2.Show();
                    this.Hide();

                }
                else

                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtPassword.Clear();


                }
            



            }
            catch

            {
                MessageBox.Show("Error");
            }

            finally
            {
conn.Close();
             
            }
        }
    }
}


