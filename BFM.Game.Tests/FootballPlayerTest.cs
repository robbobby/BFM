using System;
using System.Collections.Generic;
using BFM.Game.PersonEntity;
using BFM.Game.PersonEntity.Attributes;
using BFM.Game.PersonEntity.Character;
using BFM.Game.PersonEntity.Enums;
using Xunit;
using Xunit.Abstractions;

namespace BFM.Game.Tests {
    public class FootballPlayerTest {

        private readonly ITestOutputHelper _output;
        public FootballPlayerTest(ITestOutputHelper output) {
            _output = output;
        }

        [Fact]
        public void PlayerHasAttributesLoading() {
            Dictionary<MentalAttribute, byte> footballPlayer = new FootballPlayer().MentalAttributes;
            foreach (var attribute in footballPlayer) {
                _output.WriteLine(("key: ", attribute.Key, "\n value: ", attribute.Value).ToString());
            }
        }
    }
}
