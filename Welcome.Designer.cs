namespace vSocial
{
    partial class Welcome
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
            this.credits = new System.Windows.Forms.Button();
            this.adminLogin = new System.Windows.Forms.Button();
            this.deployment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to VSocial";
            // 
            // credits
            // 
            this.credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.Location = new System.Drawing.Point(1261, 36);
            this.credits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(164, 41);
            this.credits.TabIndex = 3;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // adminLogin
            // 
            this.adminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogin.Location = new System.Drawing.Point(675, 490);
            this.adminLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(273, 66);
            this.adminLogin.TabIndex = 6;
            this.adminLogin.Text = "Admin Portal";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // deployment
            // 
            this.deployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deployment.Location = new System.Drawing.Point(330, 490);
            this.deployment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deployment.Name = "deployment";
            this.deployment.Size = new System.Drawing.Size(281, 66);
            this.deployment.TabIndex = 7;
            this.deployment.Text = "WebApp Deployment";
            this.deployment.UseVisualStyleBackColor = true;
            this.deployment.Click += new System.EventHandler(this.deployment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(774, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "This is the Windows Desktop/ThickClient version of vSocial application.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1273, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "If this the first time you have run the app, click on WebApp Deployment button be" +
    "low for setting up the vSocial web app.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1298, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "If you have already deployed the web app, click on Admin Portal button below and " +
    "can perform Administrative operations.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(886, 58);
            this.label5.TabIndex = 18;
            this.label5.Text = "If web app deployment is complete, you can access web by clicking following link:" +
    "\r\n           (Make sure to start Apache and MySQL services from XAMPP control pa" +
    "nel)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(998, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 66);
            this.button1.TabIndex = 20;
            this.button1.Text = "Access Web App";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 944);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deployment);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to vSocial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Button deployment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}