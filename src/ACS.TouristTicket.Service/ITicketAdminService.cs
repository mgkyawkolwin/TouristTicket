using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using ACS.TouristTicket.Facade;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITicketAdminService" in both code and config file together.
    [ServiceContract]
    public interface ITicketAdminService
    {
        [OperationContract]
        void DoWork();
    }


    public class ITicketService
    {
        #region "USER"
        #region "SELECT"

        public List<User> Select_User()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_User", DateTime.Now
                    , "No Params");

                return new ACSFCUser().Select_User();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<User> UserLogin(string UserID, string Password)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("UserLogin", DateTime.Now
                    , "[UserID=" + UserID + "][Passowrd=" + Password + "]");

                return new ACSFCUser().UserLogin(UserID, Password).ToList<User>();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<Role> Select_Role()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_Role", DateTime.Now
                    , "No Params");

                return new ACSFCUser().Select_Role();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<UserInRole> Select_UserInRole()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_UserInRole", DateTime.Now
                    , "No Params");

                return new ACSFCUser().Select_UserInRole();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<UserAccessLog> Select_UserAccessLog()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_UserAccessLog", DateTime.Now
                    , "No Params");

                return new ACSFCUser().Select_UserAccessLog();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<UserAccessLog> Select_UserAccessLogByUserID(string UserID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_UserAccessLogByUserID", DateTime.Now
                    , "[UserID=" + UserID + "]");

                return new ACSFCUser().Select_UserAccessLogByUserID(UserID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        #endregion

        //#region "INSERT"

        //public int Insert_NewUser(string userID, string password, string displayName, string status, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Insert_NewUser", DateTime.Now,
        //          "[userID=" + userID + "][password=" + password + "][displayName=" + displayName + "][status=" + status
        //          + "][createdDate=" + createdDate + "][createdBy=" + createdBy + "][modifedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

        //        return new ACSFCUser().Insert_NewUser(userID, password, displayName, status, createdDate, createdBy, modifiedDate, modifiedBy);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //public int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Insert_UserInRole", DateTime.Now
        //            , "[userID=" + userID + "][roleID=" + roleID
        //            + "][createdDate=" + createdDate + "][createdBy=" + createdBy + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

        //        return new ACSFCUser().Insert_UserInRole(userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //public int Insert_UserAccessLog(string userID, Nullable<System.DateTime> accessDate, string action, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Insert_UserAccessLog", DateTime.Now
        //        , "[userID=" + userID + "][accessDate=" + accessDate + "][action=" + action
        //        + "][createdDate=" + createdDate + "][createdBy=" + createdBy + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

        //        return new ACSFCUser().Insert_UserAccessLog(userID, accessDate, action, createdDate, createdBy, modifiedDate, modifiedBy);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //#endregion

        //#region "UPDATE"

        //public int Update_User(string userID, string password, string displayName, string status, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Update_User", DateTime.Now
        //            , "[userID=" + userID + "][password=" + password + "][displayName=" + displayName + "][status=" + status
        //            + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

        //        return new ACSFCUser().Update_User(userID, password, displayName, status, modifiedDate, modifiedBy);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //public int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Update_UserInRole", DateTime.Now
        //            , "[userID=" + userID + "][roleID=" + roleID
        //            + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

        //        return new ACSFCUser().Update_UserInRole(userID, roleID, modifiedDate, modifiedBy);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //#endregion

        #region "DELETE"

        public int DeleteUserByUserID(string UserID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("DeleteUserByUserID", DateTime.Now
                    , "[UserID=" + UserID + "]");

                return new ACSFCUser().DeleteUserByUserID(UserID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int DeleteUserInRoleByUserID(string UserID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("DeleteUserInRoleByUserID", DateTime.Now
                    , "[UserID=" + UserID + "]");

                return new ACSFCUser().DeleteUserInRoleByUserID(UserID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;

        }

        #endregion
        #endregion

        #region "COUNTER"
        public List<Counter> Select_Counter()
        {
            return new ACSFCCounter().Select_Counter();
        }

        public List<CounterAndZone> Select_CounterDetail()
        {
            return new ACSFCCounter().Select_CounterDetail();
        }

        public int Insert_Counter(int counterID, int zoneID, Nullable<int> createdBy, Nullable<System.DateTime> createdDate)
        {
            return new ACSFCCounter().Insert_Counter(counterID, zoneID, createdBy, createdDate);
        }

        public int Update_Counter(int PKID, int counterID, int zoneID)
        {
            return new ACSFCCounter().Update_Counter(PKID, counterID, zoneID);
        }

        public int Delete_Counter(int CounterID)
        {
            return new ACSFCCounter().Delete_Counter(CounterID);
        }

        public int SelectNewCounterID()
        {
            return new ACSFCCounter().SelectNewCounterID();
        }
        #endregion

        #region "ExceptionLog"

        public int Insert_ExceptionLog(string errorMessage, string stackTrace, Nullable<System.DateTime> createdDate)
        {
            return new ACSFCExceptionLog().Insert_ExceptionLog(errorMessage, stackTrace, createdDate);
        }

        #endregion

        #region "LogEncryptDecrypt"
       
        public static string EncryptLog(string plainLog)
        {
            return ACSFCLogEncryptDecrypt.EncryptLog(plainLog);
        }

        public static string DecryptLog(string encryptedLog)
        {
            return ACSFCLogEncryptDecrypt.DecryptLog(encryptedLog);
        }
        #endregion

        #region "Support"

        public string EncDec(string plainText)
        {
            return new ACSFCSupport().EncDec(plainText);
        }

        public string Decrypt(string encryptedText)
        {
            return new ACSFCSupport().Decrypt(encryptedText);
        }
        #endregion

        #region "Ticket"

        #region "Insert"

        public int Insert_Ticket(int ticketSerial, string ZoneGroupID, decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_Ticket", DateTime.Now,
                    "[ZoneGroupID=" + ZoneGroupID + "][Price=" + Price + "][TicketStatus=" + TicketStatus
                    + "][AllowedUsage=" + AllowedUsage.ToString() + "][AlreadyUsed=" + AlreadyUsed.ToString()
                    + "][AllowedDays=" + AllowedDays + "][ExpiryDate=" + ExpiryDate + "][TicketData=" + TicketData
                    + "][CreateDate=" + CreatedDate + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + modifiedDate + "][ModifiedBy=" + modifiedBy);

                return new ACSFCTicket().Insert_Ticket(ticketSerial, ZoneGroupID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            //return 0;
        }

        #endregion

        #region "Select"

        public List<Ticket> Select_Ticket()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_Ticket", DateTime.Now, "No Params");

                return new ACSFCTicket().Select_Ticket();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            //return null;
        }

        #endregion

        #region "Update"

        public int Update_Ticket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_Ticket", DateTime.Now,
                   "[Price=" + Price + "][TicketStatus=" + TicketStatus
                   + "][AllowedUsage=" + AllowedUsage.ToString() + "][AlreadyUsed=" + AlreadyUsed.ToString()
                   + "][AllowedDays=" + AllowedDays + "][ExpiryDate=" + ExpiryDate + "][TicketData=" + TicketData
                   + "][CreateDate=" + CreatedDate + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + modifiedDate + "][ModifiedBy=" + modifiedBy);

                return new ACSFCTicket().Update_Ticket(Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            //return 0;
        }

        public int Update_TicketStatus(int TicketID, string ticketStatus, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_TicketStatus", DateTime.Now,
                    "[TicketID=" + TicketID + "][ticketStatus=" + ticketStatus
                    + "][modifiedBy=" + modifiedBy + "][modifiedDate=" + modifiedDate + "]");

                return new ACSFCTicket().Update_TicketStatus(TicketID, ticketStatus, modifiedBy, modifiedDate);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            //return 0;
        }

        #endregion

        #region "Select TicketDetails"

        public List<TicketDetail> Select_TicketDetail()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_TicketDetail", DateTime.Now
                    , "No Params");

                return new ACSFCTicket().Select_TicketDetail();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<TicketDetail> SelectTicketCollectionsUsingFilters(int? ticketSerialFrom, int? ticketSerialTo, string ticketStatus, string zoneGroupName, DateTime? createdDateFrom, DateTime? createdDateTo)
        {
            return new ACSFCTicket().SelectTicketCollectionsUsingFilters(ticketSerialFrom, ticketSerialTo, ticketStatus, zoneGroupName, createdDateFrom, createdDateTo);
        }

        public int Select_MaxPKIDAsTicketSerialNo()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_MaxPKIDAsTicketSerialNo", DateTime.Now
                    , "No Params");

                return new ACSFCTicket().Select_MaxPKIDAsTicketSerialNo();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int SelectNewTicketID()
        {
            return new ACSFCTicket().SelectNewTicketID();
        }

        #endregion

        #endregion

        #region "TicketInZone"

        #region "Insert"

        public int Insert_TicketInZone(string ticketID, string zoneID, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_TicketInZone", DateTime.Now,
                    "[ticketID=" + ticketID + "][zoneID=" + zoneID + "][CreatedDate=" + CreatedDate
                    + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + ModifiedDate + "][ModifiedBy=" + ModifiedBy + "]");

                return new ACSFCTicketInZone().Insert_TicketInZone(ticketID, zoneID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            //return 0;
        }

        #endregion

        #region "Select"

        public List<TicketInZone> Select_TicketInZone()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_TicketInZone", DateTime.Now
                    , "No Params");

                return new ACSFCTicketInZone().Select_TicketInZone();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        #endregion

        #region "TicketSetting"

        #region "Select"

        public List<TicketSetting> SelectTicketSetting()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("SelectTicketSetting", DateTime.Now
                    , "No Params");

                return new ACSFCTicketSettings().SelectTicketSetting();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        #endregion

        #region "Insert"

        public int InsertTicketSetting(string TicketZoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("InsertTicketSetting", DateTime.Now
                    , "[TicketZoneID=" + TicketZoneID + "][DaysAllowed=" + DaysAllowed.ToString() + "][EntryAllowed=" + EntryAllowed.ToString() + "][Price=" + Price
                    + "][CreatedDate=" + CreatedDate + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + ModifiedDate + "][ModifiedBy=" + ModifiedBy + "]");

                return new ACSFCTicketSettings().InsertTicketSetting(TicketZoneID, DaysAllowed, EntryAllowed, Price, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy);
            }
            catch (Exception ex)
            {
                return new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
        }

        #endregion

        #region "Update"

        public int UpdateTicketSettings(string TicketZoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<int> Modifiedby, Nullable<DateTime> ModifiedDate)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("UpdateTicketSettings", DateTime.Now
                    , "[TicketZoneID=" + TicketZoneID + "][DaysAllowed=" + DaysAllowed.ToString() + "][EntryAllowed=" + EntryAllowed.ToString() + "][Price=" + Price
                    + "][ModifiedBy=" + Modifiedby + "][ModifiedDate=" + ModifiedDate + "]");

                return new ACSFCTicketSettings().UpdateTicketSettings(TicketZoneID, DaysAllowed, EntryAllowed, Price, Modifiedby, ModifiedDate);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        #endregion

        #region "Delete"

        public int DeleteTicketSettings(string TicketZoneID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("DeleteTicketSettings", DateTime.Now
                    , "[TicketZoneID=" + TicketZoneID + "]");

                return new ACSFCTicketSettings().DeleteTicketSettings(TicketZoneID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }
        #endregion

  #endregion



#endregion

        #region "TicketUnused"

        public class ACSFCTicketUnused
        {

            #region "Insert"

            public int Insert_TicketUnused(string serialNo, string description, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
            {
                return new ACSFCTicketUnused().Insert_TicketUnused(serialNo, description, createdBy, createdDate, modifiedBy, modifiedDate);
            }

            #endregion

            #region "Update"

            public int Update_TicketUnused(string serialNo, string description, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
            {
                return new ACSFCTicketUnused().Update_TicketUnused(serialNo, description, modifiedBy, modifiedDate);
            }

            #endregion

            #region "Delete"

            public int Delete_TicketDamages(string SerialNo)
            {
                return new ACSFCTicketUnused().Delete_TicketDamages(SerialNo);
            }

            #endregion

            #region "Select"

            public List<TicketUnused> Select_TicketUnused()
            {
                return new ACSFCTicketUnused().Select_TicketUnused();
            }

            public List<TicketUnused> Select_TicketDamages()
            {
                return new ACSFCTicketUnused().Select_TicketUnused();
            }
            #endregion
        }

        #endregion

        #region "TicketUsage"

        #region "Insert"

        public int Insert_TicketUsage(int TicketID, int ZoneID, Nullable<System.DateTime> DateUsed)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_TicketUsage", DateTime.Now
                    , "[TicketID=" + TicketID + "][ZoneID=" + ZoneID + "][DateUsed=" + DateUsed + "]");

                return new ACSFCTicketUsage().Insert_TicketUsage(TicketID, ZoneID, DateUsed);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        #endregion

        #region "Select"

        public List<TicketUsage> Select_TicketUsage()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_TicketUsage", DateTime.Now, "No Params");
                return new ACSFCTicketUsage().Select_TicketUsage();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }
        #endregion

        #endregion

        #region "TranscationLog"

        #region "Insert"

        public void Insert_TransactionLog(string transactionType, Nullable<System.DateTime> transactionDate, string data)
        {
            new ACSFCTransactionLog().Insert_TransactionLog(transactionType, transactionDate, data);
        }

        #endregion

        #endregion

        //#region "Zone"

        //#region "Select"

        //public List<ZoneAndZoneGroup> Select_ZoneAndZoneGroup()
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Select_ZoneAndZoneGroup", DateTime.Now, "No Params");
        //        return new ACSFCZone().Select_ZoneAndZoneGroup();
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return null;
        //}

        //public List<Zone> Select_ZoneList()
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Select_ZoneLost", DateTime.Now
        //            , "No Params");

        //        return new ACSFCZone().Select_ZoneList();
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return null;
        //}

        //#endregion

        //#region "Insert"

        //public int Insert_NewZone(string ZoneID, string ZoneGroupID, string ZoneName, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Insert_NewZone", DateTime.Now
        //            , "[ZoneID=" + ZoneID + "][ZoneGroupID=" + ZoneGroupID + "][ZoneName=" + ZoneName
        //            + "][createdBy=" + createdBy + "][createdDate=]" + createdDate + "][modifiedBy=" + modifiedBy + "][modifiedDate=]" + modifiedDate + "]");

        //        return new ACSFCZone().Insert_NewZone(ZoneID, ZoneGroupID, ZoneName, createdBy, createdDate, modifiedBy, modifiedDate);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //#endregion

        //#region "Update"

        //public int Update_Zone(int PKID, int LinkID, string ZoneID, string ZoneGroupID, string ZoneName, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("Update_Zone", DateTime.Now
        //            , "[ZoneID=" + ZoneID + "][ZoneGroupID=" + ZoneGroupID + "][ZoneName=" + ZoneName
        //            + "][modifiedBy=" + modifiedBy + "][modifiedDate=]" + modifiedDate + "]");

        //        return new ACSFCZone().Update_Zone(PKID, LinkID, ZoneID, ZoneGroupID, ZoneName, modifiedBy, modifiedDate);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //#endregion

        //#region Delete

        //public int DeleteZone(string ZoneID)
        //{
        //    try
        //    {
        //        new ACSFCTransactionLog().Insert_TransactionLog("DeleteZone", DateTime.Now
        //            , ZoneID + "ZoneName");

        //        return new ACSFCZone().DeleteZone(ZoneID);
        //    }
        //    catch (Exception ex)
        //    {
        //        new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
        //        //throw generic exception to UI
        //        throw new Exception(ACSCConstant.Message.GenericServiceError);
        //    }
        //    return 0;
        //}

        //#endregion

        //#endregion

        #region "ZoneGroup"

        #region "Select"

        public List<ZoneGroup> Select_ZoneGroup()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("SelectZoneGroup", DateTime.Now
                    , "Select_ZoneGroup(No Params)");

                return new ACSFCZoneGroup().Select_ZoneGroup();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        #endregion

        #region "Insert"

        public int Insert_ZoneGroup(string ZoneGroupID, string ZoneGroupName, int daysAllowed, int entriesAllowed, decimal price, Nullable<System.DateTime> CreatedDate, Nullable<int> Createdby, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("InsertZoneGroup", DateTime.Now
                    , "[ZoneGroupID=" + ZoneGroupID + "][ZoneGroupName=" + ZoneGroupName
                    + "][CreatedDate=" + CreatedDate + "][Createdby=" + Createdby + "][ModifiedDate=" + ModifiedDate + "][ModifiedBy=" + ModifiedBy + "]");

                return new ACSFCZoneGroup().Insert_ZoneGroup(ZoneGroupID, ZoneGroupName, daysAllowed, entriesAllowed, price, CreatedDate, Createdby, ModifiedDate, ModifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        #endregion

        #region "Update"

        public int Update_ZoneGroup(int PKID, string ZoneGroupID, string ZoneGroupName, int DaysAllowed, int EntriesAllowed, decimal Price, Nullable<int> ModifiedBy, Nullable<System.DateTime> ModifiedDate)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_ZoneGroup", DateTime.Now
                    , "[PKID=" + PKID + "][ZoneGroupID=" + ZoneGroupID + "][ZoneGroupName=" + ZoneGroupName
                    + "][ModifiedBy=" + ModifiedBy + "][ModifiedDate=" + ModifiedDate + "]");

                return new ACSFCZoneGroup().Update_ZoneGroup(PKID, ZoneGroupID, ZoneGroupName, DaysAllowed, EntriesAllowed, Price, ModifiedBy, ModifiedDate);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        #endregion

        #region "Delete"

        public int Delete_ZoneGroup(string ZoneGroupID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Delete_ZoneGroup", DateTime.Now
                    , "[ZoneGroupID=" + ZoneGroupID + "]");

                return new ACSFCZoneGroup().Delete_ZoneGroup(ZoneGroupID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        #endregion

        #endregion

        #region "DataSync"

        public static void UploadData(DateTime lastuploadDateTime)
        {

        }

        #region "Select"

        public IList<Ticket> DownloadData(int counterID, int numberOfRecordsToDownload, int pageIndex)
        {
            try
            {
                return new ACSFDataSync().DownloadData(counterID, numberOfRecordsToDownload, pageIndex);
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
                return new ACSFDataSync().ExportFromServer(counterID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }

        #endregion

        public int CheckClientData(int counterID)
        {
            return 0;
        }

        #region "InsertTicketData"

        public int InsertTicketData(IList<Ticket> tickets)
        {
            return 0;
        }

        #endregion

        #region "Upload"

        public ACSUploadTicketActivationLogResponse UploadTicketActivationLog(ACSUploadTicketActivationLogRequest request)
        {
            try
            {
                return new ACSFDataSync().UploadTicketActivationLog(request);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }

        public ACSUploadTicketUsageLogResponse UploadTicketUsageLog(ACSUploadTicketUsageLogRequest request)
        {
            return new ACSFDataSync().UploadTicketUsageLog(request);
        }

        #endregion

        #region "Retrive"

        public IList<TicketActivationLog> RetrieveTicketActivationLog()
        {
            try
            {
                return new ACSFDataSync().RetrieveTicketActivationLog();
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
                return new ACSFDataSync().RetrieveTicketUsageLog();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                throw new Exception("Service Exception");
            }
        }

        #endregion

        #endregion
    }
}


