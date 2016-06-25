using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace OCAID
{
   public  class IDIO
    {
       public static bool Valid(CAIdentity ID)
       {
           try
           {
               HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://standard.arsslensoft.com/OCIAID/validate.php?id="+ID.ID.ToString());
                request.Method = "GET";
                request.Accept = "gzip, deflate";
                request.Proxy = null;
                request.Timeout = 15000;
                request.KeepAlive = true;
                request.UserAgent = "GIG_CLIENT/UserAgent 1.0";
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                // Get the response.
                WebResponse sresponse = request.GetResponse();
               Stream  dataStream = sresponse.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                sresponse.Close();
                if (responseFromServer.Contains("VALID_CAID"))
                    return true;

                else return false;

           }
           catch
           {
               return false;
           }
           return false;
       }
    }
}
