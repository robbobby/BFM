using System;
using System.Diagnostics;
using BFM.Game.MiscUnsorted.Enums;
namespace ApiPull.Helpers {
    public class CountryHelper {
        public static Country GetCountryFromJson(string _country) {
            return (Country) Enum.Parse(typeof(Country), _country);
        }
    }
}
