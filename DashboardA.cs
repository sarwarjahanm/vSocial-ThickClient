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
    public partial class Dashboard_Admin : Form
    {
        public Dashboard_Admin()
        {
            InitializeComponent();
        }

        private void userDetails_Click(object sender, EventArgs e)
        {
            string role = "A";
            this.Hide();
            UserDetails U1 = new UserDetails();
            U1.UserRole(role);
            U1.Show();
        }

        private void bloggerDetails_Click(object sender, EventArgs e)
        {
            string role = "A";
            this.Hide();
            BloggerDetails B1 = new BloggerDetails();
            B1.UserRole(role);
            B1.Show();
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin A1 = new adminLogin();
            A1.Show();
        }
    }
}
