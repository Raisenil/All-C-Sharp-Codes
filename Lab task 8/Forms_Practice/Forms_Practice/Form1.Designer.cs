namespace Forms_Practice
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.User);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 196);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(366, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Login);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(186, 37);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(255, 20);
            this.User.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(186, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(255, 20);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EditUser);
            this.panel2.Controls.Add(this.AddUser);
            this.panel2.Location = new System.Drawing.Point(39, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 196);
            this.panel2.TabIndex = 0;
            // 
            // EditUser
            // 
            this.EditUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.EditUser.Location = new System.Drawing.Point(261, 39);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(107, 53);
            this.EditUser.TabIndex = 2;
            this.EditUser.Text = "Edit User";
            this.EditUser.UseVisualStyleBackColor = false;
            this.EditUser.Click += new System.EventHandler(this.Error);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.AddUser.Location = new System.Drawing.Point(79, 39);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(107, 53);
            this.AddUser.TabIndex = 2;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.addUser);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button AddUser;
    }
}

