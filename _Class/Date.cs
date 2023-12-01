using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN._Class
{
    public class Date
    {
        private int month;
        private int year;
        private int day;
        public Date(int Month, int Day, int Year)
        {
            if (Month > 0 && Month <= 12)
                month = Month;
            else
            {
                month = 1;
                Console.WriteLine("Tháng {0} không hợp lệ. Tạm thời đưa về tháng 1.", Month);

            }
            year = Year;
            day = Checkday(Day);
        }
        public int Month() { return month; }
        private int Checkday(int testDay)
        {
            int[] daypermonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (testDay > 0 && testDay <= daypermonth[month])
                return testDay;
            if (month == 2 && testDay == 29 && (year % 400 == 0 || year % 4 == 0 && year % 100 != 0))
                return testDay;
            Console.WriteLine("Ngày {0} không hợp lệ. Tạm thời đưa về ngày 1.");
            return 1;
        }
        public int dayPermonth(int n)
        {
            int[] daypermonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daypermonth[n];
        }
        public string ToDateString()
        {
            return month + "/" + day + "/" + year;
        }
    }
}
