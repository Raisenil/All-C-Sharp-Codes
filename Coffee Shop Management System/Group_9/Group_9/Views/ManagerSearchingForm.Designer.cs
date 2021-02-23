namespace Group_9.Views
{
    partial class ManagerSearchingForm
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
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmployees
            // 
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Location = new System.Drawing.Point(58, 290);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(364, 182);
            this.gridEmployees.TabIndex = 12;
            this.gridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployees_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(48, 117);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 16);
            this.Namelabel.TabIndex = 11;
            this.Namelabel.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(347, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(347, 65);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(146, 154);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(276, 20);
            this.tbUsername.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(146, 116);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(276, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(51, 30);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(371, 20);
            this.tbSearch.TabIndex = 6;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(146, 190);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(276, 20);
            this.tbSalary.TabIndex = 4;
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(146, 222);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(276, 20);
            this.tbBonus.TabIndex = 4;
            this.tbBonus.TextChanged += new System.EventHandler(this.tbBonus_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bonus";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(48, 191);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(47, 16);
            this.salary.TabIndex = 10;
            this.salary.Text = "Salary";
            this.salary.Click += new System.EventHandler(this.label3_Click);
            // 
            // ManagerSearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 504);
            this.Controls.Add(this.gridEmployees);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSearch);
            this.Name = "ManagerSearchingForm";
            this.Text = "ManagerSearching";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label salary;
    }
}