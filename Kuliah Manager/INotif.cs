using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    interface INotif
    {
        void Notify();
        void NotifyPre();
    }
}
