using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // method
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Correct !");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
