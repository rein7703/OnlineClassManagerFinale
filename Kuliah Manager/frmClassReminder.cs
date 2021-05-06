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
        ClassTbl newClassTbl;
        ReminderModel ThisReminder;

        public enum Mode { Insert, Edit }
        Mode mode;
        public frmClassReminder()
        {
            InitializeComponent();
            mode = Mode.Insert;
            ThisReminder = new ReminderModel();
        }
        public frmClassReminder(string className, string meetingLink, string attendanceLink, string driveLink, string day, string hour, string min)
        {
            InitializeComponent();
            mode = Mode.Edit;
            newClassTbl = new ClassTbl
            {
                ClassName = className,
                MeetingLink = meetingLink,
                AttendanceLink = attendanceLink,
                DriveLink = driveLink,
                Day = day,
                Hour = hour,
                Min = min,
            };
            tbMatkul.Text = className;
            tbMeeting.Text = meetingLink;
            tbPresensi.Text = attendanceLink;
            tbDrive.Text = driveLink;
            cbHari.Text = day;
            cbHour.Text = hour;
            cbMin.Text = min;
        }

        private void AddData()
        {
            if (tbMatkul.Text != "" && tbMeeting.Text != "" && tbPresensi.Text != "" && tbDrive.Text != "" && cbHari.Text != "" && cbHour.Text != "" && cbMin.Text != "")
            {
                using (var db = new ReminderModel())
                {
                    newClassTbl = new ClassTbl
                    {
                        ClassName = tbMatkul.Text,
                        MeetingLink = tbMeeting.Text,
                        AttendanceLink = tbPresensi.Text,
                        DriveLink = tbDrive.Text,
                        Day = cbHari.Text,
                        Hour = cbHour.Text,
                        Min = cbMin.Text,
                    };
                    db.ClassTbls.Add(newClassTbl);
                    db.SaveChanges();
                    MessageBox.Show("Class Ditambahkan");
                    
                }
            }
            else
            {
                MessageBox.Show("Semua data harus diisi!");
            }
        }
        public void EditData()
        {
            using (var db = new ReminderModel())
            {
                var result = db.ClassTbls.SingleOrDefault(k => k.ClassName == newClassTbl.ClassName);
                if (result != null)
                {
                    if (tbMatkul.Text != "" && tbMeeting.Text != "" && tbPresensi.Text != "" && tbDrive.Text != "" && cbHari.Text != "" && cbHour.Text != "" && cbMin.Text != "")
                    {
                        result.ClassName = tbMatkul.Text;
                        result.MeetingLink = tbMatkul.Text;
                        result.AttendanceLink = tbPresensi.Text;
                        result.DriveLink = tbDrive.Text;
                        result.Day = cbHari.Text;
                        result.Hour = cbHour.Text;
                        result.Min = cbMin.Text;
                        db.SaveChanges();
                        MessageBox.Show("Class berhasil diperbaharui");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Semua data harus diisi");
                    }
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                AddData();
            else if (mode == Mode.Edit)
                EditData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbHari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new ReminderModel())
            {
                db.ClassTbls.RemoveRange(db.ClassTbls.Where(item => item.ClassName == tbMatkul.Text));
                db.SaveChanges();
                Clear();
                /*lblNama.Text = "-";
                lblAlamat.Text = "-";
                lblNomor.Text = "-";
                lblEmail.Text = "-";
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;*/
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ThisReminder.SaveChanges();
            MessageBox.Show("Data Updated");
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
            //Untuk menampilkan/ binding data ke dgv
            dgvClass.DataSource = ThisReminder.ClassTbls.ToList();
        }
    }
}
