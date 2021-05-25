using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using System.Windows.Forms;


namespace Kuliah_Manager
{
    class TaskNotif : INotif
    {
        //Notifikasi tepat sesuai waktu Task
        public void Notify()
        {
            PopupNotifier pn = new PopupNotifier();
            pn.TitlePadding = new Padding(20, 20, 10, 5);
            pn.ContentPadding = new Padding(20, 0, 10, 5);
            pn.TitleText = "Online Class Manager";
            pn.ContentText = "DEADLINE TUGAS!!";
            pn.Popup();
        }
        //Notifikasi 1 hari sebelum deadline Task
        public void NotifyPre()
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
