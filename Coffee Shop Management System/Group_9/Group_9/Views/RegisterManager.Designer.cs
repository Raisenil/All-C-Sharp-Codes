namespace Group_9.Views
{
    partial class RegisterManager
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
            this.RegisterBt = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterBt
            // 
            this.RegisterBt.Location = new System.Drawing.Point(218, 243);
            this.RegisterBt.Name = "RegisterBt";
            this.RegisterBt.Size = new System.Drawing.Size(100, 30);
            this.RegisterBt.TabIndex = 18;
            this.RegisterBt.Text = "Register";
            this.RegisterBt.UseVisualStyleBackColor = true;
            this.RegisterBt.Click += new System.EventHandler(this.RegisterBt_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(124, 146);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(194, 20);
            this.PasswordBox.TabIndex = 15;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(124, 73);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(194, 20);
            this.NameBox.TabIndex = 16;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(124, 106);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(194, 20);
            this.UsernameBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(24, 71);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.Color.White;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(135, 31);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(100, 25);
            this.RegisterLabel.TabIndex = 10;
            this.RegisterLabel.Text = "Register";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(24, 186);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(53, 20);
            this.Salary.TabIndex = 11;
            this.Salary.Text = "Salary";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(124, 186);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(194, 20);
            this.SalaryBox.TabIndex = 15;
            this.SalaryBox.TextChanged += new System.EventHandler(this.SalaryBox_TextChanged);
            // 
            // RegisterManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 320);
            this.Controls.Add(this.RegisterBt);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterLabel);
            this.Name = "RegisterManager";
            this.Text = "RegisterManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBt;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.TextBox SalaryBox;
    }
}