﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ACS.TouristTicket.Model
{
    interface IACSResponse
    {
        ACSResult Result { get; set; }
    }
}
