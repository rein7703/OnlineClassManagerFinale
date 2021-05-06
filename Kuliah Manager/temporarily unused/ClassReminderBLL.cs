using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    class ClassReminderBLL : ReminderBLL
    {
        private string meetingLink;
        private string attendanceLink;
        private string driveLink;
        public string MeetingLink { get; set; }
        public string AttendanceLink { get; set; }
        public string DriveLink { get; set; }

        public ClassReminderBLL(string mes = "Jangan lupa masuk kelas kamu masih bodoh" ) : base(mes)
        {
            this.finalMsg = Pesan + "\n" + MeetingLink;
        }

        public override void ShowMes()
        {
            finalMsg = "[CLASS REMINDER]";
            MessageBox.Show(finalMsg);
        }
    }
}
