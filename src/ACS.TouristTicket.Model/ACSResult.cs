using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using ACS.TouristTicket.Common;

namespace ACS.TouristTicket.Model
{
    [DataContract()]
    public class ACSResult
    {
        public ACSResult(string statusCode, string statusMsg)
        {
            this.StatusCode = statusCode;
            this.StatusMsg = statusMsg;
        }

        public static ACSResult Success
        {
            get
            {
                return new ACSResult(ACSCConstant.Result.Success, "Successful");
            }
        }

        public static ACSResult Fail
        {
            get
            {
                return new ACSResult(ACSCConstant.Result.Failed, "Fail");
            }
        }
        [DataMember()]
        public string StatusCode {get;set; }
        [DataMember()]
        public string StatusMsg {get;set;}
    }
}
