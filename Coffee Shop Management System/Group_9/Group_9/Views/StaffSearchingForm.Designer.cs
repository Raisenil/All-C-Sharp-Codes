namespace Group_9.Views
{
    partial class StaffSearchingForm
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
            this.salary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmployees
            // 
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Location = new System.Drawing.Point(37, 286);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.Size = new System.Drawing.Size(364, 182);
            this.gridEmployees.TabIndex = 25;
            this.gridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmployees_CellContentClick);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(27, 187);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(47, 16);
            this.salary.TabIndex = 21;
            this.salary.Text = "Salary";
            this.salary.Click += new System.EventHandler(this.salary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bonus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(27, 113);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 16);
            this.Namelabel.TabIndex = 24;
            this.Namelabel.Text = "Name";
            this.Namelabel.Click += new System.EventHandler(this.Namelabel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(125, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(326, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(326, 61);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 20;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(125, 218);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(276, 20);
            this.tbBonus.TabIndex = 13;
            this.tbBonus.TextChanged += new System.EventHandler(this.tbBonus_TextChanged);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(125, 186);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(276, 20);
            this.tbSalary.TabIndex = 14;
            this.tbSalary.TextChanged += new System.EventHandler(this.tbSalary_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(125, 150);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(276, 20);
            this.tbUsername.TabIndex = 15;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(125, 112);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(276, 20);
            this.tbName.TabIndex = 16;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(30, 26);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(371, 20);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // StaffSearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 490);
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
            this.Name = "StaffSearchingForm";
            this.Text = "StaffSearchingForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSearch;
    }
}