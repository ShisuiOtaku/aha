using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartyyyy
{
    public partial class Employee_reggis : Form
    {
        public static string z ;
            public static string x ;
        public Employee_reggis()
        {
            InitializeComponent();
        }

        private void Employee_reggis_Load(object sender, EventArgs e)
        {
           
            }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            z=txtname.Text;
            x=txtemail.Text;
            string message = "Success";
            String title = "Job Advert";
            MessageBox.Show(message, title);

        }
    }
    }

