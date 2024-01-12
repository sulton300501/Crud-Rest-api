using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class PatchData
    {
      

        public async Task PatchAsync()
        {
            var httpClient = new HttpClient();
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                   userId=2,
                   id=3,
                   title="Sulton Malik",
                   completed=true

                }),
                Encoding.UTF8,
                "application/json"); ;
            httpClient.BaseAddress = new Uri(" https://jsonplaceholder.typicode.com/");

            using HttpResponseMessage response = await httpClient.PatchAsync(
                "todos/1",
                jsonContent);

            response.EnsureSuccessStatusCode();
          

            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");

            // Expected output
            //   PATCH https://jsonplaceholder.typicode.com/todos/1 HTTP/1.1
            //   {
            //     "userId": 1,
            //     "id": 1,
            //     "title": "delectus aut autem",
            //     "completed": true
            //   }
        }


    }
}
