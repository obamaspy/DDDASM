using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASMDDD
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSMDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.aSMDataSet.Customers);
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm2 = new Dashboard();
            frm2.ShowDialog();
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txbname.Text.ToLower();
                foreach (DataGridViewRow row in dgvcustomer.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        return;
                    }
                }

                MessageBox.Show("No customer found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching customer: " + ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string customerid = txbcustomerid.Text;
            string name = txbname.Text;
            string phone = txbphone.Text;
            string email = txbemail.Text;
            string address = txbaddress.Text;
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            String sql = "";
            sql = "Insert into Customers (CustomerID, Name, Phone, Email, Address) values(@customerid, @name, @phone, @email, @address)";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.Add("@customerid", SqlDbType.Int);
            cmd.Parameters["@customerid"].Value = customerid;

            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters["@name"].Value = name;

            cmd.Parameters.Add("@phone", SqlDbType.VarChar);
            cmd.Parameters["@phone"].Value = phone;

            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = email;

            cmd.Parameters.Add("@address", SqlDbType.VarChar);
            cmd.Parameters["@address"].Value = address;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successfully.");
            cnn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            string deleteQuery = "DELETE FROM Customers WHERE CustomerID= @customerid";
            SqlCommand cmd = new SqlCommand(deleteQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@customerid", txbcustomerid.Text);
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
            string updateQuery = "UPDATE Customers SET Name= @name, Phone= @phone, Email= @email, Address= @address WHERE CustomerID= @customerid";
            SqlCommand cmd = new SqlCommand(updateQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@customerid", txbcustomerid.Text);
            cmd.Parameters.AddWithValue("@name", txbname.Text);
            cmd.Parameters.AddWithValue("@phone", txbphone.Text);
            cmd.Parameters.AddWithValue("@email", txbemail.Text);
            cmd.Parameters.AddWithValue("@address", txbaddress.Text);
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
                string selectQuery = "Customers";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvcustomer.DataSource = dataTable;
                }

            }
        }
    }
}
