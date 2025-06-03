using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.TouristTicket.Common
{
    public static class ACSCConstant
    {
        public struct Result
        {
            public const string Success = "0";
            public const string Failed = "1";
        }

        public struct Format
        {
            public const string DateFormat = "dd-MMM-yyyy";
        }

        public struct SystemConstant
        {
            public const int AllowedDays = 7;
            public const int ExpireAfterInMonths = 12;
        }

        public enum FormState
        {
            Normal = 1,
            Displaying = 2,
            New = 4,
            Editing = 8
        }

        public struct Message
        {
            public const string GenericServiceError = "Exception occured at service. Please contact system administrator.";
            public const string GenericUIError = "Unhandled exception occurred. Please contact system administrator.";
        }
    }
}
