using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopexercise2
{
    class MyDate
    {
        private int year = 1;
        private int month = 1;
        private int day = 1;
        private string[] strMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                       "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private string[] strDays = { "Sunday", "Monday", "Tuesday", "Wednesday"
                                       , "Thursday", "Friday", "Saturday"};

        private int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }
}
