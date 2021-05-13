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
    public partial class frmTaskRemin : Form
    {
        TaskTbl newTaskTbl;
        ReminderModel2 ThisReminder;

        public enum Mode { Insert, Edit }
        Mode mode;
        public frmTaskRemin()
        {
            InitializeComponent();
            mode = Mode.Insert;
            ThisReminder = new ReminderModel2();

            //DGV Properties
            dgvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public frmTaskRemin(string dueDay, string dueHour, string dueMin, string taskName, string className, string desc)
        {
            InitializeComponent();
            mode = Mode.Edit;
            newTaskTbl = new TaskTbl
            {
                DueDay = dueDay,
                DueHour = dueHour,
                DueMin = dueMin,
                TaskName = taskName,
                ClassName = className,
                Desc = desc,
            };
            cbDueDay.Text = dueDay;
            cbDueHour.Text = dueHour;
            cbDueMin.Text = dueMin;
            tbTaskName.Text = taskName;
            tbClassName.Text = className;
            tbTaskDesc.Text = desc;
        }

        //Fill DGV Function
        private void FillDGView(List<TaskTbl> TaskTbls)
        {
            dgvTask.DataSource = TaskTbls;
        }

        #region ADD DATA
        //ADDING DATA - Save to DB
        private Boolean AddData(string dueDay, string dueHour, string dueMin, string taskName, string className, string desc)
        {
            try
            {
                if (ThisReminder == null)
                {
                    ThisReminder = new ReminderModel2();
                }
                var TaskTbl = new TaskTbl()
                {
                    DueDay = dueDay,
                    DueHour = dueHour,
                    DueMin = dueMin,
                    TaskName = taskName,
                    ClassName = className,
                    Desc = desc,
                };
                ThisReminder.TaskTbls.Add(TaskTbl);

                //Persists
                ThisReminder.SaveChanges();

                //FILL DGV
                FillDGView(ThisReminder.TaskTbls.ToList());
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
            if (AddData(cbDueDay.Text, cbDueHour.Text, cbDueMin.Text, tbTaskName.Text, tbClassName.Text, tbTaskDesc.Text))
            {
                cbDueDay.Text = "";
                cbDueHour.Text = "";
                cbDueMin.Text = "";
                tbTaskName.Text = "";
                tbClassName.Text = "";
                tbTaskDesc.Text = "";
            }
        }
        #endregion ADD DATA

        #region EDIT DATA
        public Boolean EditData(string newDueDay, string newDueHour, string newDueMin, string taskName, string newClassName, string newDesc)
        {
            try
            {
                if (ThisReminder == null)
                {
                    ThisReminder = new ReminderModel2();
                }

                //Replace with new Data
                TaskTbl newTaskTbl = ThisReminder.TaskTbls.Find(taskName);

                /*newTaskTbl.TaskName = taskName;*/
                newTaskTbl.DueDay = newDueDay;
                newTaskTbl.DueHour = newDueHour;
                newTaskTbl.DueMin = newDueMin;
                newTaskTbl.ClassName = newClassName;
                newTaskTbl.Desc = newDesc;

                //Save
                ThisReminder.SaveChanges();

                //Update DGV
                FillDGView(ThisReminder.TaskTbls.ToList());
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
            string taskName = dgvTask.SelectedRows[0].Cells[3].Value.ToString();
            if (EditData(cbDueDay.Text, cbDueHour.Text, cbDueMin.Text, taskName, tbClassName.Text, tbTaskDesc.Text))
            {
                cbDueDay.Text = "";
                cbDueHour.Text = "";
                cbDueMin.Text = "";
                tbTaskName.Text = "";
                tbClassName.Text = "";
                tbTaskDesc.Text = "";
            }
        }
        #endregion EDIT DATA

        #region RETRIEVE DATA
        private void retrieve()
        {
            try
            {
                if (ThisReminder == null)
                {
                    ThisReminder = new ReminderModel2();
                }

                //FILL DGV
                FillDGView(ThisReminder.TaskTbls.ToList());
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
                db.TaskTbls.RemoveRange(db.TaskTbls.Where(item => item.TaskName == tbTaskName.Text));
                db.SaveChanges();
                Clear();
                retrieve(); //auto refresh table

            }
        }
        #endregion DELETE DATA

        //Method or Function to Clear TextBoxes
        public void Clear()
        {
            cbDueDay.Text = "";
            cbDueHour.Text = "";
            cbDueMin.Text = "";
            tbTaskName.Text = "";
            tbClassName.Text = "";
            tbTaskDesc.Text = "";
        }

        private void clearF_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #region SEARCH DATA
        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbDueDay.Text = "";
            cbDueHour.Text = "";
            cbDueMin.Text = "";
            tbTaskName.Text = "";
            tbClassName.Text = "";
            tbTaskDesc.Text = "";

            using (var db = new ReminderModel2())
            {
                var query = from taskReminder in db.TaskTbls where taskReminder.TaskName == tbSearch.Text select taskReminder;
                foreach (var item in query)
                {
                    cbDueDay.Text = item.DueDay;
                    cbDueHour.Text = item.DueHour;
                    cbDueMin.Text = item.DueMin;
                    tbTaskName.Text = item.TaskName;
                    tbClassName.Text = item.ClassName;
                    tbTaskDesc.Text = item.Desc;

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
            cbDueDay.Text = dgvTask.SelectedRows[0].Cells[0].Value.ToString();
            cbDueHour.Text = dgvTask.SelectedRows[0].Cells[1].Value.ToString();
            cbDueMin.Text = dgvTask.SelectedRows[0].Cells[2].Value.ToString();
            tbTaskName.Text = dgvTask.SelectedRows[0].Cells[3].Value.ToString();
            tbClassName.Text = dgvTask.SelectedRows[0].Cells[4].Value.ToString();
            tbTaskDesc.Text = dgvTask.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void frmTaskRemin_Load(object sender, EventArgs e)
        {
            //Untuk menampilkan/ binding data ke dgv
            dgvTask.DataSource = ThisReminder.TaskTbls.ToList();

            //jalankan timer untuk menampilkan waktu sekarang
            timer1.Start();

            //saat form diload, otomatis ambil data hour dan min dari dgv/database dan masukin ke array
            for (int i = 0; i < alarmHour.Length; i++)
            {
                alarmHour[i] = dgvTask.Rows[i].Cells[1].Value.ToString();

            }
            for (int i = 0; i < alarmMinute.Length; i++)
            {
                alarmMinute[i] = dgvTask.Rows[i].Cells[2].Value.ToString();
            }
            for (int i = 0; i < alarmDay.Length; i++)
            {
                if (dgvTask.Rows[i].Cells[0].Value.ToString() == "Minggu")
                    alarmDayEnum[i] = 0;
                else if (dgvTask.Rows[i].Cells[0].Value.ToString() == "Senin")
                    alarmDayEnum[i] = 1;
                else if (dgvTask.Rows[i].Cells[0].Value.ToString() == "Selasa")
                    alarmDayEnum[i] = 2;
                else if (dgvTask.Rows[i].Cells[0].Value.ToString() == "Rabu")
                    alarmDayEnum[i] = 3;
                else if (dgvTask.Rows[i].Cells[0].Value.ToString() == "Kamis")
                    alarmDayEnum[i] = 4;
                else if (dgvTask.Rows[i].Cells[0].Value.ToString() == "Jumat")
                    alarmDayEnum[i] = 5;
                else if (dgvTask.Rows[i].Cells[0].Value.ToString() == "Sabtu")
                    alarmDayEnum[i] = 6;
            }
        }
        ///ALARM---------------------------------------
        int hourNow, minNow, secNow;
        int dayNow;

        //kalau pakai array jadinya jumlah member arraynya harus nyesuaiin jml row dgv, jadinya mending nanti ganti List
        string[] alarmHour = new string[3];
        string[] alarmMinute = new string[3];
        string[] alarmDay = new string[3];
        int[] alarmDayEnum = new int[3];

        private Boolean popup;

        private void Back_Click(object sender, EventArgs e)
        {
            Option pg = new Option();
            pg.Show();
            this.Hide();
        }

        //ALARM AKAN BUNYI JIKA HARI DAN JAM SAMA
        public void RingAlarmA()
        {
            for (int i = 0; i < alarmHour.Length; i++)
            {
                popup = false;
                //1. notifikasi tepat sesuai deadline tertulis
                if (alarmHour[i] == hourNow.ToString() && alarmMinute[i] == minNow.ToString() &&
                secNow.ToString() == "0" && alarmDayEnum[i] == dayNow)
                {
                    popup = true;
                    //backslash harus diganti dengan double backslash
                    axWindowsMediaPlayer1.URL = "school_alarm.mp3";

                    //munculkan popup notif
                    Notification notif = new Notification();
                    notif.TaskNotif();

                    lblNotif.Text = ("=> DEADLINE TUGAS " + dgvTask.Rows[i].Cells[3].Value.ToString());
                }
                //2. Notifikasi 1 hari sebelum deadline tertulis
                else if (alarmHour[i] == (hourNow).ToString() && alarmMinute[i] == (minNow).ToString() &&
                secNow.ToString() == "0" && (alarmDayEnum[i]-1) == dayNow)
                {
                    popup = true;
                    //backslash harus diganti dengan double backslash
                    axWindowsMediaPlayer1.URL = "school_alarm.mp3";

                    //munculkan popup notif
                    Notification notif = new Notification();
                    notif.TaskNotifPre();

                    lblNotif.Text = ("=> Tugas yang akan datang adalah " + dgvTask.Rows[i].Cells[3].Value.ToString());
                }
                
            }

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
    }
}
