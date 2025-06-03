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
   public class ACSDAUser
   {
       #region "SELECT"

       public List<User> Select_User()
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               return db.SelectUser().ToList<User>();
           }
       }
       
       public List<User> UserLogIn(string UserID, string Password)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               return db.UserLogIn(UserID, Password).ToList<User>();
           }
       }

       public List<Role> Select_Role()
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               return db.SelectRole().ToList<Role>();
           }
       }

       public List<UserAccessLog> Select_UserAccessLog()
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               return db.SelectUserAccessLog().ToList<UserAccessLog>();
           }
       }

       public List<UserAccessLog> Select_UserAccessLogByUserID(string UserID)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               return db.SelectUserAccessLogByUserID(UserID).ToList<UserAccessLog>();
           }
       }

       #endregion

       #region "INSERT"

       public int Insert_NewUser(string userID, string password, string displayName, string status, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
               db.InsertNewUser(PKID, userID, password, displayName, status,createdDate, createdBy, modifiedDate, modifiedBy,ErrorCode);
           }
           return 0;
       }

       public int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
               db.InsertUserInRole(PKID, userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy, ErrorCode);
           }
               return 0;
       }

       public int Insert_UserAccessLog(string userID, Nullable<System.DateTime> accessDate, string action, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
               db.InsertUserAccessLog(PKID, userID, accessDate, action, createdDate, createdBy, modifiedDate, modifiedBy, ErrorCode); 
           }
               return 0;
       }

       #endregion

       #region "UPDATE"

       public int Update_User(string userID, string password, string displayName, string status, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
               db.UpdateUser(PKID, userID, password, displayName, status, modifiedDate, modifiedBy, ErrorCode);
           }
           return 0;
       }

       public int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
               db.UpdateUserInRole(PKID, userID, roleID, modifiedDate, modifiedBy, ErrorCode);
           }
           return 0;
       }

       #endregion

       #region "DELETE"
       #endregion

   }
}
