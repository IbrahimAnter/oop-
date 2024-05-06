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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@" server= . ; database= mysystem ;integrated security =True");

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 newform = new Form3();
            newform.ShowDialog();

        }

        private void add_client_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newform = new Form4();
            newform.ShowDialog();
        }

        private void Exit_1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delete_client_1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form form = new Form6();
            form.ShowDialog();
        }

        private void Update_Client_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form5();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
          
            form.ShowDialog();
           
        }
    }
}
