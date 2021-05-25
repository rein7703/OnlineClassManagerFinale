using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    class ClassNotif: INotif
    {
        //Notifikasi tepat sesuai waktu Class
        public void Notify()
        {
            PopupNotifier pn = new PopupNotifier();
            pn.TitlePadding = new Padding(20, 20, 10, 5);
            pn.ContentPadding = new Padding(20, 0, 10, 5);
            pn.TitleText = "Online Class Manager";
            pn.ContentText = "Kelas dimulai!!";
            pn.Popup();

        }
        //Notifikasi 10 menit sebelum Class
        public void NotifyPre()
        {
            PopupNotifier pn = new PopupNotifier();
            pn.TitlePadding = new Padding(20, 20, 10, 5);
            pn.ContentPadding = new Padding(20, 0, 10, 5);
            pn.TitleText = "Online Class Manager";
            pn.ContentText = "Kelas dimulai dalam 10 menit!!";
            pn.Popup();

        }
    }
}
