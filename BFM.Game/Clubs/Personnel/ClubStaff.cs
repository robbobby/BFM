using System.Collections.Generic;
using BFM.Game.PersonEntity;
using BFM.Game.PersonEntity.Character;
using BFM.Game.PersonEntity.Enums;
namespace BFM.Game.Clubs.Personnel {
    public class ClubStaff {
        public Dictionary<StaffRole, StaffMember> StaffMembers { get; }
        public Dictionary<StaffRole, StaffMember> StaffMembersAllowed { get; }
    }
}
