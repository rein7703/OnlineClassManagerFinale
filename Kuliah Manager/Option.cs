using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

       

        private void Class_Click(object sender, EventArgs e)
        {
            frmClassReminder pg = new frmClassReminder();
            pg.Show();
            this.Hide(); 
        }

        private void Task_Click(object sender, EventArgs e)
        {
            frmTaskRemin pg = new frmTaskRemin();
            pg.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
