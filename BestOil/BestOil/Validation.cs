using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BestOil
{
    static public class Validation
    {
        public static bool IsInteger(string input)
        {
            string pattern = @"^\d+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsDouble(string input)
        {
            string pattern = @"^\d+\.\d*$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
