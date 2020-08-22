using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            /*
            string url = "http://localhost/pZone/pageLimit.php";
            int pgCount ;
            bool isValid = getInfo(&pgCount, url);
            if (pgCount == -1)
            {
                Console.WriteLine("Problem on server");

            }
            else if(isValid)
            {
                Console.WriteLine("Active ID and pg:"+pgCount);
            }
            else
            {
                Console.WriteLine("Deactive ID and pg:" + pgCount);
            }*/

            List<String> ls = new List<string>();
            ls.Add("file1.txt");
            ls.Add("file2.txt");
            ls.Add("file3.txt");
            ls.Add("file4.txt");
            string id = "1722231042";
            string pg = "10";
            string appkey = "apadoto nai";
            //string payLoad = "{\"id\" : \""+ id + "\", \"pg\" : \""+pg+"\", \"appKey\" : \""+appkey+"\",\"files\" : [\"file1.txt\", \"file2.txt\", \"file3.txt\"]}";
            string payLoad = "{\"id\" : \""+ id + "\", \"pg\" : \""+pg+"\", \"appKey\" : \""+appkey+"\",\"files\" : [";
            for(int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
                payLoad += "\""+ls[i]+"\"";
                if (i + 1 == ls.Count)
                {
                    payLoad += "]}";
                    break;
                }
                payLoad += ",";
            }
            Console.WriteLine(payLoad);

            Console.ReadLine();
        }

        // if pg = -1 and false means problem on srver or invalid request
        // id pg > -1 then valid and true means account is active false means blocked
        static unsafe bool getInfo(int* pg, string url)
        {
            string id = "1722231042";
            string machineName = "ABCD";
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n  \"id\" : \""+id+"\" ,\r\n  \"machineName\" :\""+machineName+"\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.Content.Contains("status"))
            {
                dynamic res = JObject.Parse(response.Content.ToString());
                *pg = res.pgCount;
                if(res.accountStatus == 1)
                {
                    return true;
                }
                return false;
            }
            *pg = -1;
            return false;
        }
    }
}
