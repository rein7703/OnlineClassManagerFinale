/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuliah_Manager
{
    class ClassBLL
    {
        private string className;
        private string day;
        private string time;
        private string meetingLink;
        private string attendanceLink;
        private bool validation;
        private string driveLink;
    
        public string ClassName
        {
            get;
            set;
        }
        public string Day
        {
            get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public string MeetingLink
        {
            get;
            set;
        }
        public string AttendanceLink
        {
            get;
            set;
        }
        public string DriveLink
        {
            get;
            set;
        }
        public bool Validation
        {
            get;
            set;
        }
        public void IsValid(bool validation)
        {
            if(validation == true)
            {
                //execute database ADD fuction
            }
            else
            {
                //Show MessageBox
            }
        }
        public ClassBLL(string ClassName, string Day, string Time, string MeetingLink, string AttendanceLink)
        {
            this.ClassName = ClassName;
            this.Day = Day;
            this.Time = Time;
            this.MeetingLink = MeetingLink;
            this.AttendanceLink = AttendanceLink;
        }

        public ClassBLL()
        {
        }

        public void DeleteClass(bool delClass)
        {
            if (delClass == true)
            {
                //Delete data in the database
                //Sementara, memakai dummy codes berikut
                ClassName = "";
                Day = "";
                MeetingLink = "";
                AttendanceLink = "";

            }
        }

    }
}
*/