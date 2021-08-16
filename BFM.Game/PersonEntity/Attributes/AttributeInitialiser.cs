using System;
using System.Collections.Generic;
namespace BFM.Game.PersonEntity.Attributes {
    public class AttributeInitialiser {
        public static Dictionary<T, byte> InitialiseAttribute<T>() where T : Enum {
            var attributes = new Dictionary<T, byte>();
            Array attributeEnum = typeof(T).GetEnumValues();
            foreach (T attribute in attributeEnum) {
                attributes.Add(attribute, 10);
            }
            return attributes;
        }
    }
}