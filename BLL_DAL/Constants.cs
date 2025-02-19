﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public static class Constants
    {
        public static char[] charIsInvalid = { '=', '<', '>', '`', '^', '$', '~', '+' };
        public static char[] charInvalid_Address = { '=', '^', '%', '<', '>', '-', '_', '@', '#', '!', '~', '`', '+', '-', '*', '%', '(', ')', '&' };
        //return true if substring is found
        public static bool Find_SubString_Lower_Upper_Camel(string source, string substring)
        {
            return source.IndexOf(substring, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        public static string ConvertDateFormat(string inputDate, string outputFormat)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(inputDate, "dddd, MMMM dd, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return parsedDate.ToString(outputFormat);
            }
            else
            {
                return "Invalid date format";
            }
        }
    }
}
