using BAG.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BAG.BusinessLogic
{
    public class EventsBLL
    {
        public U_EVNT_MASTER[] GetAllEventsDetails()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/EventsDetails");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(U_EVNT_MASTER[]));
                U_EVNT_MASTER[] obj = serializer.ReadObject(readStream.BaseStream) as U_EVNT_MASTER[];
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public Events GetEventDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/SingleEventDetails/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(Events));
                Events obj = serializer.ReadObject(readStream.BaseStream) as Events;
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public EventsWishList[] GetEventWishListDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/EventWishListDetails/"+ id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(EventsWishList[]));
                EventsWishList[] obj = serializer.ReadObject(readStream.BaseStream) as EventsWishList[];
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public int UpdateEventDetails(Events eve)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/UpdateEvent");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(eve);

                    streamWriter.Write(json);
                }

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(int));

                int obj = Convert.ToInt32(serializer.ReadObject(readStream.BaseStream));

                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
    }
}
