using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vSocial
{
    public partial class UserDetails : Form
    {
        string roles = "";
        public UserDetails()
        {
            InitializeComponent();
        }

        internal void UserRole(String role)
        {
            roles = role;
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            if (roles == "S")
            {
                this.Hide();
                Dashboard D1 = new Dashboard();
                D1.Show();
            }
            else if (roles == "A")
            {
                this.Hide();
                Dashboard_Admin A1 = new Dashboard_Admin();
                A1.Show();
            }
            
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            showUserdetails();
        }

        private void showUserdetails()
        {
            string connectionString = "server=localhost;database=vsocial;uid=root;pwd=\"\";";
            MySqlConnection cn = new MySqlConnection(connectionString);
            string qry = "";
            cn.Open();

            if (roles == "S")
            {
                qry = "SELECT * FROM users";
            }
            else if (roles == "A")
            {
                qry = "SELECT username,fname,lname,address FROM users";
            }


                MySqlCommand cmd = new MySqlCommand(qry, cn);
            MySqlDataReader read = cmd.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
