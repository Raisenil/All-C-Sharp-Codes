namespace Group_9.Views
{
    partial class DashboardAdminForm
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
            this.Updatebox = new System.Windows.Forms.RichTextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Managmentlebel = new System.Windows.Forms.Label();
            this.btnSeeorder = new System.Windows.Forms.Button();
            this.btninventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Updatebox
            // 
            this.Updatebox.Location = new System.Drawing.Point(34, 24);
            this.Updatebox.Name = "Updatebox";
            this.Updatebox.Size = new System.Drawing.Size(160, 414);
            this.Updatebox.TabIndex = 0;
            this.Updatebox.Text = "";
            this.Updatebox.TextChanged += new System.EventHandler(this.Updatebox_TextChanged);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(63, 149);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 34);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(63, 189);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(100, 34);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(63, 229);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(100, 34);
            this.btnStaff.TabIndex = 1;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(63, 269);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(100, 34);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "UpdateInfo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(222, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 414);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Managmentlebel
            // 
            this.Managmentlebel.AutoSize = true;
            this.Managmentlebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managmentlebel.Location = new System.Drawing.Point(269, 67);
            this.Managmentlebel.Name = "Managmentlebel";
            this.Managmentlebel.Size = new System.Drawing.Size(96, 25);
            this.Managmentlebel.TabIndex = 4;
            this.Managmentlebel.Text = "Manage";
            // 
            // btnSeeorder
            // 
            this.btnSeeorder.Location = new System.Drawing.Point(265, 189);
            this.btnSeeorder.Name = "btnSeeorder";
            this.btnSeeorder.Size = new System.Drawing.Size(100, 34);
            this.btnSeeorder.TabIndex = 5;
            this.btnSeeorder.Text = "Order";
            this.btnSeeorder.UseVisualStyleBackColor = true;
            this.btnSeeorder.Click += new System.EventHandler(this.btnSeeorder_Click);
            // 
            // btninventory
            // 
            this.btninventory.Location = new System.Drawing.Point(265, 229);
            this.btninventory.Name = "btninventory";
            this.btninventory.Size = new System.Drawing.Size(100, 34);
            this.btninventory.TabIndex = 7;
            this.btninventory.Text = "Inventory";
            this.btninventory.UseVisualStyleBackColor = true;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // DashboardAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.btninventory);
            this.Controls.Add(this.btnSeeorder);
            this.Controls.Add(this.Managmentlebel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.Updatebox);
            this.Name = "DashboardAdminForm";
            this.Text = "DashboardAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Updatebox;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Managmentlebel;
        private System.Windows.Forms.Button btnSeeorder;
        private System.Windows.Forms.Button btninventory;
    }
}