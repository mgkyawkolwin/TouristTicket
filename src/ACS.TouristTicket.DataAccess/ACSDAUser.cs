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
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               return db.SelectUser().ToList<User>();
           }
       }
       
       public List<User> UserLogIn(string UserID, string Password)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               return db.UserLogIn(UserID, Password).ToList<User>();
           }
       }

       public List<Role> Select_Role()
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               return db.SelectRole().ToList<Role>();
           }
       }

       public List<UserAccessLog> Select_UserAccessLog()
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               return db.SelectUserAccessLog().ToList<UserAccessLog>();
           }
       }

       public List<UserAccessLog> Select_UserAccessLogByUserID(string UserID)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               return db.SelectUserAccessLogByUserID(UserID).ToList<UserAccessLog>();
           }
       }

       public List<UserInRole> Select_UserInRole()
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               return db.SelectUserInRole().ToList<UserInRole>();
           }
       }

       public List<UserAccessLog> Select_UserCollectionUsingFilters(String sStatus, String sDisplayName,
                                                          DateTime? loginDateFrom, DateTime? loginDateTo, 
                                                          DateTime? createdDateFrom, DateTime? createdDateTo)
       {
           using (TouristTicketContainer _db = new TouristTicketContainer())
           {
               _db.ContextOptions.LazyLoadingEnabled = false;
               _db.ContextOptions.ProxyCreationEnabled = false;
               return _db.SelectUserCollectionUsingFilters(sStatus, sDisplayName, loginDateFrom, loginDateTo, createdDateFrom, createdDateTo).ToList<UserAccessLog>();
           }
       }
      
       #endregion

       #region "INSERT"

       public int Insert_NewUser(string userID, string password, string displayName, string position, string status, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

              db.InsertNewUser(PKID, userID, password, displayName, status, position, createdDate, createdBy, modifiedDate, modifiedBy,errorCode, errorMsg);
           }
           return 0;
       }

       public int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.InsertUserInRole(PKID, userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy, errorCode, errorMsg);
           }
               return 0;
       }

       public int Insert_UserAccessLog(string userID, Nullable<System.DateTime> accessDate, string action, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.InsertUserAccessLog(PKID, userID, accessDate, action, createdDate, createdBy, modifiedDate, modifiedBy, errorCode,errorMsg); 
           }
               return 0;
       }

       #endregion

       #region "UPDATE"

       public int Update_User(string userID, string password, string displayName, string status, string position, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.UpdateUser(userID, password, displayName, status, position, modifiedDate, modifiedBy, errorCode, errorMsg);
           }
           return 0;
       }

       public int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.UpdateUserInRole(PKID, userID, roleID, modifiedDate, modifiedBy, errorCode, errorMsg);
           }
           return 0;
       }

       #endregion

       #region "DELETE"

       public int DeleteUserByUserID(string UserID)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.DeleteUserByUserID(UserID,errorCode,errorMsg);
           }
           return 0;
       }

       public int DeleteUserInRoleByUserID(string UserID)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.DeleteUserByUserID(UserID, errorCode,errorMsg);
           }
           return 0;
       }

       #endregion

   }
}
