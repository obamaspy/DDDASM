using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMDDD
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products frm2 = new Products();
            frm2.ShowDialog();
        }

        private void btnemployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees frm2 = new Employees();
            frm2.ShowDialog();
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers frm2 = new Customers();
            frm2.ShowDialog();
        }

        private void btnstatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics frm2 = new Statistics();
            frm2.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm2 = new Login();
            frm2.ShowDialog();
        }
    }
}
