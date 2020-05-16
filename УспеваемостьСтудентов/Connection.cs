using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УспеваемостьСтудентов
{
    class Connection
    {
        public int status { get; private set; }

        public string get(string a)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:5000/" + a); //  http://ip2020.std-913.ist.mospolytech.ru/
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                status = 1;
                return (new StreamReader(response.GetResponseStream()).ReadToEnd());
            }
            catch
            {
                status = -2;
                return null;
                
            }
        }
        public string post(string adr, string str)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://localhost:5000/" + adr); //  http://ip2020.std-913.ist.mospolytech.ru/
                request.Method = "POST";
                MessageBox.Show(str);
                string postData = str;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                //MessageBox.Show(responseString);
                if (((HttpWebResponse)response).StatusDescription == "OK")
                {
                    status = 1;
                    return (responseString);
                }
                else
                {
                    status = -2;
                    return null;
                }
            }
            catch
            {
                status = -2;
                return null;

            }
        }
    }
}
