namespace Group_9.Views
{
    partial class StaffinfoForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRegisterStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(66, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRegisterStaff
            // 
            this.btnRegisterStaff.Location = new System.Drawing.Point(66, 67);
            this.btnRegisterStaff.Name = "btnRegisterStaff";
            this.btnRegisterStaff.Size = new System.Drawing.Size(125, 40);
            this.btnRegisterStaff.TabIndex = 2;
            this.btnRegisterStaff.Text = "Register Staff";
            this.btnRegisterStaff.UseVisualStyleBackColor = true;
            this.btnRegisterStaff.Click += new System.EventHandler(this.btnRegisterStaff_Click);
            // 
            // StaffinfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 251);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRegisterStaff);
            this.Name = "StaffinfoForm";
            this.Text = "StaffinfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegisterStaff;
    }
}