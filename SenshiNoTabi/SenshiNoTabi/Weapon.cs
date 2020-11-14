using System;
using System.Collections.Generic;
using System.Text;

namespace SenshiNoTabi
{
    public class Weapon
    {
        public Weapon(string name, int physicalAttack, int weaponSpeed)
        {
            Name = name;
            PhysicalAttack = physicalAttack;
            WeaponSpeed = weaponSpeed;
        }

        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = string.IsNullOrWhiteSpace(value) ? "typicalName" : value;
        }

        private int _physicalAttack;
        public int PhysicalAttack
        {
            get => _physicalAttack;
            private set => _physicalAttack = value < 0 ? 0 : value;
        }

        private int _weaponSpeed;
        public int WeaponSpeed
        {
            get => _weaponSpeed;
            private set => _weaponSpeed = value < 0 ? 0 : value;
        }

    }
}
