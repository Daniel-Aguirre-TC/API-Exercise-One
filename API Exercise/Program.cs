using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace API_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 40);
            var client = new HttpClient();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nKanye: " + JObject.Parse(client.GetStringAsync("https://api.kanye.rest").Result)
                    .GetValue("quote").ToString());

                Console.WriteLine("\nRon: " + JArray.Parse(client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result)
                    .ToString().Replace('[', ' ').Replace(']', ' ').Trim());
            }
        }
    }
}
