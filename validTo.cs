using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace networkDeviceApp
{
    internal class validTo
    {
    }
    public class ValidTo
    {
        public static bool IsValidIP(string IP)
        {
            string scriptIP = @"^((25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)$";
            return Regex.IsMatch(IP, scriptIP);
        }
    }
}
