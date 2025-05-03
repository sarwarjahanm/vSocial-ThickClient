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
    public partial class AdminDetails : Form
    {
        public AdminDetails()
        {
            InitializeComponent();
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard D1 = new Dashboard();
            D1.Show();
        }

        private void ShowAdmindetails()
        {
            string connectionString = "server=localhost;database=vsocial;uid=root;pwd=\"\";";
            MySqlConnection cn = new MySqlConnection(connectionString);

            cn.Open();
            string qry = "SELECT * FROM admins";
            MySqlCommand cmd = new MySqlCommand(qry, cn);
            MySqlDataReader read = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminDetails_Load_1(object sender, EventArgs e)
        {
            ShowAdmindetails();
        }
    }
}
