using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuliah_Manager
{
    class User
    {
        public string name;
        public string username;
        public string password;
        public string nim;
        private string message;
        public string Name
        {
            get;
            set;
        }
        public string Username
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }

        public string NIM
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public void Notify(string mes)
        {
            Message = "Important message for you! \n" + mes;
        }
        public bool Verify(string id, string pass)
        {
            if (Username == id && Password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
