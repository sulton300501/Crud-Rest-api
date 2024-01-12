using System;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;



namespace ConsoleApp45
{

    

    public class Program
    {

        static async Task  Main(string[] args) {


            PostData postData = new PostData();
            postData.Malumotlar();


            GetData getData = new GetData();
            getData.GetMalumotlar();

            DeleteData deleteData = new DeleteData();
            await deleteData.DeleteFunc();

            PatchData patchData = new PatchData();
            await patchData.PatchAsync();










        }

    }
}