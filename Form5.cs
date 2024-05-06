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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@" server= . ; database= mysystem ;integrated security =True");

        private void addclient_Click(object sender, EventArgs e)
        {
            conn.Open();

            string customer_id, first_name, last_name, phone, email, street;
            customer_id = tbcustomer_id.Text;
            first_name = tbfirst_name.Text;
            last_name = tblast_name.Text;
            phone = tbphone.Text;
            email = tbemail.Text;
            street = tbemail.Text;
           
            //string updataclientquery = " UPDATE customers SET  first_name='" + tbfirst_name.Text + "',last_name='" + tblast_name.Text + "',phone='" + tbphone.Text + "',email='" + tbemail.Text + "',street='" + tbstreet.Text + "' where customer_id =  '" + tbcustomer_id.Text + "'";
            string updataclientquery = " update_customer_data  '" + tbcustomer_id.Text + "' ,'" + tbfirst_name.Text + "','" + tblast_name.Text + "','" + tbphone.Text + "','" + tbemail.Text + "','" + tbstreet.Text + "'   ";

            SqlCommand command = new SqlCommand(updataclientquery, conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("good");

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbfirst_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void tbstreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblast_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcustomer_id_TextChanged(object sender, EventArgs e)
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
