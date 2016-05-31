using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BAG.BusinessLogic
{
    public class VendorBLL
    {
        public string VendorsCount()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/VendorsCount");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(string));
                string obj = serializer.ReadObject(readStream.BaseStream) as string;
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
