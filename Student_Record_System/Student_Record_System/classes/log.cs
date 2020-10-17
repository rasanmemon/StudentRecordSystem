using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record_System.classes
{
    class log
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool check()
        {
            string username = this.username;
            string password = this.password;
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            return false;
        }
    }
}