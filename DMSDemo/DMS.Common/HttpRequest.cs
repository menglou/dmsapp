using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Common
{
   public class HttpRequest
    {
        private static int _timeout = 15000;
      

        /// <summary>
        /// 参数是字符串的httppost请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonstr"></param>
        /// <returns></returns>
        public static string httpPost(string url, string jsonstr,string token)
        {
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.ContentType = "application/json";
            request.Timeout = _timeout;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.111 Safari/537.36";
            request.Referer = "http://www.imooc.com/video/11555";

            request.Headers.Add("content-type", "application/json");
            request.Headers.Add("Authorization", "Bearer" + " " + token);

            request.Method = "POST";

            //封装参数
            byte[] buffer = encoding.GetBytes(jsonstr);

            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string result = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }
        /// <summary>
        /// 参数是字典的httppost请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string httpPost(string url, Dictionary<string, string> param,string token)
        {
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
           
            request.ContentType = "application/json";
            request.Timeout = _timeout;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.111 Safari/537.36";
            request.Referer = "http://www.imooc.com/video/11555";

            request.Headers.Add("content-type","application/json");
            request.Headers.Add("Authorization", "Bearer"+" "+token);

            request.Method = "POST";

            //封装参数
            byte[] buffer = encoding.GetBytes(DictionaryToString.BuildQuery(param));

            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string result = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }



        /// <summary>
        /// 参数是字符串的httpGet请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonstr"></param>
        /// <returns></returns>
        public static string httpGet(string url, string jsonstr,string token)
        {
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url+ jsonstr);
            request.ContentType = "application/json";
            request.Timeout = _timeout;

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.111 Safari/537.36";
            request.Referer = "http://www.imooc.com/video/11555";
            request.Method = "GET";

            //request.Headers.Add("content-type", "application/json");
            request.Headers.Add("Authorization", "Bearer" + " " + token);
            //封装参数
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string result = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }
       

        public static string GetToken(string url,string name,string pwd)
        {
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url+"?name="+ name+ "&passWord="+ pwd);
            request.ContentType = "application/json";
            request.Timeout = _timeout;

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.111 Safari/537.36";
            request.Referer = "http://www.imooc.com/video/11555";
            request.Method = "GET";
            //封装参数
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }
    }
}
