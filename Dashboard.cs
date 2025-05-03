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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            dbreset.Text = "";
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin A1 = new adminLogin();
            A1.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string role = "S";
            this.Hide();
            UserDetails U1 = new UserDetails();
            U1.UserRole(role);
            U1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string role = "S";
            this.Hide();
            BloggerDetails B1 = new BloggerDetails();
            B1.UserRole(role);
            B1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDetails A1 = new AdminDetails();
            A1.Show();
        }


        private void resetDB_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=vsocial;uid=root;pwd=\"\";";
            MySqlConnection cn = new MySqlConnection(connectionString);

            try
            {
                cn.Open();
                string qry1 = "DELETE FROM users;DELETE FROM admins;DELETE FROM bloggers;DELETE FROM blogs;DELETE FROM messages;DELETE FROM logs;";
                MySqlCommand cmd = new MySqlCommand(qry1, cn);
                cmd.ExecuteNonQuery();
                string qry2 = "INSERT INTO admins(username, password, role) VALUES('admin', 'admin', 'A');";
                MySqlCommand cmd2 = new MySqlCommand(qry2, cn);
                cmd2.ExecuteNonQuery();

                cn.Close();
                dbreset.Text = "Database hard reset successful!";
            }
            catch {
                dbreset.Text = "Connection error! Restart XAMPP services.";
            }
            finally { cn.Close(); }
        }
    }
}
