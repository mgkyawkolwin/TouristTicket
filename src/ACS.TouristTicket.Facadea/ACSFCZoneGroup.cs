using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.BusinessLogic;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.Facade
{
    public class ACSFCZoneGroup
    {
        public List<ZoneGroup> Select_ZoneGroup()
        {
            try
            {
                new ACSBLTransactionLog().Insert_TransactionLog("SelectZoneGroup", DateTime.Now
                    , "Select_ZoneGroup(No Params)");

                return new ACSBLZoneGroup().Select_ZoneGroup();
            }
            catch(Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<DistinctZoneGroupName> Select_DistinctZoneGroupName()
        {
            try
            {
                new ACSBLTransactionLog().Insert_TransactionLog("SelectZoneGroupName", DateTime.Now
                    , "Select_DistinctZoneGroupName(No Params)");
                return new ACSBLZoneGroup().Select_DistinctZoneGroupName();
            }
            catch (Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
        }

        public int Insert_ZoneGroup(string ZoneGroupID, string ZoneGroupName, int daysAllowed, int entriesAllowed, decimal price, Nullable<System.DateTime> CreatedDate, Nullable<int> Createdby, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            try
            {
                new ACSBLTransactionLog().Insert_TransactionLog("InsertZoneGroup", DateTime.Now
                    ,"[ZoneGroupID=" + ZoneGroupID + "][ZoneGroupName=" + ZoneGroupName 
                    + "][CreatedDate=" + CreatedDate +"][Createdby=" + Createdby + "][ModifiedDate=" + ModifiedDate + "][ModifiedBy=" + ModifiedBy + "]");

                return new ACSBLZoneGroup().Insert_ZoneGroup(ZoneGroupID, ZoneGroupName,daysAllowed,entriesAllowed,price, CreatedDate, Createdby, ModifiedDate, ModifiedBy);
            }
            catch(Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int Update_ZoneGroup(int PKID, string ZoneGroupID, string ZoneGroupName, int DaysAllowed, int EntriesAllowed, decimal Price, Nullable<int> ModifiedBy, Nullable<System.DateTime> ModifiedDate)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_ZoneGroup", DateTime.Now
                    , "[PKID=" + PKID + "][ZoneGroupID=" + ZoneGroupID + "][ZoneGroupName=" + ZoneGroupName
                    + "][ModifiedBy=" + ModifiedBy + "][ModifiedDate=" + ModifiedDate + "]");

                return new ACSBLZoneGroup().Update_ZoneGroup(PKID, ZoneGroupID, ZoneGroupName, DaysAllowed, EntriesAllowed, Price, ModifiedBy, ModifiedDate);
            }
            catch (Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int Delete_ZoneGroup(string ZoneGroupID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Delete_ZoneGroup", DateTime.Now
                    , "[ZoneGroupID=" + ZoneGroupID + "]");

                return new ACSBLZoneGroup().Delete_ZoneGroup(ZoneGroupID);
            }
            catch (Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }
    }
}
