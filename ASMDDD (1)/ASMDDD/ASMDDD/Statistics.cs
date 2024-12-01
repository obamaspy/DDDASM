using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASMDDD
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSMDataSet1.Statistic' table. You can move, or remove it, as needed.
            this.statisticTableAdapter.Fill(this.aSMDataSet1.Statistic);
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            dtsaledate.Format = DateTimePickerFormat.Custom;
            dtsaledate.CustomFormat = "";

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm2 = new Dashboard();
            frm2.ShowDialog();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string saleid = txbsaleid.Text;
            string employeeid = txbemployeeid.Text;
            string productid = txbproductid.Text;
            string customerid = txbcustomerid.Text;
            string quantity = txbquantity.Text;
            string revenue = txbrevenue.Text;
            string payment = txbpayment.Text;
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            String sql = "";
            sql = "Insert into Statistic (SaleID, EmployeeID, ProductID, CustomerID, SaleDate, Quantity, Revenue, Payment) values(@saleid, @employeeid, @productid, @customerid, @saledate, @quantity, @revenue, @payment)";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.Add("@saleid", SqlDbType.Int);
            cmd.Parameters["@saleid"].Value = saleid;

            cmd.Parameters.Add("@employeeid", SqlDbType.Int);
            cmd.Parameters["@employeeid"].Value = employeeid;

            cmd.Parameters.Add("@productid", SqlDbType.Int);
            cmd.Parameters["@productid"].Value = productid;

            cmd.Parameters.Add("@customerid", SqlDbType.Int);
            cmd.Parameters["@customerid"].Value = customerid;

            cmd.Parameters.Add("@saledate", SqlDbType.Date).Value = dtsaledate.Value.Date;
            dtsaledate.CustomFormat = "MM-dd-yyyy";

            cmd.Parameters.Add("@quantity", SqlDbType.VarChar);
            cmd.Parameters["@quantity"].Value = quantity;

            cmd.Parameters.Add("@revenue", SqlDbType.VarChar);
            cmd.Parameters["@revenue"].Value = revenue;

            cmd.Parameters.Add("@payment", SqlDbType.VarChar);
            cmd.Parameters["@payment"].Value = payment;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successfully.");
            cnn.Close();
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgvstatistic.DataSource = bs;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            string deleteQuery = "DELETE FROM Statistic WHERE SaleID= @saleid";
            SqlCommand cmd = new SqlCommand(deleteQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@saleid", txbsaleid.Text);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            string updateQuery = "UPDATE Statistic SET EmployeeID= @employeeid, ProductID= @productid, CustomerID= @customerid, SaleDate= @saledate, Quantity= @quantity, Revenue= @revenue, Payment= @payment WHERE SaleID= @saleid";
            SqlCommand cmd = new SqlCommand(updateQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@saleid", txbsaleid.Text);
            cmd.Parameters.AddWithValue("@employeeid", txbemployeeid.Text);
            cmd.Parameters.AddWithValue("@productid", txbproductid.Text);
            cmd.Parameters.AddWithValue("@customerid", txbcustomerid.Text);
            cmd.Parameters.AddWithValue("@saledate", SqlDbType.Date).Value = dtsaledate.Value.Date;
            dtsaledate.CustomFormat = "MM-dd-yyyy";
            cmd.Parameters.AddWithValue("@quantity", txbquantity.Text);
            cmd.Parameters.AddWithValue("@revenue", txbrevenue.Text);
            cmd.Parameters.AddWithValue("@payment", txbpayment.Text);
            int count = cmd.ExecuteNonQuery();
            cnn.Close();
            if (count > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
        }


        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "Statistic";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvstatistic.DataSource = dataTable;
                }

            }
        }
    }
}
