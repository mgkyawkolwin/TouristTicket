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
            return new ACSBLUser().Select_User();
        }

        public List<User> UserLogin(string UserID, string Password)
        {
            return new ACSBLUser().UserLogIn(UserID, Password).ToList<User>();
        }

        public List<Role> Select_Role()
        {
            return new ACSBLUser().Select_Role();
        }

        public List<UserAccessLog> Select_UserAccessLog()
        {
            return new ACSBLUser().Select_UserAccessLog();
        }

        public List<UserAccessLog> Select_UserAccessLogByUserID(string UserID)
        {
            return new ACSBLUser().Select_UserAccessLogByUserID(UserID);
        }

        #endregion

        #region "INSERT"

        public int Insert_NewUser(string userID, string password, string displayName, string status, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSBLUser().Insert_NewUser(userID, password, displayName, status, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        public int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSBLUser().Insert_UserInRole(userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        public int Insert_UserAccessLog(string userID, Nullable<System.DateTime> accessDate, string action, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSBLUser().Insert_UserAccessLog(userID, accessDate, action, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        #endregion

        #region "UPDATE"

        public int Update_User(string userID, string password, string displayName, string status, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSBLUser().Update_User(userID, password, displayName, status, modifiedDate, modifiedBy);
        }

        public int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSBLUser().Update_UserInRole(userID, roleID, modifiedDate, modifiedBy);
        }

        #endregion

        #region "DELETE"



        #endregion

    }
}
