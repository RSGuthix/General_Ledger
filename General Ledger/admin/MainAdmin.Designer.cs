namespace General_Ledger
{
    partial class MainAdmin
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
            this.ModifyUsers = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Button();
            this.ExpiredPasswords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            // 
            // ModifyUsers
            // 
            this.ModifyUsers.Location = new System.Drawing.Point(190, 154);
            this.ModifyUsers.Name = "ModifyUsers";
            this.ModifyUsers.Size = new System.Drawing.Size(92, 27);
            this.ModifyUsers.TabIndex = 1;
            this.ModifyUsers.Text = "Modify Users";
            this.ModifyUsers.UseVisualStyleBackColor = true;
            this.ModifyUsers.Click += new System.EventHandler(this.ModifyUsers_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(338, 156);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(75, 23);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            this.Email.UseVisualStyleBackColor = true;
            this.Email.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExpiredPasswords
            // 
            this.ExpiredPasswords.Location = new System.Drawing.Point(469, 154);
            this.ExpiredPasswords.Name = "ExpiredPasswords";
            this.ExpiredPasswords.Size = new System.Drawing.Size(119, 23);
            this.ExpiredPasswords.TabIndex = 3;
            this.ExpiredPasswords.Text = "Expired Passwords";
            this.ExpiredPasswords.UseVisualStyleBackColor = true;
            this.ExpiredPasswords.Click += new System.EventHandler(this.ExpiredPasswords_Click);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExpiredPasswords);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.ModifyUsers);
            this.Controls.Add(this.label1);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModifyUsers;
        private System.Windows.Forms.Button Email;
        private System.Windows.Forms.Button ExpiredPasswords;
    }
}