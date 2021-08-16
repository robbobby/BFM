using System.Collections.Generic;
using BFM.Game.PersonEntity.Attributes;
using BFM.Game.PersonEntity.PlayingPositions;
namespace BFM.Game.PersonEntity.Character {
    public class SignablePerson : Person {
        public Contract.Contract Contract { get; set; }
        public short Morale { get; set; }
        public short HomeReputation { get; set; }
        public short NationalReputation { get; set; }
        public short WorldReputation { get; set; }
        public Dictionary<PersonalityAttribute, byte> PersonalAttribute;
        public Dictionary<PlayingPosition, byte> PositionAbility;
    }

}
