namespace vSocial
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.homepage = new System.Windows.Forms.Button();
            this.userDetails = new System.Windows.Forms.Button();
            this.bloggerDetails = new System.Windows.Forms.Button();
            this.adminDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resetDB = new System.Windows.Forms.Button();
            this.dbreset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homepage
            // 
            this.homepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepage.Location = new System.Drawing.Point(1194, 123);
            this.homepage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(179, 49);
            this.homepage.TabIndex = 3;
            this.homepage.Text = "Log Out";
            this.homepage.UseVisualStyleBackColor = true;
            this.homepage.Click += new System.EventHandler(this.homepage_Click);
            // 
            // userDetails
            // 
            this.userDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetails.Location = new System.Drawing.Point(374, 392);
            this.userDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userDetails.Name = "userDetails";
            this.userDetails.Size = new System.Drawing.Size(199, 66);
            this.userDetails.TabIndex = 21;
            this.userDetails.Text = "User Details";
            this.userDetails.UseVisualStyleBackColor = true;
            this.userDetails.Click += new System.EventHandler(this.login_Click);
            // 
            // bloggerDetails
            // 
            this.bloggerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloggerDetails.Location = new System.Drawing.Point(717, 392);
            this.bloggerDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bloggerDetails.Name = "bloggerDetails";
            this.bloggerDetails.Size = new System.Drawing.Size(199, 66);
            this.bloggerDetails.TabIndex = 22;
            this.bloggerDetails.Text = "Blogger Details";
            this.bloggerDetails.UseVisualStyleBackColor = true;
            this.bloggerDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminDetails
            // 
            this.adminDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDetails.Location = new System.Drawing.Point(1060, 392);
            this.adminDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminDetails.Name = "adminDetails";
            this.adminDetails.Size = new System.Drawing.Size(199, 66);
            this.adminDetails.TabIndex = 23;
            this.adminDetails.Text = "Admin Details";
            this.adminDetails.UseVisualStyleBackColor = true;
            this.adminDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Welcome to vSocial Super Admin Dashboard.";
            // 
            // resetDB
            // 
            this.resetDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetDB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.resetDB.Image = ((System.Drawing.Image)(resources.GetObject("resetDB.Image")));
            this.resetDB.Location = new System.Drawing.Point(717, 552);
            this.resetDB.Name = "resetDB";
            this.resetDB.Size = new System.Drawing.Size(199, 80);
            this.resetDB.TabIndex = 26;
            this.resetDB.Text = "Reset All Data";
            this.resetDB.UseVisualStyleBackColor = true;
            this.resetDB.Click += new System.EventHandler(this.resetDB_Click);
            // 
            // dbreset
            // 
            this.dbreset.AutoSize = true;
            this.dbreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbreset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dbreset.Location = new System.Drawing.Point(618, 649);
            this.dbreset.Name = "dbreset";
            this.dbreset.Size = new System.Drawing.Size(0, 29);
            this.dbreset.TabIndex = 27;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 944);
            this.Controls.Add(this.dbreset);
            this.Controls.Add(this.resetDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminDetails);
            this.Controls.Add(this.bloggerDetails);
            this.Controls.Add(this.userDetails);
            this.Controls.Add(this.homepage);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homepage;
        private System.Windows.Forms.Button userDetails;
        private System.Windows.Forms.Button bloggerDetails;
        private System.Windows.Forms.Button adminDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetDB;
        private System.Windows.Forms.Label dbreset;
    }
}