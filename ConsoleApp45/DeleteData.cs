using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    public class DeleteData
    {

        public async Task DeleteFunc()
        {
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/3");

                    var response = await client.DeleteAsync(client.BaseAddress);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Succes...");
                    }
                    else
                    {
                        Console.WriteLine("Fail");
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exeption...");
                }
            }



        }



    }
}
