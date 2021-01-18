using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Console_API_Oin_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:8000";
            Console.WriteLine("Starting web server at " + url);
            WebApp.Start<Startup>(url);
            HttpClient client = new HttpClient();
            var res = client.GetAsync("http://localhost:8000/api/Category   ").Result;
            Console.WriteLine(res.ToString());
            Console.WriteLine(res.Content.ReadAsStringAsync().Result);
            Console.ReadLine();
        }
    }
}
