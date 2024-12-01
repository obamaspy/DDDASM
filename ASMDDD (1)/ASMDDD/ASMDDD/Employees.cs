using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASMDDD
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSMDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.aSMDataSet.Employees);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string employeeid = txbemployeeid.Text;
            string name = txbname.Text;
            string phone = txbphone.Text;
            string email = txbemail.Text;
            string position = txbposition.Text;
            string salary = txbsalary.Text;
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            String sql = "";
            sql = "Insert into Employees (EmployeeID, Name, Phone, Email, Position, Salary) values(@employeeid, @name, @phone, @email, @position, @salary)";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.Add("@employeeid", SqlDbType.Int);
            cmd.Parameters["@employeeid"].Value = employeeid;

            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters["@name"].Value = name;

            cmd.Parameters.Add("@phone", SqlDbType.VarChar);
            cmd.Parameters["@phone"].Value = phone;

            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = email;

            cmd.Parameters.Add("@position", SqlDbType.VarChar);
            cmd.Parameters["@position"].Value = position;

            cmd.Parameters.Add("@salary", SqlDbType.VarChar);
            cmd.Parameters["@salary"].Value = salary;

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
            string deleteQuery = "DELETE FROM Employees WHERE EmployeeID= @employeeid";
            SqlCommand cmd = new SqlCommand(deleteQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@employeeid", txbemployeeid.Text);
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
            string updateQuery = "UPDATE Employees SET Name= @name, Phone= @phone, Email= @email, Position= @position, Salary= @salary WHERE EmployeeID= @employeeid";
            SqlCommand cmd = new SqlCommand(updateQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@employeeid", txbemployeeid.Text);
            cmd.Parameters.AddWithValue("@name", txbname.Text);
            cmd.Parameters.AddWithValue("@phone", txbphone.Text);
            cmd.Parameters.AddWithValue("@email", txbemail.Text);
            cmd.Parameters.AddWithValue("@position", txbposition.Text);
            cmd.Parameters.AddWithValue("@salary", txbsalary.Text);
            int count = cmd.ExecuteNonQuery();
            cnn.Close();
            if (count > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txbname.Text.Trim().ToLower();
                bool found = false;

                foreach (DataGridViewRow row in dgvemployee.Rows)
                {
                    if (row.Cells["Name"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        row.Selected = true;
                        found = true;
                        dgvemployee.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("No employee found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching employee: " + ex.Message);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "Employees";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvemployee.DataSource = dataTable;
                }

            }
        }
    }
}
