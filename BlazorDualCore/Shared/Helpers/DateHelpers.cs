using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDualCore.Shared.Helpers
{
    public static class DateHelpers
    {
        public static string GetDaysAgoFromDateTime(DateTime dateTime)
        {
            TimeSpan elapsed = DateTime.Now.Subtract(dateTime);

            double totalDays = elapsed.TotalDays;

            if (totalDays < 30) return totalDays.ToString() + " days ago";
            else if (totalDays > 30 && totalDays < 360)
            {
                double months = Math.Round(totalDays / 30);
                return months.ToString() + " months ago";
            }
            else if (totalDays > 360)
            {
                double months = Math.Round(totalDays / 30);
                double years = Math.Round(months / 12);
                return years.ToString() + " years ago";
            }
            return "";
        }
    }
}
