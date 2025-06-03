using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.TouristTicket.WinApp
{
    public class SyncInfo
    {
        public DateTime? LastUploadedDate { get; set; }
        public DateTime? LastDownloadedDate { get; set; }
        public string Status { get; set; }
        public bool IsConnected { get; set; }
    }
}
