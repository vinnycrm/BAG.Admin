using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAG.Models;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace BAG.BusinessLogic
{
    public class GroupsBLL
    {
        public Groups[] getHisGroupsDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/HisGroups/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(Groups[]));
                Groups[] obj = serializer.ReadObject(readStream.BaseStream) as Groups[];
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public Groups[] getJoinedGroupsDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/JoinedGroups/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(Groups[]));
                Groups[] obj = serializer.ReadObject(readStream.BaseStream) as Groups[];
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }
    }
}
