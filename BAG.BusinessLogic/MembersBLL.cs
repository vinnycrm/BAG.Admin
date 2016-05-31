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
    public class MembersBLL
    {
        public U_ADMIN_Members[] GetAllMembersDetails()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/MembersDetails");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(U_ADMIN_Members[]));
                U_ADMIN_Members[] obj = serializer.ReadObject(readStream.BaseStream) as U_ADMIN_Members[];
                return obj;
            }
            catch(Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public SubAdmin GetSingleSubAdminDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/SingleSubAdminDetails/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(SubAdmin));
                SubAdmin obj = serializer.ReadObject(readStream.BaseStream) as SubAdmin;
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public U_ADMIN_Members[] GetAllSubAdminDetails()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/SubDetails");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(U_ADMIN_Members[]));
                U_ADMIN_Members[] obj = serializer.ReadObject(readStream.BaseStream) as U_ADMIN_Members[];
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public A_USR_MASTER_V2 GetSingleMemberDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/SingleMemberDetails/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(A_USR_MASTER_V2));
                A_USR_MASTER_V2 obj = serializer.ReadObject(readStream.BaseStream) as A_USR_MASTER_V2;
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public bool NewSubAdmin(A_ModelGroupsList values)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/CreateSubAdmin");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(values);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    result = result.Replace("\"", "");
                    return Convert.ToBoolean(result);
                }
            }
            catch(Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public bool BlockThisMember(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/BlockThisUser/" + id);
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

        public bool UnBlockThisMember(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/UnblockThisUser/" + id);
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

        public MemberContacts[] GetMemberContactsDetails(string id)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/MemberContacts/" + id);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());
                var serializer = new DataContractJsonSerializer(typeof(MemberContacts[]));
                MemberContacts[] obj = serializer.ReadObject(readStream.BaseStream) as MemberContacts[];
                return obj;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public bool UpdateMemberDetails(A_USR_MASTER_V2 usr)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/UpdateMember");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(usr);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    result = result.Replace("\"", "");
                    return Convert.ToBoolean(result);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public bool UpdateSubAdmin(SubAdmin usr)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/UpdateSubAdmin");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(usr);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    result = result.Replace("\"", "");
                    return Convert.ToBoolean(result);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public string MembersCount()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/MembersCount");
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

        public DashboardMember[] Recent5Members()
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/Recent5Membors");
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());
                var serializer = new DataContractJsonSerializer(typeof(DashboardMember[]));
                DashboardMember[] obj = serializer.ReadObject(readStream.BaseStream) as DashboardMember[];
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
