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

        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } }
        public Person(string _firstname, string _lastname, string _phonenumber)
        {
            Firstname = _firstname;
            Lastname = _lastname;
            Phonenumber = _phonenumber;
        }

        public abstract string PrintDetails();
    }
}
