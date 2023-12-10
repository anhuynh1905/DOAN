using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN._Class
{
    public class StaffCombo
    {
        static List<Manager> managers = new List<Manager>();
        static List<Receptionist> receptionists = new List<Receptionist>();
        public static void addmanager(string UserName, string PassWord, string Role, string FirstName, string LastName, string PhoneNumber)
        {
            managers.Add(new Manager(UserName, PassWord, Role,
                    FirstName, LastName, PhoneNumber));
        }
        public static void addreception(string UserName, string PassWord, string Role, string FirstName, string LastName, string PhoneNumber)
        {
            receptionists.Add(new Receptionist(UserName, PassWord, Role,
                    FirstName, LastName, PhoneNumber));
        }
        public static string PrintDetails(string x)
        {
            if(x == "manager")
            {
                return managers.Last().PrintDetails();
            }
            else
            {
                 return receptionists.Last().PrintDetails();
            }
        }
    }
}
