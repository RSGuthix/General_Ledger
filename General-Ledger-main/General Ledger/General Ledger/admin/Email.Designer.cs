namespace General_Ledger.admin
{
    partial class Email
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(290, 91);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(185, 20);
            this.EmailTextBox.TabIndex = 0;
            this.EmailTextBox.Text = "Email";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(182, 202);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(419, 124);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message";
            this.Message.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(290, 149);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(185, 20);
            this.Subject.TabIndex = 2;
            this.Subject.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Send Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(265, 362);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(444, 362);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 5;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "Email";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Return;
    }
}