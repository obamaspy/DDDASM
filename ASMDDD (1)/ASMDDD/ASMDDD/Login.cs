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

namespace ASMDDD
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string query = "SELECT COUNT(*) FROM Login WHERE Username=@username AND Password=@password";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@username", txbusername.Text);
            cmd.Parameters.AddWithValue("@password", txbpassword.Text);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Welcome back!");
                this.Hide();
                Dashboard frm2 = new Dashboard();
                frm2.ShowDialog();
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btncreateacc_Click(object sender, EventArgs e)
        {
            String connectionString;
            SqlConnection cnn;
            connectionString = (@"Data Source=DESKTOP-OE5F0A9;" + "Initial Catalog=ASM;" + "Integrated Security=True;");
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string insertQuery = "INSERT into Login (Username, Password) VALUES(@username, @password)";
            SqlCommand cmd = new SqlCommand(insertQuery, cnn);
            cmd.Parameters.AddWithValue("@username", txbusername.Text);
            cmd.Parameters.AddWithValue("@password", txbpassword.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Account created successfully");
            cnn.Close();
        }
    }
}
