using DOAN._controllManager;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Guna2DateTimePicker;

namespace DOAN._Class
{
    public class Guest : Person
    {
        private int roomID;
        public Guest(string _firstname, string _lastname, string _phonenumber)
            : base(_firstname, _lastname, _phonenumber) { }

        public int RoomID {  get { return roomID; } set {  roomID = value; } }

        public string MakeReservation(string _firstname, string _lastname, string _phonenumber, Guna2DateTimePicker checkin, Guna2DateTimePicker checkout, string roomIDD)
        {
            RoomID = Convert.ToInt32(roomIDD);
            return String.Format("UPDATE Room_Info SET FirstName='" + "{0}" + "', LastName='" + "{1}" + "', PhoneNumber='" + "{2}" + "', CheckIn='" + "{3}" + "', CheckOut='" + "{4}" + "', RoomStatus='" + "OCCUPIED" + "' WHERE RoomID='" + "{5}" + "'",
                        _firstname, _lastname, _phonenumber, checkin.Value, checkout.Value, Int32.Parse(roomIDD));
        }

        public string FindRoom()
        {
            return String.Format("SELECT * FROM Room_Info WHERE RoomID = '"+"{0}"+"'",RoomID);
        }
        public override string PrintDetails()
        {
            return String.Format("Hello {0} {1}, with the phone number {2}, here is your room info",Firstname,Lastname,Phonenumber);
        }
    }
}
