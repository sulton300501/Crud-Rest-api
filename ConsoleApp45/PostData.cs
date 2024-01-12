using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class PostData
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Complated { get; set; }

        public void Malumotlar()
        {

            var postData = new PostData
            {
                UserId = 2,
                Id = 1,
                Title = "sulton",
                Complated = true,
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("posts", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine("Error");
            }


        }

    }



}
