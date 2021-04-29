using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuliah_Manager
{
    class User
    {
        private string name;
        private string username;
        private string password;
        private string nim;
        private string message;
        public string Name
        {
            get;
            private set;
        }
        public string Username
        {
            get;
            private set;
        }
        public string Password
        {
            get;
            private set;
        }

        public string NIM
        {
            get;
            private set;
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
            if (Name == id && Password == pass)
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
