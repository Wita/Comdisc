using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Configuration;

namespace MainProcess.UtilClass
{
    class ConnectionManager
    {
        private static readonly string domain = ConfigurationManager.AppSettings["testConnection"].ToString();

        public static string GetIpByDomain()
        {
            return Dns.GetHostEntry(domain).AddressList[0].ToString();
        }

        public static bool CheckConnection()
        {
            System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
            string data = "";
            byte[] buffer = Encoding.UTF8.GetBytes(data);
            int timeout = 120;
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            
            
            try
            {
                PingReply reply = pingSender.Send(domain, timeout, buffer, options);
                string info = "";
                info = reply.Status.ToString();
                if (info.Equals("Success"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
