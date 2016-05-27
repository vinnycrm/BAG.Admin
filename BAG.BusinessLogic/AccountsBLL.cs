using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using BAG.Models;
using System.IO;
using System.Net;


namespace BAG.BusinessLogic
{
    public class AccountsBLL
    {

        public U_ADMIN_lOGIN_Ref LoginPro(U_USR_Lgn ouser)
        {
            try
            {
                StreamReader readStream;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@"http://" + GeneralBLL.Service_Link + "/Services/AdminService.svc/getLoginValidate");
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = @"application/json; charset=utf-8";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(ouser);

                    streamWriter.Write(json);
                }

                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                readStream = new StreamReader(httpResponse.GetResponseStream());

                var serializer = new DataContractJsonSerializer(typeof(U_ADMIN_lOGIN_Ref));

                U_ADMIN_lOGIN_Ref obj = serializer.ReadObject(readStream.BaseStream) as U_ADMIN_lOGIN_Ref;

                return obj;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
