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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@" server= . ; database= mysystem ;integrated security =True");


        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string customer_id, first_name, last_name, phone, email, street;
            customer_id = tbcustomer_id.Text;
            first_name = tbfirst_name.Text;
            last_name = tblast_name.Text;
            phone = tbphone.Text;
            email = tbfirst_name.Text;
            street = tbstreet.Text;
            string addclientquery = "add_customer_data '" + customer_id + "','" + first_name + "','" + last_name + "','" + phone + "','" + email + "','" + street + "'";
            SqlCommand addclientcomm = new SqlCommand(addclientquery, conn);
            addclientcomm.ExecuteNonQuery();
            MessageBox.Show("good");
            conn.Close();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
       
            
        }

        private void tbfirst_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblast_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbstreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void street_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void last_name_Click(object sender, EventArgs e)
        {

        }

        private void first_name_Click(object sender, EventArgs e)
        {

        }

        private void customer_id_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();

            form.ShowDialog();
        }
    }
}
