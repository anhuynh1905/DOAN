using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN._Class
{
    public class Staff : Person
    {
        private string username;
        private string password;
        private string role;
        public string Role { get { return role; } set { role = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public Staff(string _username, string _password, string _role, string _firstname, string _lastname, string _phonenumber, int bmonth, int bday, int byear) : base(_firstname, _lastname, _phonenumber, bmonth, bday, byear)
        {
            Username = username;
            Password = password;
            Role = _role;
        }

        public override string toString()
        {
            return "Welcome back " + Role + " " + Firstname + " " + Lastname;
        }
    }
}
