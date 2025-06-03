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
    public class ACSFCZone
    {
        public List<ZoneAndZoneGroup> Select_ZoneAndZoneGroup()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_ZoneAndZoneGroup", DateTime.Now, "No Params");
                return new ACSBLZone().Select_ZoneAndZoneGroup();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<Zone> Select_ZoneList()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_ZoneLost", DateTime.Now
                    , "No Params");

                return new ACSBLZone().Select_ZoneList();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public int Insert_NewZone(string ZoneID, string ZoneGroupID, string ZoneName, string Address, string Phone, string Incharge, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_NewZone", DateTime.Now
                    , "[ZoneID=" + ZoneID + "][ZoneGroupID=" + ZoneGroupID + "][ZoneName=" + ZoneName
                    + "][createdBy=" + createdBy + "][createdDate=]" + createdDate + "][modifiedBy=" + modifiedBy + "][modifiedDate=]" + modifiedDate + "]");

                return new ACSBLZone().Insert_NewZone(ZoneID, ZoneGroupID, ZoneName, Address, Phone, Incharge, createdBy, createdDate, modifiedBy, modifiedDate);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int Update_Zone(int PKID, int LinkID, string ZoneID, string ZoneGroupID, string ZoneName, string Address, string Phone, string Incharge, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_Zone", DateTime.Now
                    , "[ZoneID=" + ZoneID + "][ZoneGroupID=" + ZoneGroupID + "][ZoneName=" + ZoneName
                    + "][modifiedBy=" + modifiedBy + "][modifiedDate=]" + modifiedDate + "]");

                return new ACSBLZone().Update_Zone(PKID, LinkID, ZoneID, ZoneGroupID, ZoneName, Address, Phone, Incharge, modifiedBy, modifiedDate);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        #region Delete

        public int DeleteZone(string ZoneID)
        {
            try
            {
                new ACSBLTransactionLog().Insert_TransactionLog("DeleteZone", DateTime.Now
                    , ZoneID + "ZoneName");

                return new ACSBLZone().DeleteZone(ZoneID);
            }
            catch (Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        #endregion
    }
}
