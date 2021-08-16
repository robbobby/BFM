using System;
using System.IO;
using System.Threading.Tasks;
using RestSharp;
namespace ApiPull {
    public class ApiSport {
        public static string GetApiData() {
            var client = new RestClient("https://v3.football.api-sports.io/leagues?country=England");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", Secret.GetXRapidApiKey());
            request.AddHeader("x-rapidapi-host", "v3.football.api-sports.io");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response);
            using (StreamWriter writer = new StreamWriter("/Users/rob/desktop/temp")) {
                writer.WriteLine(response.Content);
            }
            Console.WriteLine("Reading stuff");
            Console.WriteLine(File.ReadAllText("/Users/rob/desktop/temp"));
            return response.Content;
        }
    }
}
