using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTasks
{
    class Connection
    {
        // Все методы класса возвращают строку с ответом на запрос или null - если возникла ошибка при подключении
        public int Status { get; private set; } // Поле для отладки, статус -2 - проблемы при подключении, -1 - ошибка доступа, 1 - запрос был выполнен успешно

        // Метод получения JSON с сервера по адресу запроса (adr)
        public string GetJSON(string adr)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://ip2020.std-982.ist.mospolytech.ru/" + adr); // http://localhost:5000/  
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                string answer = new StreamReader(response.GetResponseStream()).ReadToEnd();
                if (int.TryParse(answer, out var i))
                {
                    Status = i;
                    return null;
                }
                else
                {
                    Status = 1;
                    return answer;
                }
            }
            catch (Exception e)
            {
                // Вывод ошибки сервера
                MessageBox.Show(e.Message);
                Status = -2;
                return null;

            }
        }
        // метод отправки JSON на сервер, adr - параметр запроса, str - JSON тело запроса
        public string PostJSON(string adr, string str) 
        {
            try
            {
                WebRequest request = WebRequest.Create("http://ip2020.std-982.ist.mospolytech.ru/" + adr); // http://localhost:5000/ 
                request.Method = "POST";
                string postData = str;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                if (((HttpWebResponse)response).StatusDescription == "OK")
                {
                    Status = 1;
                    return (responseString);
                }
                else
                {
                    Status = -2;
                    return null;
                }
            }
            catch(Exception e)
            {
                // Вывод ошибки сервера
                MessageBox.Show(e.Message);
                Status = -2;
                return null;

            }
        }
    }
}
