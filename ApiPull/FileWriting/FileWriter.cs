using System;
using System.Collections.Generic;
using System.IO;
namespace ApiPull.FileWriting {
    public static class FileWriter {
        public static void WriteToFile(List<League> _leagues) {
            using (StreamWriter writer = new StreamWriter("LeagueCsv.csv")) {
                foreach (League league in _leagues) {
                    if(league.name.Contains("Women") || league.name.Contains("WSL"))
                        continue;
                    writer.WriteLine(string.Join(',',  league.id, league.name, league.Type, league.Logo));
                }
            }
            Console.WriteLine("Reading stuff");
            foreach (League league in _leagues) {
                if(!league.name.Contains("Women"))
                    continue;
                Console.WriteLine(league.name);
                Console.WriteLine(league.Type);
            }
            Console.WriteLine(File.ReadAllText("LeagueCsv.csv"));
        }
    }
}
