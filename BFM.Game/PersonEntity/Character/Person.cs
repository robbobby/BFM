using System;
using System.Collections.Generic;
using BFM.Game.Clubs;
using BFM.Game.MiscUnsorted.Enums;
using BFM.Game.PersonEntity.Enums;
using BFM.Game.PersonEntity.Misc;
using BFM.Game.PersonEntity.PersonHistory;
namespace BFM.Game.PersonEntity.Character {
    public abstract class Person {
        public int UniqueId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Country> Nationality { get; }
        
        public PersonCareerType CareerType { get; }
        public List<ICareerPlan> CareerPlans { get; }

        public Dictionary<StaffRole, byte> StaffRolePreference;
        public Dictionary<Language, byte> LanguagesSpoken;
        
        
        public Dictionary<Person, Dictionary<RelationshipType, byte>> PersonalRelationships { get; }
        public Dictionary<Club, Dictionary<ClubRelationshipType, byte>> ClubRelationships { get; }
        public PlayingHistory PlayingHistory { get; } // TODO: Make the playing history class
        public NonPlayingHistory NonPlayingHistory { get; }
        public List<IAchievement> Achievements { get; }
    }
}
