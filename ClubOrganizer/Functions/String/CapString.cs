using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClubOrganizer.Functions.String
{
    class CapString
    {
        internal static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException("String is mull or empty");
            }

            return s[0].ToString().ToUpper() + s.Substring(1);
        }
    }
}
