using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.DataAccess;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLUser
    {

        #region  "SELECT:

        public List<User> Select_User()
        {
            return new ACSDAUser().Select_User();
        }

        public List<User> UserLogIn(string UserID, string Password)
        {
            return new ACSDAUser().UserLogIn(UserID, Password);
        }

        public List<Role> Select_Role()
        {
            return new ACSDAUser().Select_Role();
        }

        public List<UserAccessLog> Select_UserAccessLog()
        {
            return new ACSDAUser().Select_UserAccessLog();
        }

        public List<UserAccessLog> Select_UserAccessLogByUserID(string UserID)
        {
            return new ACSDAUser().Select_UserAccessLogByUserID(UserID);
        }

        #endregion

        #region "INSERT"

        public int Insert_NewUser(string userID, string password, string displayName, string status, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSDAUser().Insert_NewUser(userID, password, displayName, status, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        public int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSDAUser().Insert_UserInRole(userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        public int Insert_UserAccessLog(string userID, Nullable<System.DateTime> accessDate, string action, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSDAUser().Insert_UserAccessLog(userID, accessDate, action, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        #endregion

        #region "UPDATE"
        
        public int Update_User(string userID, string password, string displayName, string status, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSDAUser().Update_User(userID, password, displayName, status, modifiedDate, modifiedBy);
        }

        public int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSDAUser().Update_UserInRole(userID, roleID, modifiedDate, modifiedBy);
        }

        #endregion

        #region "DELETE"
        #endregion

    }
}
