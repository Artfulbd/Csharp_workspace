using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            //string url = "http://localhost/pZone/commingin.php";
            string url = "http://localhost/pZone/takeFiles.php"; ;
            string id = "1722231042";
            string key = "10";
            string machine = "apadoto nai";
            //string payLoad = "{\"id\" : \""+ id + "\", \"pg\" : \""+pg+"\", \"appKey\" : \""+appkey+"\",\"files\" : [\"file1.txt\", \"file2.txt\", \"file3.txt\"]}";
            //string payLoad = "{\"id\":\""+id+"\",\"machine\":\""+machine+"\",\"key\":\""+key+"\"}";
            string payLoad = "{\"id\":\"" + id + "\",\"pc_name\":\"" + "abcd" + "\",\"key\":\"" + "no key" + "\",\"file_count\":\"1\",\"files\":[{\"file_name\": \"" + "some name" + "\",\"time\":\"" + "00"+ "\",\"pg_count\":\"" + 52 + "\",\"size\":\"" + 512 + "\"}]}";

            Console.WriteLine(payLoad);
            //initialDecode(doRequest(url, payLoad));
            takeFile(doRequest(url, payLoad));
            Console.ReadLine();
        }
        private static bool takeFile(IRestResponse response)
        {

            bool success = false;
            //Console.WriteLine(response.Content.ToString());
            if ((int)response.StatusCode == 200 && response.Content.Contains("status"))
            {
                dynamic res = JObject.Parse(response.Content.ToString());

                try
                {
                    success = (res.status == "1" && res.msg == "success");
                    Console.WriteLine("Success: "+success);

                }
                catch (Exception ex)
                {
                    success = false;
                    Console.WriteLine("Exception");
                }
            }
            else
            {
                Console.WriteLine("Status code not valid.!!");
                success = false;
            }
            // true if file successfully added to database via API;
            return success;
        }

        static void initialDecode(IRestResponse response)
        {
            if ((int)response.StatusCode == 200 && response.Content.Contains("status"))
            {
                dynamic res = JObject.Parse(response.Content.ToString());
                if (res.status == "1")
                {
                    Console.WriteLine("got one");
                    if(res.active == "1")
                    {
                        // active id, fetch data
                        //“status”:”1”,  
                        //“name”:” ”,
                        //“active”:”1”,
                        //“pgLeft”:” ”,
                        //“pgPrinted”:” ”,
                        //“server”:”server file location”,
                        //“temp”:”temporary file location on local”,
                        //“hidden”:”hidden file location on local”,
                        //“filePending”:”2”,
                        //“files”:[

                        //        { “file_name”:””,
                        //“time”:””,
                        //“pg_count”:””
                        //“size”:”file size in kilobyte”
                        //“is_online”:”0 if have downloading complexity”} 
                        //,
                        //  { “file_name”:””,
                        //“time”:””,
                        //“pg_count”:””
                        //“size”:” file size in kilobyte”
                        //“is_online”:””}
                        //  ]
                        //}

                        Console.WriteLine("Name: " + res.name);
                        Console.WriteLine("Page left: " + res.pgLeft);
                        Console.WriteLine("Total printed: " + res.pgPrinted);
                        Console.WriteLine("Server Location: " + res.server);
                        Console.WriteLine("Temp dir: " + res.temp);
                        Console.WriteLine("Hidden dir: " + res.hidden);
                        Console.WriteLine("File pending:" + res.filePending);
                        int pending = res.filePending;
                        Console.WriteLine("\n_____files_____");
                        DateTime dt;
                        for(int i= 0; i<pending; i++)
                        {
                            Console.WriteLine("File name: "+res.files[i].file_name);
                            Console.WriteLine("Page count: "+res.files[i].pg_count);
                            Console.WriteLine("size: "+res.files[i].size);
                            Console.WriteLine("time: "+res.files[i].time);
                            //dt = new DateTime(res.files[i].time);
                            //DateTime dateValue = DateTime.Now; // mySQL
                            //string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
                            //Console.WriteLine(formatForMySql + "\n");
                        }
                    }
                    else if(res.active == "0")
                    {
                        Console.WriteLine("Id deactivated..!");
                    }

                }
                if(res.status == "0")
                {
                    Console.WriteLine("Status code zero, error, connect to it msg: "+res.msg);
                }
            }
            else
            {
                Console.WriteLine("Error code: " + (int)response.StatusCode);
            }
        }
        static IRestResponse doRequest(string url, string payLoad)
        {
            
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json,application/json", payLoad, ParameterType.RequestBody);
            return client.Execute(request);
            
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
