using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.TouristTicket.Model
{
    interface IACSResult
    {
        string StatusCode { get; set; }
        string StatusMessage { get; set; }
    }
}
