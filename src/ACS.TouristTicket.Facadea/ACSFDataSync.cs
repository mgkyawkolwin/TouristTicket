using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;
using ACS.TouristTicket.BusinessLogic;

namespace ACS.TouristTicket.Facade
{
    public class ACSFDataSync
    {
        public static void UploadData(DateTime lastuploadDateTime)
        {

        }

        public IList<Ticket> DownloadData(int counterID, int numberOfRecordsToDownload, int pageIndex)
        {
            try
            {
                return new ACSBDataSync().DownloadData(counterID, numberOfRecordsToDownload, pageIndex);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }

        public IList<Ticket> ExportFromServer(int counterID)
        {
            try
            {
                return new ACSBDataSync().ExportFromServer(counterID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }
        //public int CheckServerData(int counterID)
        //{
        //    try
        //    {
        //        return new ACSBDataSync().CheckServerData(counterID);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        throw new Exception("Service Exception");
        //    }
        //}

        public int CheckClientData(int counterID)
        {
            return 0;
        }

        public int InsertTicketData(IList<Ticket> tickets)
        {
            return 0;
        }

        //public int UpdateLastDownloadedDateTime(int counterID)
        //{
        //    try
        //    {
        //        return new ACSBDataSync().UpdateLastDownloadedDateTime(counterID); 
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        throw new Exception("Service Exception");
        //    }
        //}

        public ACSUploadTicketActivationLogResponse UploadTicketActivationLog(ACSUploadTicketActivationLogRequest request)
        {
            try
            {
                return new ACSBDataSync().UploadTicketActivationLog(request); 
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }

        public ACSUploadTicketUsageLogResponse UploadTicketUsageLog(ACSUploadTicketUsageLogRequest request)
        {
            return new ACSBDataSync().UploadTicketUsageLog(request);
        }

        //public ClientUploadDownloadLog RetrieveClientUploadDownloadLog()
        //{
        //    try
        //    {
        //        return new ACSBDataSync().RetrieveClientUploadDownloadLog(); 
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        throw new Exception("Service Exception");
        //    }
        //}

        //public int InsertUpdateTicketData(Ticket ticket)
        //{
        //    try
        //    {
        //        return new ACSBDataSync().InsertUpdateTicketData(ticket);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        throw new Exception("Service Exception");
        //    }
        //}

        //public int UpdateLastUploadedDateTimeAtClientMachine()
        //{
        //    try
        //    {
        //        return new ACSBDataSync().UpdateLastUploadedDateTimeAtClientMachine();
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        throw new Exception("Service Exception");
        //    }
        //}

        //public int UpdateLastDownloadedDateTimeAtClientMachine()
        //{
        //    try
        //    {
        //        return new ACSBDataSync().UpdateLastDownloadedDateTimeAtClientMachine(); 
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        throw new Exception("Service Exception");
        //    }
        //}

        public IList<TicketActivationLog> RetrieveTicketActivationLog()
        {
            try
            {
                return new ACSBDataSync().RetrieveTicketActivationLog();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }

        public IList<TicketUsageLog> RetrieveTicketUsageLog()
        {
            try
            {
                return new ACSBDataSync().RetrieveTicketUsageLog();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }

        //public int CheckClientData()
        //{
        //    try
        //    {
        //        return new ACSBDataSync().CheckClientData();
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        throw new Exception("Service Exception");
        //    }
        //}

    }
}
