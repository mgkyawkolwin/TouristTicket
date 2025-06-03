using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Net;

namespace ACS.TouristTicket.Common
{
    public class ACSCUtility
    {
        public static bool IsConnectedToService()
        {
            string host = System.Configuration.ConfigurationManager.AppSettings["AdminDataSyncServiceURL"].ToString();
            bool result = false;
            try
            {
                WebRequest request = WebRequest.Create(host);
                WebResponse response = request.GetResponse();
                response.Close();
                return true;
            }
            catch { }
            return result;
        }

        public static bool IsConnectedToInternet()
        {
            string host = "http://www.google.com";
            bool result = false;
            try
            {
                WebRequest request = WebRequest.Create(host);
                WebResponse response = request.GetResponse();
                response.Close();
                return true;
            }
            catch { }
            return result;
        }
    }
}
