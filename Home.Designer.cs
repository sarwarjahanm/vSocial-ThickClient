namespace vSocial
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Button();
            this.adminLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.Label();
            this.msgBox2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.msgBox3 = new System.Windows.Forms.Label();
            this.msgBox4 = new System.Windows.Forms.Label();
            this.successBox = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.adminportal = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VSocial Setup Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 203);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // credits
            // 
            this.credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.Location = new System.Drawing.Point(1256, 22);
            this.credits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(164, 41);
            this.credits.TabIndex = 2;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminLogin
            // 
            this.adminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin.Location = new System.Drawing.Point(27, 20);
            this.adminLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(165, 44);
            this.adminLogin.TabIndex = 5;
            this.adminLogin.Text = "Admin Portal";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Deploy vSocial Web App";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // msgBox
            // 
            this.msgBox.AutoSize = true;
            this.msgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox.Location = new System.Drawing.Point(12, 622);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(0, 26);
            this.msgBox.TabIndex = 7;
            this.msgBox.Click += new System.EventHandler(this.label3_Click);
            // 
            // msgBox2
            // 
            this.msgBox2.AutoSize = true;
            this.msgBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox2.Location = new System.Drawing.Point(12, 659);
            this.msgBox2.Name = "msgBox2";
            this.msgBox2.Size = new System.Drawing.Size(0, 26);
            this.msgBox2.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(23, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(741, 25);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/sarwarjahanm/vSocial/blob/main/1.%20Setup%20Instructions.pdf";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "You can also deploy manually by using the following guide";
            // 
            // msgBox3
            // 
            this.msgBox3.AutoSize = true;
            this.msgBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox3.Location = new System.Drawing.Point(12, 695);
            this.msgBox3.Name = "msgBox3";
            this.msgBox3.Size = new System.Drawing.Size(0, 26);
            this.msgBox3.TabIndex = 12;
            // 
            // msgBox4
            // 
            this.msgBox4.AutoSize = true;
            this.msgBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBox4.Location = new System.Drawing.Point(12, 733);
            this.msgBox4.Name = "msgBox4";
            this.msgBox4.Size = new System.Drawing.Size(0, 26);
            this.msgBox4.TabIndex = 13;
            // 
            // successBox
            // 
            this.successBox.AutoSize = true;
            this.successBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successBox.Location = new System.Drawing.Point(12, 772);
            this.successBox.Name = "successBox";
            this.successBox.Size = new System.Drawing.Size(0, 29);
            this.successBox.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(47, 805);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 20);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(725, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Once deployment is complete, you can access full web by clicking following button" +
    ":";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(459, 481);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 25);
            this.msg.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(215, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 44);
            this.button2.TabIndex = 20;
            this.button2.Text = "Welcome Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminportal
            // 
            this.adminportal.AutoSize = true;
            this.adminportal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminportal.Location = new System.Drawing.Point(157, 288);
            this.adminportal.Name = "adminportal";
            this.adminportal.Size = new System.Drawing.Size(1074, 26);
            this.adminportal.TabIndex = 21;
            this.adminportal.Text = "If deployment successful, Admin module can be accessed by clicking \\\"Admin Portal" +
    "\\\" button above.";
            this.adminportal.Click += new System.EventHandler(this.adminportal_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(665, 424);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 41);
            this.button3.TabIndex = 22;
            this.button3.Text = "Access Web App";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 944);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.adminportal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.successBox);
            this.Controls.Add(this.msgBox4);
            this.Controls.Add(this.msgBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.msgBox2);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Label msgBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgBox3;
        private System.Windows.Forms.Label msgBox4;
        private System.Windows.Forms.Label successBox;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label adminportal;
        private System.Windows.Forms.Button button3;
    }
}

