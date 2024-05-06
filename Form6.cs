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

namespace my_system
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@" server= . ; database= mysystem ;integrated security =True");

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteclient_Click(object sender, EventArgs e)
        {
            conn.Open();
            string customer_id;
            customer_id = tbcustomer_id.Text;

            string deleteclient = " delete_customer_data  '" + tbcustomer_id.Text + "'";
            SqlCommand command = new SqlCommand(deleteclient, conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("good");


        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();

            form.ShowDialog(); 
        }
    }
}
