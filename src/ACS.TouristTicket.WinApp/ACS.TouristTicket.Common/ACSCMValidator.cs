using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.TouristTicket.Common
{
    public class ACSCMValidator
    {
        public bool IsNumberic(string value)
        {
            int i;
            bool b = int.TryParse(value, out i);
            if (b)
                return true;
            else
                return false;
        }
    }
}
