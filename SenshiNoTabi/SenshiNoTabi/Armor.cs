using System;
using System.Collections.Generic;
using System.Text;

namespace SenshiNoTabi
{
    public class Armor
    {
        public Armor(string name, int armorDefence, int armorWeight)
        {
            Name = name;
            ArmorDefence = armorDefence;
            ArmorWeight = armorWeight;
        }
        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = string.IsNullOrWhiteSpace(value) ? "typicalName" : value;
        }

        private int _armorDefence;
        public int ArmorDefence
        {
            get => _armorDefence;
            private set => _armorDefence = value < 0 ? 0 : value;
        }
        private int _armorWeight;
        public int ArmorWeight
        {
            get => _armorWeight;
            private set => _armorWeight = value < 0 ? 0 : value;
        }
    }
}
