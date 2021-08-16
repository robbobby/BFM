using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ApiPull {
    public class Program {
        public static void Main(string[] args) {
            LeagueCollection leagueCollection = JsonConvert.DeserializeObject<LeagueCollection>(TestJson.Json);
            // LeagueCollection leagueCollection = JsonConvert.DeserializeObject<LeagueCollection>(ApiSport.GetApiData());


            JObject jObject = JObject.Parse(File.ReadAllText(TestJson.FilePath));
            List<JToken> jsonLeagues = jObject["response"]?.Children().ToList();

            List<League> leagues = new List<League>();

            foreach (JToken league in jsonLeagues) {
                leagues.Add(league["league"]?.ToObject<League>());
            }
            foreach (League league in leagues) {
                // Console.WriteLine(league.name);
                // Console.WriteLine(league.Type);
            }
        }
    }
}
