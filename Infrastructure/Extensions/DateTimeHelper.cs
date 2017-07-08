using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class DateTimeHelper
    {
        public static DateTime ToBrazilianTime(this DateTime dateTime)
        {
            return dateTime.ToUniversalTime().AddHours(-3);
        }
    }
}
