using System.Collections.Generic;
using BFM.Game.Clubs;
using BFM.Game.MiscUnsorted.Enums;
namespace BFM.Game.Competition {
    public class League : ICompetition {
        public string Name { get; }
        public Country Nation { get; }
        // public Continent Continent { get; } // TODO: Continents
        public short Reputation { get; }
        public TrophyType TrophyType { get; }
        public CompetitionType CompetitionType { get; }
        public int CompetitionLevel { get; }
        public List<Club> Clubs;
    }
}
