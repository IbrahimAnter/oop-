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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@" server= . ; database= mysystem ;integrated security =True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = username_textBox.Text.ToString();
            user_password = password_textBox.Text.ToString();
            try
            {
                // string query = "select * from staff_data where username='" + username + "' and password='" + user_password + "'";
                 string query = "exec dbo.login_staff_data '" + username + "', '" + user_password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = username_textBox.Text;
                    user_password = password_textBox.Text;
                    MessageBox.Show("welcome in my system");
                    this.Hide();
                    Form2 newform = new Form2();
                    newform.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void login_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {

        }
    }
}

