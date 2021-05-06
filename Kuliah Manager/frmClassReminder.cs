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
                    populate();
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
                var result = db.ClassTbls.SingleOrDefault(k => k.ClassName == tbMatkul.Text);
                if (result != null)
                {
                    if (tbMatkul.Text != "" && tbMeeting.Text != "" && tbPresensi.Text != "" && tbDrive.Text != "" && cbHari.Text != "" && cbHour.Text != "" && cbMin.Text != "")
                    {
                        
                        result.MeetingLink = tbMatkul.Text;
                        result.AttendanceLink = tbPresensi.Text;
                        result.DriveLink = tbDrive.Text;
                        result.Day = cbHari.Text;
                        result.Hour = cbHour.Text;
                        result.Min = cbMin.Text;
                        db.SaveChanges();
                        MessageBox.Show("Class berhasil diperbaharui");
                        
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
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbHari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.dgvClass.Rows[e.RowIndex];

                if (row.Cells != null)
                {

                    tbMatkul.Text = row.Cells["className"].Value.ToString();
                    tbMeeting.Text = row.Cells["MeetingLink"].Value.ToString();
                    tbPresensi.Text = row.Cells["AttendanceLink"].Value.ToString();
                    tbDrive.Text = row.Cells["DriveLink"].Value.ToString();
                    int i = 0;
                    if(row.Cells["Day"].Value.ToString() == "Senin") 
                    {
                        i = 0;
                    } else if (row.Cells["Day"].Value.ToString() == "Selasa")
                    {
                        i = 1;
                    } else if (row.Cells["Day"].Value.ToString() == "Rabu")
                    {
                        i = 2;
                    } else if(row.Cells["Day"].Value.ToString() == "Kamis")
                    {
                        i = 3;
                    } else if (row.Cells["Day"].Value.ToString() == "Jumat")
                    {
                        i = 4;
                    } else if (row.Cells["Day"].Value.ToString() == "Sabtu")
                    {
                        i = 5;
                    }
                    cbHari.SelectedIndex = i;
                    int hr = Int32.Parse(row.Cells["Hour"].Value.ToString());
                    int min = Int32.Parse(row.Cells["Min"].Value.ToString());
                    cbHour.SelectedIndex = hr;
                    cbMin.SelectedIndex = min / 5;
                    




                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new ReminderModel())
            {
                db.ClassTbls.RemoveRange(db.ClassTbls.Where(item => item.ClassName == tbMatkul.Text));
                db.SaveChanges();
                Clear();
                populate();
                
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
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
                using (var db = new ReminderModel())
                {
                    db.ClassTbls.AddOrUpdate(newClassTbl);
                    db.SaveChanges();
                    populate();
                    
                }
                MessageBox.Show("Done");

                    
            }catch(Exception ezpz)
            {
                MessageBox.Show(ezpz.Message);
            }

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
            populate();
        }

        private void populate()
        {
            List <Kuliah_Manager.ClassTbl> lst = ThisReminder.ClassTbls.ToList();
            dgvClass.DataSource = lst;
        }

        private void clearF_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
                tbMatkul.Text = "";
                tbMeeting.Text = "";
                tbPresensi.Text = "";
                tbDrive.Text = "";
                cbHari.Text = "";
                cbHour.Text = "";
                cbMin.Text = "";

                using (var db = new ReminderModel())
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
    }
}
