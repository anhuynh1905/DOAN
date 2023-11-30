using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN._Class
{
    public class Guest : Person
    {
        public Guest(string _firstname,
            string _lastname,
            string _phonenumber, int bmonth, int bday, int byear) : base(_firstname, _lastname, _phonenumber, bmonth, bday, byear) { }
        public override string toString()
        {
            return "Welcome to my Hotel";
        }
    }
}
