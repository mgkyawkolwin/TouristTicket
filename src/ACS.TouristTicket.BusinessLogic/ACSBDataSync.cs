using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;
using ACS.TouristTicket.DataAccess;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBDataSync
    {
        public static void UploadData(DateTime lastuploadDateTime)
        {

        }

        public IList<Ticket> DownloadData(int counterID, int numberOfRecordsToDownload, int pageIndex)
        {
            return new ACSDDataSync().DownloadData(counterID, numberOfRecordsToDownload, pageIndex);
        }

        public IList<Ticket> ExportFromServer(int counterID)
        {
            return new ACSDDataSync().ExportDataFromServer(counterID);
        }

        //public int CheckServerData(int counterID)
        //{
        //    return new ACSDDataSync().CheckServerData(counterID);
        //}

        public int CheckClientData(int counterID)
        {
            return 0;
        }

        public int InsertUpdateTicketData(IList<Ticket> tickets)
        {
            return 0;
        }

        //public int UpdateLastDownloadedDateTime(int counterID)
        //{
        //    return new ACSDDataSync().UpdateLastDownloadedDateTime(counterID);
        //}

        public ACSUploadTicketActivationLogResponse UploadTicketActivationLog(ACSUploadTicketActivationLogRequest request)
        {
            ACSDDataSync sync = new ACSDDataSync();
            foreach(TicketActivationLog log in request.TicketActivationLogs)
            {
                sync.UploadTicketActivationLog(log);
            }
            return new ACSUploadTicketActivationLogResponse() { Result = new ACSResult(ACSCConstant.Result.Success,"Successful")};
        }

        public ACSUploadTicketUsageLogResponse UploadTicketUsageLog(ACSUploadTicketUsageLogRequest request)
        {
            return new ACSDDataSync().UploadTicketUsageLog(request);
        }

        //public ClientUploadDownloadLog RetrieveClientUploadDownloadLog()
        //{
        //    return new ACSDDataSync().RetrieveClientUploadDownloadLog();
        //}

        //public int InsertUpdateTicketData(Ticket ticket)
        //{
        //    return new ACSDDataSync().InsertUpdateTicketData(ticket);
        //}

        //public int UpdateLastUploadedDateTimeAtClientMachine()
        //{
        //    return new ACSDDataSync().UpdateLastUploadedDateTimeAtClientMachine();
        //}

        //public int UpdateLastDownloadedDateTimeAtClientMachine()
        //{
        //    return new ACSDDataSync().UpdateLastDownloadedDateTimeAtClientMachine();
        //}

        public IList<TicketActivationLog> RetrieveTicketActivationLog()
        {
            return new ACSDDataSync().RetrieveTicketActivationLog();
        }

        public IList<TicketUsageLog> RetrieveTicketUsageLog()
        {
            return new ACSDDataSync().RetrieveTicketUsageLog();
        }

        //public int CheckClientData()
        //{
        //    return new ACSDDataSync().CheckClientData();
        //}
        
    }
}
