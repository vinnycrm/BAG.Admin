using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAG.Models;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace BAG.BusinessLogic
{
    public class ItemsBLL
    {
        public A_ADM_ITEM_MASTER[] GetAllItemsDetails()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/ItemsDetails");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());
                var serializer = new DataContractJsonSerializer(typeof(A_ADM_ITEM_MASTER[]));
                A_ADM_ITEM_MASTER[] obj = serializer.ReadObject(readStream.BaseStream) as A_ADM_ITEM_MASTER[];
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public bool InsertNewItem(Admin_Items item)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/CreateNewItem");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(item);

                    streamWriter.Write(json);
                }

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(bool));

                bool obj = Convert.ToBoolean(serializer.ReadObject(readStream.BaseStream));

                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public A_ADM_ITEM_MASTER GetSingleItemDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/SingleItemDetails/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(A_ADM_ITEM_MASTER));
                A_ADM_ITEM_MASTER obj = serializer.ReadObject(readStream.BaseStream) as A_ADM_ITEM_MASTER;
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public bool BlockThisItem(string id)
            {
                try
                {
                    StreamReader readStream;
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/BlockThisItem/" + id);
                    httpWebRequest.Method = "GET";
                    httpWebRequest.ContentType = @"application/json; charset=utf-8";
                    HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(bool));

                bool obj = Convert.ToBoolean(serializer.ReadObject(readStream.BaseStream));

                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool UnBlockThisItem(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/UnblockThisItem/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(bool));

                bool obj = Convert.ToBoolean(serializer.ReadObject(readStream.BaseStream));

                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool UpdateItem(A_ADM_ITEM_MASTER item)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/UpdateItem");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(item);

                    streamWriter.Write(json);
                }

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(bool));

                bool obj = Convert.ToBoolean(serializer.ReadObject(readStream.BaseStream));

                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public string ItemsCount()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/ItemsCount");
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

        public DashboardItems[] Recent5Items()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/Recent5Items");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());
                var serializer = new DataContractJsonSerializer(typeof(DashboardItems[]));
                DashboardItems[] obj = serializer.ReadObject(readStream.BaseStream) as DashboardItems[];
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
