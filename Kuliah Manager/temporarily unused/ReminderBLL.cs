using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    abstract class ReminderBLL
    {
        protected string className;
        protected string day;
        private string hour;
        private string min;
        protected bool validation;
        public string finalMsg;

        public string ClassName { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
        public string Min { get; set; }

        
        public string Pesan { get; protected set; }
        public bool Validation { get; set; }
        public ReminderBLL (string mes)
        {
            this.Pesan = mes;
        }

        public virtual void ShowMes()
        {
            MessageBox.Show(finalMsg);
        }
    }
}
