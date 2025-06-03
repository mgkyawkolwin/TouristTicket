using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
    public class ACSDDataSync
    {
        //public IList<Ticket> RetrieveDataToUpload(int numOfRecords,int pageIndex)
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {
        //        db.ContextOptions.LazyLoadingEnabled = false;
        //        db.ContextOptions.ProxyCreationEnabled = false;
        //        ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
        //        IList<Ticket> tickets = db.RetrieveDataToUpload(numOfRecords, pageIndex,ErrorCode,ErrorMsg).ToList();
        //        if (ErrorCode.Value.ToString() != "0")
        //            throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
        //        return tickets;
        //    }
        //}

        public IList<Ticket> DownloadData(int counterID, int numberOfRecordsToDownload, int pageIndex)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                IList<Ticket> tickets = db.DownloadData(counterID, numberOfRecordsToDownload, pageIndex, ErrorCode, ErrorMsg).ToList<Ticket>();
                if (ErrorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
                return tickets;
            }
        }

        public IList<Ticket> ExportDataFromServer(int counterID)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                IList<Ticket> tickets = db.ExportFromServer(counterID, ErrorCode, ErrorMsg).ToList<Ticket>();
                if (ErrorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
                return tickets;
            }
        }

        //public int CheckServerData(int counterID)
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {                
        //        ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
        //        int records = db.CheckServerData(counterID, ErrorCode, ErrorMsg).FirstOrDefault() ?? 0;
        //        if (ErrorCode.Value.ToString() != "0")
        //            throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
        //        return records;
        //    }
        //}

        //public int CheckClientData()
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {
        //        ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
        //        db.ContextOptions.LazyLoadingEnabled = false;
        //        db.ContextOptions.ProxyCreationEnabled = false;
        //        int records = db.CheckClientData(ErrorCode, ErrorMsg).FirstOrDefault() ?? 0;
        //        if (ErrorCode.Value.ToString() != "0")
        //            throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
        //        return records;
        //    }
        //}

        //public int InsertUpdateTicketData(Ticket ticket)
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {
        //        ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
        //        db.ContextOptions.LazyLoadingEnabled = false;
        //        db.ContextOptions.ProxyCreationEnabled = false;
        //        int records = db.InsertUpdateTicket(ticket.PKID, ticket.Price, ticket.TicketStatus.ToString(), ticket.AllowedUsage, ticket.AlreadyUsed, ticket.AllowedDays, ticket.ExpiryDate, ticket.TicketData, ticket.CreatedDate, ticket.CreatedBy, ticket.ModifiedDate, ticket.ModifiedBy, ErrorCode, ErrorMsg).FirstOrDefault() ?? 0;
        //        if (ErrorCode.Value.ToString() != "0")
        //            throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
        //        return records;
        //    }
        //}

        //public int UpdateLastDownloadedDateTime(int counterID)
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {
        //        db.ContextOptions.LazyLoadingEnabled = false;
        //        db.ContextOptions.ProxyCreationEnabled = false;
        //        ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        return db.UpdateLastDownloadedDateTime(counterID).FirstOrDefault() ?? 0;
        //    }
        //}

        //public int UpdateLastUploadedDateTimeAtClientMachine()
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {
        //        db.ContextOptions.LazyLoadingEnabled = false;
        //        db.ContextOptions.ProxyCreationEnabled = false;
        //        ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        return db.UpdateLastUploadedDateTimeAtClientMachine().FirstOrDefault() ?? 0;
        //    }
        //}

        //public int UpdateLastDownloadedDateTimeAtClientMachine()
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {
        //        db.ContextOptions.LazyLoadingEnabled = false;
        //        db.ContextOptions.ProxyCreationEnabled = false;
        //        ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        return db.UpdateLastDownloadedDateTimeAtClientMachine().FirstOrDefault() ?? 0;
        //    }
        //}

        public int UploadTicketActivationLog(TicketActivationLog log)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                int records = db.InsertTicketActivationLog(log.CounterID, log.ZoneID, log.TicketID, log.TransactionID, log.ActivatedDate, ErrorCode, ErrorMsg).FirstOrDefault() ?? 0;
                if (ErrorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
                return records;
            }
        }

        public IList<TicketActivationLog> RetrieveTicketActivationLog()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                IList<TicketActivationLog> list = db.RetrieveTicketActivationLog(ErrorCode,ErrorMsg).ToList();
                if (ErrorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
                return list;
            }
        }

        public IList<TicketUsageLog> RetrieveTicketUsageLog()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                IList<TicketUsageLog> list = db.RetrieveTicketUsageLog(ErrorCode, ErrorMsg).ToList();
                if (ErrorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
                return list;
            }
        }

        public ACSUploadTicketUsageLogResponse UploadTicketUsageLog(ACSUploadTicketUsageLogRequest request)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                foreach (TicketUsageLog log in request.TicketUsageLogs)
                {
                    ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
                    ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                    db.InsertTicketUsageLog(log.CounterID, log.ZoneID, log.TicketID, log.DateUsed, log.UsageCountBefore, log.TransactionID, log.UsageCountAfter, ErrorCode, ErrorMsg).FirstOrDefault();
                    if (ErrorCode.Value.ToString() != "0")
                        throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
                }
            }
            
            return new ACSUploadTicketUsageLogResponse() { Result = new ACSResult(ACSCConstant.Result.Success, "Successful") };
        }

        //public ClientUploadDownloadLog RetrieveClientUploadDownloadLog()
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer())
        //    {
        //        db.ContextOptions.LazyLoadingEnabled = false;
        //        db.ContextOptions.ProxyCreationEnabled = false;
        //        ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(string));
        //        ObjectParameter ErrorMsg = new ObjectParameter("ErrorMsg", typeof(string));
        //        ClientUploadDownloadLog log = db.RetrieveClientUploadDownloadLog(ErrorCode, ErrorMsg).FirstOrDefault();
        //        if (ErrorCode.Value.ToString() != "0")
        //            throw new Exception("ErrorCode = " + ErrorCode.Value.ToString() + "; ErrorMsg = " + ErrorMsg.Value.ToString());
        //        return log;
        //    }
        //}
    }
}
