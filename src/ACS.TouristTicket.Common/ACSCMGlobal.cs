using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.TouristTicket.Common
{
    public class ACSCMGlobal
    {
        static bool AccessGrated;
        public bool accessGranted
        {
            get { return AccessGrated; }
            set { AccessGrated = value; }
        }

        static bool ProcessCancel;
        public bool processCancel
        {
            get { return ProcessCancel; }
            set { ProcessCancel = value; }
        }

        #region "log in user info"
        /// <summary>
        /// Save logIn user info
        /// </summary>
        /// 

        static int userPKID;
        public int _userPKID
        {
            get { return userPKID; }
            set { userPKID = value; }
        }

        static string userID;
        public string _userID
        {
            get { return userID; }
            set { userID = value; }
        }

        static string displayName;
        public string _displayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        static string password;
        public string _password
        {
            get { return password; }
            set { password = value; }
        }

        static string userType;
        public string _userType
        {
            get { return userType; }
            set { userType = value; }
        }

        static string status;
        public string _status
        {
            get { return status; }
            set { status = value; }
        }


        static string position;
        public string _position
        {
            get { return position; }
            set { position = value; }
        }

        #endregion

        /// <summary>
        /// Save whether to Collapse or not the tree view of MainForm
        /// </summary>
        static bool fromEdit = true;
        public bool _fromEdit
        {
            get { return fromEdit; }
            set { fromEdit = value; }
        }

        public string Get_HasedPassword(string orgPassword)
        {
            byte[] hashPw;

            System.Security.Cryptography.SHA1CryptoServiceProvider shaw = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            hashPw = shaw.ComputeHash(UTF8Encoding.Default.GetBytes(orgPassword));

            return Convert.ToBase64String(hashPw);
        }

        
    }
}
