using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN._Class
{
    public abstract class Person
    {
        private string firstname;
        private string lastname;
        private string phonenumber;
        private Date _date;

        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public Person(string _firstname, string _lastname, string _phonenumber, int bmonth, int bday, int byear)
        {
            Firstname = _firstname;
            Lastname = _lastname;
            Phonenumber = _phonenumber;
            _date = new Date(bmonth, bday, byear);
        }

        public abstract string toString();
    }
}
