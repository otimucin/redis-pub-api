using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StackExchange.Redis;

namespace SporRedisPub1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Timer t = new Timer(DisplayTimeEvent, null, 0, 15000);
            Console.ReadLine();
        }
        private static void DisplayTimeEvent(Object o)
        {
            callApi();
        }
        public static void callApi()
        {
            string apiUrl = "http://sportcenterweb.hurriyet.com.tr/api/v1/livescore/matchlist";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader readerStream = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));

            string json = readerStream.ReadToEnd();
            //var tmp = JsonConvert.DeserializeObject<List<LiveScore>>(json);

            //var jo = JObject.Parse(json);

            //Console.WriteLine("Country : " + (string)jo["country_name"]);
            //Console.WriteLine("Country Code : " + (string)jo["country_code"]);
            //Console.WriteLine("Region Code : " + (string)jo["region_code"]);
            //Console.WriteLine("City : " + (string)jo["city"]);
            //Console.WriteLine("Zip Code :" + (string)jo["zipcode"]);
            //Console.WriteLine("Latitude :" + (string)jo["latitude"]);
            //Console.WriteLine("Longitude :" + (string)jo["longitude"]);

            readerStream.Close();

            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("localhost:32768");
            ISubscriber sub = connection.GetSubscriber();

            //Console.WriteLine("Press a key to pubish");
            //Console.ReadLine();

            sub.Publish("ozgun", json);

            //Console.ReadLine();
        }
    }
    
}
