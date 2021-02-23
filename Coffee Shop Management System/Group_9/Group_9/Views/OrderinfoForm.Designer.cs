namespace Group_9.Views
{
    partial class OrderinfoForm
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSearchitem = new System.Windows.Forms.Button();
            this.tbSearchName = new System.Windows.Forms.Button();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(49, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(371, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btSearchitem
            // 
            this.btSearchitem.Location = new System.Drawing.Point(449, 29);
            this.btSearchitem.Name = "btSearchitem";
            this.btSearchitem.Size = new System.Drawing.Size(126, 23);
            this.btSearchitem.TabIndex = 2;
            this.btSearchitem.Text = "Search by item";
            this.btSearchitem.UseVisualStyleBackColor = true;
            this.btSearchitem.Click += new System.EventHandler(this.btSearchitem_Click);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(449, 65);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(126, 23);
            this.tbSearchName.TabIndex = 3;
            this.tbSearchName.Text = "Search by Username";
            this.tbSearchName.UseVisualStyleBackColor = true;
            this.tbSearchName.Click += new System.EventHandler(this.tbSearchName_Click);
            // 
            // gridOrders
            // 
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Location = new System.Drawing.Point(49, 130);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(526, 264);
            this.gridOrders.TabIndex = 4;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(449, 101);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(126, 23);
            this.btnrefresh.TabIndex = 5;
            this.btnrefresh.Text = "Refresh Table";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // OrderinfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.btSearchitem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbSearch);
            this.Name = "OrderinfoForm";
            this.Text = "OrderinfoForm";
            this.Load += new System.EventHandler(this.OrderinfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btSearchitem;
        private System.Windows.Forms.Button tbSearchName;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Button btnrefresh;
    }
}