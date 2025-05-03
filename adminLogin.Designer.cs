namespace vSocial
{
    partial class adminLogin
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
            this.homepage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.username = new System.Windows.Forms.MaskedTextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.errMsg = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.Label();
            this.err3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homepage
            // 
            this.homepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepage.Location = new System.Drawing.Point(39, 57);
            this.homepage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(132, 49);
            this.homepage.TabIndex = 1;
            this.homepage.Text = "Homepage";
            this.homepage.UseVisualStyleBackColor = true;
            this.homepage.Click += new System.EventHandler(this.homepage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Admin Login";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(686, 536);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(192, 66);
            this.login.TabIndex = 20;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(723, 451);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(282, 26);
            this.password.TabIndex = 19;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(723, 360);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(282, 26);
            this.username.TabIndex = 18;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(547, 443);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(147, 36);
            this.l2.TabIndex = 17;
            this.l2.Text = "Password";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(547, 351);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(150, 36);
            this.l1.TabIndex = 16;
            this.l1.Text = "Username";
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsg.Location = new System.Drawing.Point(548, 622);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(0, 25);
            this.errMsg.TabIndex = 22;
            // 
            // err2
            // 
            this.err2.AutoSize = true;
            this.err2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err2.Location = new System.Drawing.Point(445, 675);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(0, 25);
            this.err2.TabIndex = 23;
            // 
            // err3
            // 
            this.err3.AutoSize = true;
            this.err3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err3.Location = new System.Drawing.Point(266, 725);
            this.err3.Name = "err3";
            this.err3.Size = new System.Drawing.Size(0, 25);
            this.err3.TabIndex = 24;
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 944);
            this.Controls.Add(this.err3);
            this.Controls.Add(this.err2);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.homepage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "adminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homepage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.MaskedTextBox username;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.Label err2;
        private System.Windows.Forms.Label err3;
    }
}