using System.IO;
namespace ApiPull {
    public class TestJson {
        public static string FilePath = "../../../Response.json";
        public static string Json { get; set; }= File.ReadAllText(FilePath);
    }
}
