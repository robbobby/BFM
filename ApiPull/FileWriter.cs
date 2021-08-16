using System;
using System.IO;
using RestSharp;
namespace ApiPull {
    public class FileWriter {
        public static void WriteToFile(LeagueCollection leagueCollection) {
            using (StreamWriter writer = new StreamWriter("/Users/rob/desktop/temp")) {
                writer.WriteLine(leagueCollection);
            }
            Console.WriteLine("Reading stuff");
            Console.WriteLine(File.ReadAllText("/Users/rob/desktop/temp"));
        }
    }
}
