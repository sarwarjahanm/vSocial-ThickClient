using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;


namespace vSocial
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credits C1 = new Credits();
            C1.Show();
        }

       

        private void adminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin A1 = new adminLogin();
            A1.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            bool errcode = false;
            // Copy vSocial webapp files to C:\xampp\htdocs\vSocial\ directory
            msg.Text = "Copying vSocial WebApp files...";
            var sourceDir = Path.Combine(Environment.CurrentDirectory, "vSocial");
            var sourceDirInfo = new DirectoryInfo(sourceDir);

            var targetDir = @"C:\xampp\htdocs\vSocial\";
            var targetDirInfo = new DirectoryInfo(targetDir);

            CopyFiles(sourceDirInfo, targetDirInfo);

            msg.Text = "Copying vSocial WebApp files to C:/xampp/htdocs/ complete.";
            //Copy vSocial webapp files to C:\xampp\htdocs\vSocial\ directory complete


            msgBox.Text = "Initializing vSocial webApp Setup...";

            string connectionString1 = "server=localhost;uid=root;pwd=\"\";";
            MySqlConnection cnn1 = new MySqlConnection(connectionString1);

            try
            {
                cnn1.Open();
                msgBox.Text = "Creating database vsocial...";

                // Database Setup
                string sql0 = "create database vsocial";
                MySqlCommand cmd0 = new MySqlCommand(sql0,cnn1);
                int i = cmd0.ExecuteNonQuery();
                if (i > -1)
                {
                    msgBox2.Text = "Created Database vSocial.";
                }

            }
            catch {
                msgBox.Text = "Error: Make sure to start Apache and MySQL services in XAMPP portal.";
                errcode = true;
                msgBox2.Text = "Maybe vSocial database already exists, if you are not running this module first time!";
            }
            finally { cnn1.Close(); }

            string connectionString2 = "server=localhost;database=vsocial;uid=root;pwd=\"\";";
            MySqlConnection cnn2 = new MySqlConnection(connectionString2);

            try
            {
                cnn2.Open();
                msgBox3.Text = "Creating Tables...";

                // Create Tables
                string sql1 = "CREATE TABLE users(username VARCHAR(30),password VARCHAR(35),fname VARCHAR(30),lname VARCHAR(30),address VARCHAR(250),pic VARCHAR(250));";
                MySqlCommand cmd1 = new MySqlCommand(sql1, cnn2);
                string sql2 = "CREATE TABLE admins(username VARCHAR(30),password VARCHAR(35),role CHAR(1),fname VARCHAR(30),lname VARCHAR(30),address VARCHAR(250),pic VARCHAR(250));";
                MySqlCommand cmd2 = new MySqlCommand(sql2, cnn2);
                string sql3 = "CREATE TABLE bloggers(username VARCHAR(30),password VARCHAR(100),fname VARCHAR(30),lname VARCHAR(30),address VARCHAR(250),pic VARCHAR(250));";
                MySqlCommand cmd3 = new MySqlCommand(sql3, cnn2);
                string sql4 = "CREATE TABLE blogs(author VARCHAR(30),title VARCHAR(250),body VARCHAR(1500));";
                MySqlCommand cmd4 = new MySqlCommand(sql4, cnn2);
                string sql5 = "CREATE TABLE messages(username VARCHAR(30),message VARCHAR(500),sender VARCHAR(30));";
                MySqlCommand cmd5 = new MySqlCommand(sql5, cnn2);
                string sql6 = "CREATE TABLE logs(url VARCHAR(200),timestamp VARCHAR(50),description VARCHAR(2000));";
                MySqlCommand cmd6 = new MySqlCommand(sql6, cnn2);

                cmd1.ExecuteNonQuery();cmd2.ExecuteNonQuery();cmd3.ExecuteNonQuery();cmd4.ExecuteNonQuery();cmd5.ExecuteNonQuery();cmd6.ExecuteNonQuery();
                msgBox3.Text = "All Tables Created successfully.";

                // Insert default data
                string sql7 = "INSERT INTO admins(username, password, role) VALUES('admin', 'admin', 'A');";
                MySqlCommand cmd7 = new MySqlCommand(sql7, cnn2);               

                cmd7.ExecuteNonQuery();
                msgBox4.Text = "Default Data inserted.";
                successBox.Text = "vSocial WebApp deployed successfully. Click on \"Access Web App\" button above";
                adminportal.Text = "If deployment successful, Admin module can be accessed by clicking \"Admin Portal\" button above.";
                
            }
            catch
            {
                successBox.Text = ""; msgBox4.Text = ""; msgBox3.Text = "";
                msgBox3.Text = "Try accessing the WebApp by clicking \"Access Web App\" button above.";
            }
            finally { 
                cnn2.Close(); 
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel2.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void CopyFiles(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            foreach (var file in source.GetFiles())
            {
                Thread.Sleep(50);
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }

            foreach(var sourceSubdirectory in source.GetDirectories())
            {
                Thread.Sleep(50);
                var targetSubdirectory = target.CreateSubdirectory(sourceSubdirectory.Name);
                CopyFiles(sourceSubdirectory, targetSubdirectory);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome W1 = new Welcome();
            W1.Show();
        }

        private void adminportal_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:81/VSocial/home.php");
        }
    }
}
