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

namespace Kuliah_Manager
{
    public partial class frmClassReminder : Form
    {
        public frmClassReminder()
        {
            InitializeComponent();
        }
        //create object for ClassBLL and ClassDAL
        ClassReminderBLL bll = new ClassReminderBLL();
        ClassReminderDAL dal = new ClassReminderDAL();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //step 1: Get the values from UI
            bll.ClassName = tbMatkul.Text;
            bll.MeetingLink = tbMeeting.Text;
            bll.AttendanceLink = tbPresensi.Text;
            bll.DriveLink = tbDrive.Text;
            bll.Day = cbHari.Text;
            bll.Hour = cbHour.Text;
            bll.Min = cbMin.Text;

            //step 2 : Adding the values from UI to the database
            //create a bool variable to check wether the data is inserted succesfulllly or not
            bool success = dal.Insert(bll);

            //step 3: check wether the data is inserted succesfully or not 
            if (success == true)
            {
                //data or user added succesfully
                MessageBox.Show("New Class Added Succesfully");

                //Display the user in DataGrid View
                DataTable dt = dal.Select();
                dgvClass.DataSource = dt;

                //Clear TextBoxes
                Clear();
            }
            else
            {
                //failed to add user
                MessageBox.Show("Failed to add new class");
            }
        }

        private void cbHari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //https://stackoverflow.com/questions/35250593/selectedrow-error-datagridview-error

            int i = e.RowIndex;
            DataGridViewRow row = dgvClass.Rows[i];
            tbMatkul.Text = row.Cells[0].Value.ToString();
            tbMeeting.Text = row.Cells[1].Value.ToString();
            tbPresensi.Text = row.Cells[2].Value.ToString();
            tbDrive.Text = row.Cells[3].Value.ToString();
            cbHari.SelectedValue = row.Cells[4].Value.ToString();
            cbHour.SelectedValue = row.Cells[5].Value.ToString();
            cbMin.SelectedValue = row.Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Step 1: Get the UserID from Text Box to Delete the User
            bll.ClassName = tbMatkul.Text;

            //Step Create the Boolean value to check whether the user deleted or not
            bool success = dal.Delete(bll);

            //Let's check whteher the user is Deleted or Not
            if (success == true)
            {
                //User Deleted Successfully
                MessageBox.Show("Class Deleted Successfully.");

                //Refresh DataGrid View
                DataTable dt = dal.Select();
                dgvClass.DataSource = dt;

                //Clear the TextBoxes
                Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //blm
        }

        //Method or Function to Clear TextBoxes
        public void Clear()
        {
            tbMatkul.Text = "";
            tbMeeting.Text = "";
            tbPresensi.Text = "";
            tbDrive.Text = "";
            cbHari.Text = "";
            cbHour.Text = "";
            cbMin.Text = "";
        }

        private void frmClassReminder_Load(object sender, EventArgs e)
        {
            //Menampilkan Classes di DGV ketika di-load
            DataTable dt = dal.Select();
            dgvClass.DataSource = dt;
        }
    }
}
