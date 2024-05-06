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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace my_system
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@" server= . ; database= mysystem ;integrated security =True");


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            conn.Open();



            string username, user_password;
            username = username_textBox.Text.ToString();
            user_password = password_textBox.Text.ToString();

            string addadminquery = " insert_staff_data '" + username + "','" + user_password + "' ";
            SqlCommand addadmincomm = new SqlCommand(addadminquery, conn);
            addadmincomm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("added admin sussesfuly");


        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
