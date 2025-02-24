using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class DateUtil
    {
        public static String getTime()
        {
            return "\r\n" + DateTime.Now.ToString() + "\r\n";
        }
    }
}
