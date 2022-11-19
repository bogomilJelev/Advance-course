using System;
using System.Collections.Generic;
using System.Text;

namespace date
{
    public class DateModifier
    {
        public static int GetDIffDate(string firstdate, string seconddate)
        {
            DateTime dateone = DateTime.Parse(firstdate);
            DateTime datesecond = DateTime.Parse(seconddate);
            TimeSpan ask = dateone - datesecond;
            return Math.Abs(ask.Days);

            
        }
    }
}
