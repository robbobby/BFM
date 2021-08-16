using System.Collections.Generic;
using BFM.Game.MiscUnsorted.Enums;
using Newtonsoft.Json;
namespace ApiPull {
    public class League {
        public int id { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }
        public Country Country { get; set; }

    }
}
