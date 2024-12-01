namespace ASMDDD
{
    partial class Statistics
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
            this.components = new System.ComponentModel.Container();
            this.dgvstatistic = new System.Windows.Forms.DataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSMDataSet1 = new ASMDDD.ASMDataSet1();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbsaleid = new System.Windows.Forms.TextBox();
            this.txbemployeeid = new System.Windows.Forms.TextBox();
            this.txbproductid = new System.Windows.Forms.TextBox();
            this.txbcustomerid = new System.Windows.Forms.TextBox();
            this.txbquantity = new System.Windows.Forms.TextBox();
            this.txbrevenue = new System.Windows.Forms.TextBox();
            this.txbpayment = new System.Windows.Forms.TextBox();
            this.dtsaledate = new System.Windows.Forms.DateTimePicker();
            this.statisticTableAdapter = new ASMDDD.ASMDataSet1TableAdapters.StatisticTableAdapter();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSMDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstatistic
            // 
            this.dgvstatistic.AutoGenerateColumns = false;
            this.dgvstatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.revenueDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn});
            this.dgvstatistic.DataSource = this.statisticBindingSource;
            this.dgvstatistic.Location = new System.Drawing.Point(76, 342);
            this.dgvstatistic.Margin = new System.Windows.Forms.Padding(2);
            this.dgvstatistic.Name = "dgvstatistic";
            this.dgvstatistic.RowHeadersWidth = 62;
            this.dgvstatistic.RowTemplate.Height = 28;
            this.dgvstatistic.Size = new System.Drawing.Size(955, 250);
            this.dgvstatistic.TabIndex = 0;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // revenueDataGridViewTextBoxColumn
            // 
            this.revenueDataGridViewTextBoxColumn.DataPropertyName = "Revenue";
            this.revenueDataGridViewTextBoxColumn.HeaderText = "Revenue";
            this.revenueDataGridViewTextBoxColumn.Name = "revenueDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // statisticBindingSource
            // 
            this.statisticBindingSource.DataMember = "Statistic";
            this.statisticBindingSource.DataSource = this.aSMDataSet1;
            // 
            // aSMDataSet1
            // 
            this.aSMDataSet1.DataSetName = "ASMDataSet1";
            this.aSMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnback.Location = new System.Drawing.Point(924, 20);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 49);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(906, 187);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(109, 39);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(742, 259);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 37);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(742, 189);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sale ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sale Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity Sold";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Revenue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Payment Method";
            // 
            // txbsaleid
            // 
            this.txbsaleid.Location = new System.Drawing.Point(184, 67);
            this.txbsaleid.Name = "txbsaleid";
            this.txbsaleid.Size = new System.Drawing.Size(92, 20);
            this.txbsaleid.TabIndex = 18;
            // 
            // txbemployeeid
            // 
            this.txbemployeeid.Location = new System.Drawing.Point(184, 131);
            this.txbemployeeid.Name = "txbemployeeid";
            this.txbemployeeid.Size = new System.Drawing.Size(92, 20);
            this.txbemployeeid.TabIndex = 19;
            // 
            // txbproductid
            // 
            this.txbproductid.Location = new System.Drawing.Point(184, 198);
            this.txbproductid.Name = "txbproductid";
            this.txbproductid.Size = new System.Drawing.Size(92, 20);
            this.txbproductid.TabIndex = 20;
            // 
            // txbcustomerid
            // 
            this.txbcustomerid.Location = new System.Drawing.Point(184, 260);
            this.txbcustomerid.Name = "txbcustomerid";
            this.txbcustomerid.Size = new System.Drawing.Size(92, 20);
            this.txbcustomerid.TabIndex = 21;
            // 
            // txbquantity
            // 
            this.txbquantity.Location = new System.Drawing.Point(450, 131);
            this.txbquantity.Name = "txbquantity";
            this.txbquantity.Size = new System.Drawing.Size(179, 20);
            this.txbquantity.TabIndex = 23;
            // 
            // txbrevenue
            // 
            this.txbrevenue.Location = new System.Drawing.Point(450, 198);
            this.txbrevenue.Name = "txbrevenue";
            this.txbrevenue.Size = new System.Drawing.Size(179, 20);
            this.txbrevenue.TabIndex = 24;
            // 
            // txbpayment
            // 
            this.txbpayment.Location = new System.Drawing.Point(450, 260);
            this.txbpayment.Name = "txbpayment";
            this.txbpayment.Size = new System.Drawing.Size(179, 20);
            this.txbpayment.TabIndex = 25;
            // 
            // dtsaledate
            // 
            this.dtsaledate.Location = new System.Drawing.Point(450, 64);
            this.dtsaledate.Name = "dtsaledate";
            this.dtsaledate.Size = new System.Drawing.Size(179, 20);
            this.dtsaledate.TabIndex = 26;
            // 
            // statisticTableAdapter
            // 
            this.statisticTableAdapter.ClearBeforeFill = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(906, 260);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(110, 37);
            this.btnrefresh.TabIndex = 27;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 603);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dtsaledate);
            this.Controls.Add(this.txbpayment);
            this.Controls.Add(this.txbrevenue);
            this.Controls.Add(this.txbquantity);
            this.Controls.Add(this.txbcustomerid);
            this.Controls.Add(this.txbproductid);
            this.Controls.Add(this.txbemployeeid);
            this.Controls.Add(this.txbsaleid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvstatistic);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSMDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstatistic;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbsaleid;
        private System.Windows.Forms.TextBox txbemployeeid;
        private System.Windows.Forms.TextBox txbproductid;
        private System.Windows.Forms.TextBox txbcustomerid;
        private System.Windows.Forms.TextBox txbquantity;
        private System.Windows.Forms.TextBox txbrevenue;
        private System.Windows.Forms.TextBox txbpayment;
        private System.Windows.Forms.DateTimePicker dtsaledate;
        private ASMDataSet1 aSMDataSet1;
        private System.Windows.Forms.BindingSource statisticBindingSource;
        private ASMDataSet1TableAdapters.StatisticTableAdapter statisticTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnrefresh;
    }
}