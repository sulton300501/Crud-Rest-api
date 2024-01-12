using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp45
{
    public class GetData
    {
       
        public void GetMalumotlar()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            var response = client.GetAsync("todos/3").Result;
            
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }




    }
}
