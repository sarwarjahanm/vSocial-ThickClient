using MySql.Data.MySqlClient;
using System;
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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void homepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome W1 = new Welcome();
            W1.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string uname = username.Text;
            string passw = password.Text;

            string connectionString = "server=localhost;database=vsocial;uid=root;pwd=\"\";";
            MySqlConnection cn = new MySqlConnection(connectionString);

            if (uname == "" || passw == "")
            {
                errMsg.Text = "Error: Username or Password cannot be blank!";
            }
            else
            {
                try
                {
                    cn.Open();
                }
                catch {
                    err2.Text = "Error: Unable to connect. Deploy the Web App from Homepage then try again!";
                    err3.Text = "If you have deployed the WebApp already, make sure to start Apache and MySQL services in XAMPP portal then try again.";
                }

                string fetchpwd = "SELECT password FROM admins WHERE username='" + uname + "'";
                MySqlCommand cmd = new MySqlCommand(fetchpwd, cn);
                string fetchrole = "SELECT role FROM admins WHERE username='" + uname + "'";
                MySqlCommand cmd2 = new MySqlCommand(fetchrole, cn);
                try
                {
                    string dbpass = cmd.ExecuteScalar().ToString();

                    if (dbpass.Equals(passw))
                    {
                        string role = cmd2.ExecuteScalar().ToString();

                        if (role == "S")
                        {
                            this.Hide();
                            Dashboard D1 = new Dashboard();
                            D1.Show();
                        }
                        else {
                            this.Hide();
                            Dashboard_Admin DA1 = new Dashboard_Admin();
                            DA1.Show();
                        }
                    }
                    else
                    {
                        errMsg.Text = "Error: Wrong Password!";
                        username.Text = "";
                        password.Text = "";
                    }
                    cn.Close();

                }
                catch (Exception f)
                {
                    string error = f.Message.ToString();
                    if (error == "Object reference not set to an instance of an object.")
                    {
                        errMsg.Text = "Error: User does not exist!";
                    }
                }

            }
        }
    }
}
