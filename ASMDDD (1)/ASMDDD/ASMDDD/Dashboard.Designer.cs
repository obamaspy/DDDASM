namespace ASMDDD
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btnemployees = new System.Windows.Forms.Button();
            this.btncustomers = new System.Windows.Forms.Button();
            this.btnstatistics = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(405, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // btnproducts
            // 
            this.btnproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnproducts.Location = new System.Drawing.Point(119, 242);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(126, 62);
            this.btnproducts.TabIndex = 1;
            this.btnproducts.Text = "Products";
            this.btnproducts.UseVisualStyleBackColor = true;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // btnemployees
            // 
            this.btnemployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnemployees.Location = new System.Drawing.Point(322, 242);
            this.btnemployees.Name = "btnemployees";
            this.btnemployees.Size = new System.Drawing.Size(126, 62);
            this.btnemployees.TabIndex = 2;
            this.btnemployees.Text = "Employees";
            this.btnemployees.UseVisualStyleBackColor = true;
            this.btnemployees.Click += new System.EventHandler(this.btnemployees_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncustomers.Location = new System.Drawing.Point(525, 242);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(126, 62);
            this.btncustomers.TabIndex = 3;
            this.btncustomers.Text = "Customers";
            this.btncustomers.UseVisualStyleBackColor = true;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // btnstatistics
            // 
            this.btnstatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnstatistics.Location = new System.Drawing.Point(723, 242);
            this.btnstatistics.Name = "btnstatistics";
            this.btnstatistics.Size = new System.Drawing.Size(126, 62);
            this.btnstatistics.TabIndex = 4;
            this.btnstatistics.Text = "Statistics";
            this.btnstatistics.UseVisualStyleBackColor = true;
            this.btnstatistics.Click += new System.EventHandler(this.btnstatistics_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnlogout.Location = new System.Drawing.Point(821, 41);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(95, 46);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 611);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnstatistics);
            this.Controls.Add(this.btncustomers);
            this.Controls.Add(this.btnemployees);
            this.Controls.Add(this.btnproducts);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnemployees;
        private System.Windows.Forms.Button btncustomers;
        private System.Windows.Forms.Button btnstatistics;
        private System.Windows.Forms.Button btnlogout;
    }
}