using System.Collections.Generic;
using BFM.Game.Clubs.Facilities;
using BFM.Game.Clubs.Finance;
using BFM.Game.Clubs.Personnel;
using BFM.Game.Competition;
using BFM.Game.MiscUnsorted;
using BFM.Game.PersonEntity;
using BFM.Game.PersonEntity.Character;
namespace BFM.Game.Clubs {
    public class Club {
        public short Morale { get; set; }
        public short Reputation { get; set; }
        public string Name { get; }
        public ClubSquad Squad { get; set; }
        public Financial Financial { get; }
        public Nation Nation { get; }
        public League League { get; }
        public ClubProfessionalStatus ProfessionalStatus { get; set; }
        public ClubFacilities ClubFacilities { get; set; }
        public ClubStaff Staff { get; }
        public ClubRelationships Relationships { get; }
        public Dictionary<Club, KeyValuePair<ClubAffiliationType, byte>> ClubAffiliations { get; }
    }
    public class ClubRelationships {
        public Dictionary<Club, KeyValuePair<RivalryReason, byte>> RivalClubs { get; }
        public Dictionary<Person, KeyValuePair<FavouritePersonRelationshipType, byte>> FavouritePeople { get; }
        public Dictionary<Person, byte> DislikedPeople { get; }
        public Dictionary<Person, KeyValuePair<FavouritePersonRelationshipType, byte>> ClubLegends { get; }
        public Dictionary<Person, KeyValuePair<FavouritePersonRelationshipType, byte>> ClubIcons { get; }
    }
    
    public enum RivalryReason {
        Local,
        Competitive,
        Historic
    }
}


// ClubVision
// TacticalAttributes
//