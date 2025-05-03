namespace vSocial
{
    partial class Dashboard_Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.bloggerDetails = new System.Windows.Forms.Button();
            this.userDetails = new System.Windows.Forms.Button();
            this.homepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Welcome to vSocial Admin Dashboard.";
            // 
            // bloggerDetails
            // 
            this.bloggerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloggerDetails.Location = new System.Drawing.Point(1003, 416);
            this.bloggerDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bloggerDetails.Name = "bloggerDetails";
            this.bloggerDetails.Size = new System.Drawing.Size(199, 66);
            this.bloggerDetails.TabIndex = 27;
            this.bloggerDetails.Text = "Blogger Details";
            this.bloggerDetails.UseVisualStyleBackColor = true;
            this.bloggerDetails.Click += new System.EventHandler(this.bloggerDetails_Click);
            // 
            // userDetails
            // 
            this.userDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetails.Location = new System.Drawing.Point(373, 416);
            this.userDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userDetails.Name = "userDetails";
            this.userDetails.Size = new System.Drawing.Size(199, 66);
            this.userDetails.TabIndex = 26;
            this.userDetails.Text = "User Details";
            this.userDetails.UseVisualStyleBackColor = true;
            this.userDetails.Click += new System.EventHandler(this.userDetails_Click);
            // 
            // homepage
            // 
            this.homepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepage.Location = new System.Drawing.Point(1023, 147);
            this.homepage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(179, 49);
            this.homepage.TabIndex = 25;
            this.homepage.Text = "Log Out";
            this.homepage.UseVisualStyleBackColor = true;
            this.homepage.Click += new System.EventHandler(this.homepage_Click);
            // 
            // Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 944);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bloggerDetails);
            this.Controls.Add(this.userDetails);
            this.Controls.Add(this.homepage);
            this.Name = "Dashboard_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bloggerDetails;
        private System.Windows.Forms.Button userDetails;
        private System.Windows.Forms.Button homepage;
    }
}