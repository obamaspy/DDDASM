using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASMDDD
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        SqlCommand cmd;

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aSMDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.aSMDataSet.Products);
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            dtpublish.Format = DateTimePickerFormat.Custom;
            dtpublish.CustomFormat = "";
            timer1.Start();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm2 = new Dashboard();
            frm2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String productid = txbproductid.Text;
            String productname = txbproductname.Text;
            String genre = txbgenre.Text;
            String author = txbauthor.Text;
            String publisher = txbpublisher.Text;
            String quantity = txbquantity.Text;
            String price = txbprice.Text;
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            String sql = "";
            sql = "Insert into Products (ProductID, ProductName, Genre, Author, Publisher, PublishedDate, Quantity, Price) values(@productid, @productname, @genre, @author, @publisher, @publisheddate, @quantity, @price)";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.Add("@productid", SqlDbType.Int).Value = Convert.ToInt32(productid);
            cmd.Parameters["@productid"].Value = productid;

            cmd.Parameters.Add("@productname", SqlDbType.VarChar);
            cmd.Parameters["@productname"].Value = productname;

            cmd.Parameters.Add("@genre", SqlDbType.VarChar);
            cmd.Parameters["@genre"].Value = genre;

            cmd.Parameters.Add("@author", SqlDbType.VarChar);
            cmd.Parameters["@author"].Value = author;

            cmd.Parameters.Add("@publisher", SqlDbType.VarChar);
            cmd.Parameters["@publisher"].Value = publisher;

            cmd.Parameters.Add("@publisheddate", SqlDbType.Date).Value = dtpublish.Value.Date;
            dtpublish.CustomFormat = "MM-dd-yyyy";

            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(quantity);
            cmd.Parameters["@quantity"].Value = quantity;

            cmd.Parameters.Add("@price", SqlDbType.Decimal);
            cmd.Parameters["@price"].Value = price;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successfully.");
            cnn.Close();
        }
        
        private void productsToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            string updateQuery = "UPDATE Products SET ProductName= @productname, Genre= @genre, Author= @author, Publisher= @publisher, Publisheddate= @publisheddate, Quantity= @quantity, Price= @price WHERE ProductID= @productid";
            SqlCommand cmd = new SqlCommand(updateQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@productid", txbproductid.Text);
            cmd.Parameters.AddWithValue("@productname", txbproductname.Text);
            cmd.Parameters.AddWithValue("@genre", txbgenre.Text);
            cmd.Parameters.AddWithValue("@author", txbauthor.Text);
            cmd.Parameters.AddWithValue("@publisher", txbpublisher.Text);
            cmd.Parameters.AddWithValue("@publisheddate", SqlDbType.Date).Value = dtpublish.Value.Date;
            dtpublish.CustomFormat = "MM-dd-yyyy";
            cmd.Parameters.AddWithValue("@quantity", txbquantity.Text);
            cmd.Parameters.AddWithValue("@price", txbprice.Text);
            int count = cmd.ExecuteNonQuery();
            cnn.Close();
            if (count > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            string deleteQuery = "DELETE FROM Products WHERE ProductID= @productid";
            SqlCommand cmd = new SqlCommand(deleteQuery, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@productid", txbproductid.Text);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        private void btnrefresh_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
