using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson5
{
    public static class ExtensionClass
    {
        public static String ClearingLine(this string str)
        {
            var outString = Regex.Replace(str, @"[^0-9a-zA-Z:, ]+", "");
            return outString;
        }
    }
}
