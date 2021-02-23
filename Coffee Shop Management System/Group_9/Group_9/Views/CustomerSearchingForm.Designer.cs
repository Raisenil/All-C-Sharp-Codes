namespace Group_9.Views
{
    partial class CustomerSearchingForm
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
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbPhoneno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomers
            // 
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Location = new System.Drawing.Point(29, 235);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(364, 182);
            this.gridCustomers.TabIndex = 38;
            this.gridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Username";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(19, 108);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 16);
            this.Namelabel.TabIndex = 37;
            this.Namelabel.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(318, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(318, 56);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 33;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(117, 145);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(276, 20);
            this.tbUsername.TabIndex = 28;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 107);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(276, 20);
            this.tbName.TabIndex = 29;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(22, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(371, 20);
            this.tbSearch.TabIndex = 30;
            // 
            // tbPhoneno
            // 
            this.tbPhoneno.Location = new System.Drawing.Point(117, 180);
            this.tbPhoneno.Name = "tbPhoneno";
            this.tbPhoneno.Size = new System.Drawing.Size(276, 20);
            this.tbPhoneno.TabIndex = 28;
            this.tbPhoneno.TextChanged += new System.EventHandler(this.tbPhoneno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Phone no";
            // 
            // CustomerSearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 442);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbPhoneno);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSearch);
            this.Name = "CustomerSearchingForm";
            this.Text = "CustomerSearchingForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbPhoneno;
        private System.Windows.Forms.Label label2;
    }
}