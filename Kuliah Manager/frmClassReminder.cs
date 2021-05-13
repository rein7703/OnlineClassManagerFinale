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
    public partial class frmClassReminder : Form
    {
        ClassTbl newClassTbl;
        ReminderModel2 ThisReminder;

        public enum Mode { Insert, Edit }
        Mode mode;
        public frmClassReminder()
        {
            InitializeComponent();
            mode = Mode.Insert;
            ThisReminder = new ReminderModel2();

            //DGV Properties
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        

        //Fill DGV Function
        private void FillDGView(List<ClassTbl> classTbls)
        {
            dgvClass.DataSource = classTbls;
        }
        #region ADD DATA
        //ADDING DATA - Save to DB
        private Boolean AddData(string className, string meetingLink, string attendanceLink, string driveLink, string day, string hour, string min)
        {
            try
            {
                if (ThisReminder == null)
                {
                    ThisReminder = new ReminderModel2();
                }
                var classTbl = new ClassTbl()
                {
                    ClassName = className,
                    MeetingLink = meetingLink,
                    AttendanceLink = attendanceLink,
                    DriveLink = driveLink,
                    Day = day,
                    Hour = hour,
                    Min = min,
                };
                ThisReminder.ClassTbls.Add(classTbl);

                //Persists
                ThisReminder.SaveChanges();

                //FILL DGV
                FillDGView(ThisReminder.ClassTbls.ToList());
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddData(tbMatkul.Text, tbMeeting.Text, tbPresensi.Text, tbDrive.Text, cbHari.Text, cbHour.Text, cbMin.Text))
            {
                tbMatkul.Text = "";
                tbMeeting.Text = "";
                tbPresensi.Text = "";
                tbDrive.Text = "";
                cbHari.Text = "";
                cbHour.Text = "";
                cbMin.Text = "";
            }
        }
        #endregion ADD DATA

        #region EDIT DATA
        //Edit Data
        public Boolean EditData(string className, string newMeetingLink, string newAttendanceLink, string newDriveLink, string newDay, string newHour, string newMin)
        {
            try
            {
                if (ThisReminder == null)
                {
                    ThisReminder = new ReminderModel2();
                }

                //Replace with new Data
                ClassTbl newClassTbl = ThisReminder.ClassTbls.Find(className);

                newClassTbl.ClassName = className;
                newClassTbl.MeetingLink = newMeetingLink;
                newClassTbl.AttendanceLink = newAttendanceLink;
                newClassTbl.DriveLink = newDriveLink;
                newClassTbl.Day = newDay;
                newClassTbl.Hour = newHour;
                newClassTbl.Min = newMin;

                //Save
                ThisReminder.SaveChanges();

                //Update DGV
                FillDGView(ThisReminder.ClassTbls.ToList());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            string className = dgvClass.SelectedRows[0].Cells[0].Value.ToString();
            if (EditData(className, tbMeeting.Text, tbPresensi.Text, tbDrive.Text, cbHari.Text, cbHour.Text, cbMin.Text))
            {
                tbMatkul.Text = "";
                tbMeeting.Text = "";
                tbPresensi.Text = "";
                tbDrive.Text = "";
                cbHari.Text = "";
                cbHour.Text = "";
                cbMin.Text = "";
            }
        }
        #endregion EDIT DATA

        #region RETRIEVE DATA
        //Retrieve Data
        private void retrieve()
        {
            try
            {
                if (ThisReminder == null)
                {
                    ThisReminder = new ReminderModel2();
                }

                //FILL DGV
                FillDGView(ThisReminder.ClassTbls.ToList());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion RETRIEVE DATA


        #region DELETE DATA
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new ReminderModel2())
            {
                db.ClassTbls.RemoveRange(db.ClassTbls.Where(item => item.ClassName == tbMatkul.Text));
                db.SaveChanges();
                Clear();
                retrieve(); //auto refresh table

            }
        }
        #endregion DELETE DATA

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
        private void clearF_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #region SEARCH DATA
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
                tbMatkul.Text = "";
                tbMeeting.Text = "";
                tbPresensi.Text = "";
                tbDrive.Text = "";
                cbHari.Text = "";
                cbHour.Text = "";
                cbMin.Text = "";

                using (var db = new ReminderModel2())
                {
                    var query = from classReminder in db.ClassTbls where classReminder.ClassName == tbSearch.Text select classReminder;
                    foreach (var item in query)
                    {
                        tbMatkul.Text = item.ClassName;
                        tbMeeting.Text = item.MeetingLink;
                        tbPresensi.Text = item.AttendanceLink;
                        tbDrive.Text = item.DriveLink;
                        cbHari.Text = item.Day;
                        cbHour.Text = item.Hour;
                        cbMin.Text = item.Min;
                    
                }
            }
        }
        #endregion SEARCH DATA

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void dgvClass_MouseClick(object sender, MouseEventArgs e)
        {
            tbMatkul.Text = dgvClass.SelectedRows[0].Cells[0].Value.ToString();
            tbMeeting.Text = dgvClass.SelectedRows[0].Cells[1].Value.ToString();
            tbPresensi.Text = dgvClass.SelectedRows[0].Cells[2].Value.ToString();
            tbDrive.Text = dgvClass.SelectedRows[0].Cells[3].Value.ToString();
            cbHari.Text = dgvClass.SelectedRows[0].Cells[4].Value.ToString();
            cbHour.Text = dgvClass.SelectedRows[0].Cells[5].Value.ToString();
            cbMin.Text = dgvClass.SelectedRows[0].Cells[6].Value.ToString();
        }
        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void cbHari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //LOAD FORM
        private void frmClassReminder_Load(object sender, EventArgs e)
        {
            //Untuk menampilkan/ binding data ke dgv
            dgvClass.DataSource = ThisReminder.ClassTbls.ToList();

            //jalankan timer untuk menampilkan waktu sekarang
            timer1.Start();

            //saat form diload, otomatis ambil data hour dan min dari dgv/database dan masukin ke array
            for (int i = 0; i < alarmHour.Length; i++)
            {
                alarmHour[i] = dgvClass.Rows[i].Cells[5].Value.ToString();

            }
            for (int i = 0; i < alarmMinute.Length; i++)
            {
                alarmMinute[i] = dgvClass.Rows[i].Cells[6].Value.ToString();
            }
            for (int i = 0; i < alarmDay.Length; i++)
            {
                if (dgvClass.Rows[i].Cells[4].Value.ToString() == "Minggu")
                    alarmDayEnum[i] = 0;
                else if (dgvClass.Rows[i].Cells[4].Value.ToString()== "Senin")
                    alarmDayEnum[i] = 1;
                else if (dgvClass.Rows[i].Cells[4].Value.ToString() == "Selasa")
                    alarmDayEnum[i] = 2;
                else if (dgvClass.Rows[i].Cells[4].Value.ToString() == "Rabu")
                    alarmDayEnum[i] = 3;
                else if (dgvClass.Rows[i].Cells[4].Value.ToString() == "Kamis")
                    alarmDayEnum[i] = 4;
                else if (dgvClass.Rows[i].Cells[4].Value.ToString() == "Jumat")
                    alarmDayEnum[i] = 5;
                else if (dgvClass.Rows[i].Cells[4].Value.ToString() == "Sabtu")
                    alarmDayEnum[i] = 6;
            }
        }


        ///ALARM---------------------------------------
        int hourNow, minNow, secNow;
        int dayNow;

        //kalau pakai array jadinya jumlah member arraynya harus nyesuaiin jml row dgv, jadinya mending nanti ganti List
        string[] alarmHour = new string[8];
        string[] alarmMinute = new string[8];
        string[] alarmDay = new string[8];
        int[] alarmDayEnum = new int[8];
        private Boolean popup;

        //ALARM AKAN BUNYI JIKA HARI DAN JAM SAMA
        public void RingAlarmA()
        {
            for (int i = 0; i < alarmHour.Length; i++)
            {
                popup = false;
                if (alarmHour[i] == hourNow.ToString() && alarmMinute[i] == minNow.ToString() &&
                secNow.ToString() == "0" && alarmDayEnum[i] == dayNow)
                {
                    popup = true;
                    //backslash harus diganti dengan double backslash
                    axWindowsMediaPlayer1.URL = "school_alarm.mp3";

                    //munculkan popup notif
                    Notification notif = new Notification();
                    notif.ClassNotif();

                    lblNotif.Text = ("=> Kelas " + dgvClass.Rows[i].Cells[0].Value.ToString() + " dimulai!");
                }
                else if (alarmHour[i] == hourNow.ToString() && alarmMinute[i] == (minNow+10).ToString() &&
                secNow.ToString() == "0" && alarmDayEnum[i] == dayNow)
                {
                    popup = true;
                    //backslash harus diganti dengan double backslash
                    axWindowsMediaPlayer1.URL = "school_alarm.mp3";

                    //munculkan popup notif
                    Notification notif = new Notification();
                    notif.ClassNotifPre();

                    lblNotif.Text = ("=> Kelas " + dgvClass.Rows[i].Cells[0].Value.ToString() + " dalam 10 menit!");
                }
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            Option pg = new Option();
            pg.Show();
            this.Hide();
        }

        //Shwoign current time
        private void timer1_Tick(object sender, EventArgs e)
        {
            secNow = DateTime.Now.Second;
            minNow = DateTime.Now.Minute;
            hourNow = DateTime.Now.Hour;
            dayNow = Convert.ToInt32(DateTime.Now.DayOfWeek);

            lblHour.Text = hourNow.ToString();
            lblMin.Text = minNow.ToString();
            lblSec.Text = secNow.ToString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            RingAlarmA();
         
        }
        private void btnSetAlarm_Click(object sender, EventArgs e)
        {

        }




    }
}
