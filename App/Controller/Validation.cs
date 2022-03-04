using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App.Controller
{
    public static class Validation
    {
        public static bool ValidateFormatDate(string date)
        {
            Regex r = new Regex(@"(((0)[0-9])|((1)[0-2]))(\/)([0-2][0-9]|(3)[0-1])(\/)\d{4}");
            return r.Match(date).Success;
        }
    }
}

