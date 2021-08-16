using System.Collections.Generic;
using BFM.Game.PersonEntity.Attributes;
using BFM.Game.PersonEntity.Contract;
namespace BFM.Game.PersonEntity.Character {
    public class FootballPlayer : SignablePerson {
        private short Height { get; set; }
        private short Weight { get; set; }

        public Dictionary<GoalkeeperAttribute, byte> GoalkeeperAttributes { get; } = AttributeInitialiser.InitialiseAttribute<GoalkeeperAttribute>();
        public Dictionary<MentalAttribute, byte> MentalAttributes { get; } = AttributeInitialiser.InitialiseAttribute<MentalAttribute>();
        public Dictionary<PhysicalAttribute, byte> PhysicalAttributes { get; } = AttributeInitialiser.InitialiseAttribute<PhysicalAttribute>();
        public Dictionary<HiddenAttribute, byte> HiddenAttributes { get; } = AttributeInitialiser.InitialiseAttribute<HiddenAttribute>();
        public Dictionary<TechnicalAttribute, byte> TechnicalAttributes { get; } = AttributeInitialiser.InitialiseAttribute<TechnicalAttribute>();
        private byte[] Feet = new byte[2];

        private List<PlayingTrait> Traits { get; }

        private short FitnessLevel { get; set; }
        private short Sharpness { get; set; }
        private short Fatigue { get; set; }

        private Injury Injury { get; set; }

        private int MarketValue { get; set; }
        private int AskingPrice { get; set; }
        
        public string ShirtName { get; set; }

        public short CurrentAbility { get; set; }
        public short PotentialAbility { get; set; }
        public Dictionary<Person, byte> Partnerships { get; }
        
        // TODO: public List<Bans>
    }
}
