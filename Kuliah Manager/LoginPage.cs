using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity.Migrations;
using Tulpep.NotificationWindow;


namespace Kuliah_Manager
{
    public partial class LoginPage : Form
    {
       
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}

        private void label2_Click(object sender, EventArgs e){}

        private void login_Click(object sender, EventArgs e)
        {
            User first = new User();
            first.Username = "0User";
            first.Password = "0Pass";

            User second = new User();
            second.Username = "1User";
            second.Password = "1Pass";
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                if((textBox1.Text == first.Username && textBox2.Text == first.Password) || (textBox1.Text == second.Username && textBox2.Text == second.Password))
                {
                    Option pg = new Option();
                    pg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                
            }
            else
            {
                MessageBox.Show("Pastikan sudah mengisi kolom username dan password dengan benar");
            }
         }
    }
}
    

