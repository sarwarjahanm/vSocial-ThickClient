using MySql.Data.MySqlClient;
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
    public partial class BloggerDetails : Form
    {
        string roles = "";
        public BloggerDetails()
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

        private void BloggerDetails_Load(object sender, EventArgs e)
        {
            ShowBloggerdetails();
        }

        private void ShowBloggerdetails()
        {
            string connectionString = "server=localhost;database=vsocial;uid=root;pwd=\"\";";
            MySqlConnection cn = new MySqlConnection(connectionString);
            string qry = "";
            cn.Open();


            if (roles == "S")
            {
                qry = "SELECT * FROM bloggers";
            }
            else if (roles == "A")
            {
                qry = "SELECT username,fname,lname,address FROM bloggers";
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

        private void BloggerDetails_Load_1(object sender, EventArgs e)
        {
            ShowBloggerdetails();
        }
    }
}
