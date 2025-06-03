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
    public class ACSFCUser
    {
        #region "SELECT"

        public List<User> Select_User()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_User", DateTime.Now
                    , "No Params");

                return new ACSBLUser().Select_User();
            }
            catch ( Exception ex)
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

                return new ACSBLUser().UserLogIn(UserID, Password).ToList<User>();
            }
            catch ( Exception ex)
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

                return new ACSBLUser().Select_Role();
            }
            catch ( Exception ex)
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

                return new ACSBLUser().Select_UserInRole();
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

                return new ACSBLUser().Select_UserAccessLog();
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

                return new ACSBLUser().Select_UserAccessLogByUserID(UserID);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<UserAccessLog> Select_UserCollectionUsingFilters(String sStatus, String sDisplayName,
                                                            DateTime? loginDateFrom, DateTime? loginDateTo, 
                                                            DateTime? createdDateFrom, DateTime? createdDateTo)
        {
            return new ACSBLUser().Select_UserCollectionUsingFilters(sStatus, sDisplayName, loginDateFrom,
                                                                loginDateTo, createdDateFrom, createdDateTo);            
        }
      
        #endregion

        #region "INSERT"

        public int Insert_NewUser(string userID, string password, string displayName, string status, string position, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_NewUser", DateTime.Now,
                  "[userID=" + userID + "][password=" + password + "][displayName=" + displayName + "][status=" + status 
                  + "][createdDate=" + createdDate + "][createdBy=" + createdBy + "][modifedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

                return new ACSBLUser().Insert_NewUser(userID, password, displayName, status, position, createdDate, createdBy, modifiedDate, modifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_UserInRole", DateTime.Now
                    , "[userID=" + userID + "][roleID=" + roleID 
                    + "][createdDate=" + createdDate + "][createdBy=" + createdBy + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

                return new ACSBLUser().Insert_UserInRole(userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int Insert_UserAccessLog(string userID, Nullable<System.DateTime> accessDate, string action, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_UserAccessLog", DateTime.Now
                , "[userID=" + userID + "][accessDate=" + accessDate + "][action=" + action 
                + "][createdDate=" + createdDate + "][createdBy=" + createdBy + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

                return new ACSBLUser().Insert_UserAccessLog(userID, accessDate, action, createdDate, createdBy, modifiedDate, modifiedBy);
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

        #region "UPDATE"

        public int Update_User(string userID, string password, string displayName, string status, string position, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_User", DateTime.Now
                    , "[userID=" + userID + "][password=" + password + "][displayName=" + displayName + "][status=" + status
                    + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

                return new ACSBLUser().Update_User(userID, password, displayName, status, position, modifiedDate, modifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_UserInRole", DateTime.Now
                    , "[userID=" + userID + "][roleID=" + roleID
                    + "][modifiedDate=" + modifiedDate + "][modifiedBy=" + modifiedBy + "]");

                return new ACSBLUser().Update_UserInRole(userID, roleID, modifiedDate, modifiedBy);
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

        #region "DELETE"

        public int DeleteUserByUserID(string UserID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("DeleteUserByUserID", DateTime.Now
                    , "[UserID=" + UserID + "]");

                return new ACSBLUser().DeleteUserByUserID(UserID);
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

                return new ACSBLUser().DeleteUserInRoleByUserID(UserID);
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

    }
}
