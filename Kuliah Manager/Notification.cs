using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    class Notification
    {
        //Notifikasi tepat sesuai waktu Class
        public void ClassNotif()
        {
            PopupNotifier pn = new PopupNotifier();
            pn.TitlePadding = new Padding(20, 20, 10, 5);
            pn.ContentPadding = new Padding(20, 0, 10, 5);
            pn.TitleText = "Online Class Manager";
            pn.ContentText = "Kelas dimulai!!";
            pn.Popup();
            
        }
        //Notifikasi 10 menit sebelum Class
        public void ClassNotifPre()
        {
            PopupNotifier pn = new PopupNotifier();
            pn.TitlePadding = new Padding(20, 20, 10, 5);
            pn.ContentPadding = new Padding(20, 0, 10, 5);
            pn.TitleText = "Online Class Manager";
            pn.ContentText = "Kelas dimulai dalam 10 menit!!";
            pn.Popup();
            
        }
        //Notifikasi tepat sesuai waktu Task
        public void TaskNotif()
        {
            PopupNotifier pn = new PopupNotifier();
            pn.TitlePadding = new Padding(20, 20, 10, 5);
            pn.ContentPadding = new Padding(20, 0, 10, 5);
            pn.TitleText = "Online Class Manager";
            pn.ContentText = "DEADLINE TUGAS!!";
            pn.Popup();
        }
        //Notifikasi 1 hari sebelum deadline Task
        public void TaskNotifPre()
        {
            PopupNotifier pn = new PopupNotifier();
            pn.TitlePadding = new Padding(20, 20, 10, 5);
            pn.ContentPadding = new Padding(20, 0, 10, 5);
            pn.TitleText = "Online Class Manager";
            pn.ContentText = "Deadline tugas tinggal 1 hari lagi!!";
            pn.Popup();
        }
    }
}
