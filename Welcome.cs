using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSocial
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credits C1 = new Credits();
            C1.Show();
        }

        private void deployment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home H1 = new Home();
            H1.Show();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin A1 = new adminLogin();
            A1.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:81/VSocial/home.php");
        }
    }
}
