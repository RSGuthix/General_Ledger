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
            this.CreateNewUser = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ModifyUsers
            // 
            this.ModifyUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyUsers.Location = new System.Drawing.Point(263, 165);
            this.ModifyUsers.Name = "ModifyUsers";
            this.ModifyUsers.Size = new System.Drawing.Size(130, 76);
            this.ModifyUsers.TabIndex = 1;
            this.ModifyUsers.Text = "Modify Users";
            this.ModifyUsers.UseVisualStyleBackColor = true;
            this.ModifyUsers.Click += new System.EventHandler(this.ModifyUsers_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(408, 166);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(118, 75);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email";
            this.Email.UseVisualStyleBackColor = true;
            this.Email.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateNewUser
            // 
            this.CreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewUser.Location = new System.Drawing.Point(87, 165);
            this.CreateNewUser.Name = "CreateNewUser";
            this.CreateNewUser.Size = new System.Drawing.Size(154, 76);
            this.CreateNewUser.TabIndex = 3;
            this.CreateNewUser.Text = "Create New User";
            this.CreateNewUser.UseVisualStyleBackColor = true;
            this.CreateNewUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.Location = new System.Drawing.Point(541, 166);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(151, 76);
            this.SignOutButton.TabIndex = 4;
            this.SignOutButton.Text = "SignOut";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.CreateNewUser);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.ModifyUsers);
            this.Controls.Add(this.label1);
            this.Name = "MainAdmin";
            this.Text = "Create New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModifyUsers;
        private System.Windows.Forms.Button Email;
        private System.Windows.Forms.Button CreateNewUser;
        private System.Windows.Forms.Button SignOutButton;
    }
}