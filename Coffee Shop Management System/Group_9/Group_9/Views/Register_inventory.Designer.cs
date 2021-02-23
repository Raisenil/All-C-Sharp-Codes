namespace Group_9.Views
{
    partial class Register_inventory
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterBt
            // 
            this.RegisterBt.Location = new System.Drawing.Point(217, 140);
            this.RegisterBt.Name = "RegisterBt";
            this.RegisterBt.Size = new System.Drawing.Size(100, 30);
            this.RegisterBt.TabIndex = 29;
            this.RegisterBt.Text = "Add";
            this.RegisterBt.UseVisualStyleBackColor = true;
            this.RegisterBt.Click += new System.EventHandler(this.RegisterBt_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(123, 68);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(194, 20);
            this.NameBox.TabIndex = 27;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(123, 101);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(194, 20);
            this.PriceBox.TabIndex = 28;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 66);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Price";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BackColor = System.Drawing.Color.White;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(134, 26);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(104, 25);
            this.RegisterLabel.TabIndex = 19;
            this.RegisterLabel.Text = "Add Item";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Register_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 214);
            this.Controls.Add(this.RegisterBt);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterLabel);
            this.Name = "Register_inventory";
            this.Text = "Register_inventory";
            this.Load += new System.EventHandler(this.Register_inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBt;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RegisterLabel;
    }
}